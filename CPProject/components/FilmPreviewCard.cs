using CPProject.DataBaseModel;
using CPProject.DataBaseModel.entities;
using CPProject.imageHandler;

namespace CPProject.components
{
    public partial class FilmPreviewCard : UserControl, IDisposable
    {
        private static CinemaDataBase? DBInstance = null;
        private bool _disposed = false;
        private Film? film = null;

        private static CinemaDataBase DataBase
        {
            get
            {
                if (DBInstance == null)
                {
                    DBInstance = CinemaDataBase.Instance;
                }
                return DBInstance;
            }
        }

        public FilmPreviewCard(Action onClick, Film film)
        {
            InitializeComponent();
            AddMouseHandlers(this);
            AddHandCursor(this);
            OnClick = onClick;
            Film = film;
            hoverEventTimer = new System.Windows.Forms.Timer();
            clickEventTimer = new System.Windows.Forms.Timer();
            hoverEventTimer.Tick += OnHoverTimerTick;
            clickEventTimer.Tick += OnClickTimerTick;
        }

        public Film? Film { get => film; set { film = value; labelTitle.Text = Film.Title; if (this.Visible) { OnControlVisible(); } } }
        public new Action? OnClick { get; set; }
        private bool isMouseHover = false;
        private bool isMinimizedMode = false;
        private System.Windows.Forms.Timer hoverEventTimer;
        private System.Windows.Forms.Timer clickEventTimer;
        public bool IsMinimizedMode { get => isMinimizedMode; set { isMinimizedMode = value; MinimizeMode(IsMinimizedMode); } }

        private bool IsTimerHoverChecking { get; set; } = false;
        private bool IsTimerClickChecking { get; set; } = false;
        public int TimerHoverDelay { get; set; } = 30;
        private void OnHoverTimerTick(object sender, EventArgs e)
        {
            hoverEventTimer.Stop();
            IsTimerHoverChecking = false;
            setBorderOnHover(isMouseHover);
        }

        private void OnClickTimerTick(object sender, EventArgs e)
        {
            clickEventTimer.Stop();
            IsTimerClickChecking = false;
        }

        private void onHover(bool visible)
        {
            isMouseHover = visible;
            if (!IsTimerHoverChecking)
            {
                hoverEventTimer.Interval = TimerHoverDelay;
                hoverEventTimer.Start();
                IsTimerHoverChecking = true;
            }
        }

        private void setBorderOnHover(bool visible)
        {
            if (visible)
            {
                roundedPanel1.BorderColor = Color.MediumSlateBlue;
                roundedPanel1.BorderSize = 2;
            }
            else
            {
                roundedPanel1.BorderColor = Color.White;
                roundedPanel1.BorderSize = 0;
            }
        }

        private void onClick(object? sender, EventArgs e)
        {
            if (IsTimerClickChecking)
            {
                return;
            }
            IsTimerClickChecking = true;
            clickEventTimer.Start();
            OnClick?.Invoke();
        }

        private void OnCardEnter(object? sender, EventArgs e)
        {
            onHover(true);
        }

        private void OnCardLeave(object? sender, EventArgs e)
        {
            onHover(false);
        }

        private void AddMouseHandlers(Control control)
        {
            control.Click += onClick;
            control.MouseEnter += OnCardEnter;
            control.MouseLeave += OnCardLeave;

            foreach (Control childControl in control.Controls)
            {
                AddMouseHandlers(childControl);
            }
        }

        private void AddHandCursor(Control control)
        {
            control.Cursor = Cursors.Hand;

            foreach (Control childControl in control.Controls)
            {
                AddMouseHandlers(childControl);
            }
        }

        private void RemoveControlEvents(Control control)
        {
            control.Click -= onClick;
            control.MouseEnter -= OnCardEnter;
            control.MouseLeave -= OnCardLeave;

            foreach (Control childControl in control.Controls)
            {
                RemoveControlEvents(childControl);
            }
        }

        private static Image loaderImage = Properties.Resources.google_loader;

        private void OnControlVisible()
        {
            if (isMinimizedMode)
            {
                return;
            }

            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            ImageHandler.LoadImageToPictureBox(
                $"{image_path.Default.FilmPreviewFolder}{Film.PhotoName}",
                pictureBoxImage,
                Properties.Resources.image_error);
        }

        public void MinimizeMode(bool enabled)
        {
            if (enabled)
            {
                clearControlMemory();
            }
            else
            {
                enableStandardState();
            }
        }

        public void UpdateMinimizeMode()
        {
            // получаем границы родительского контрола
            Rectangle parentBounds = this.Parent.Bounds;

            // получаем границы контрола
            Rectangle controlBounds = this.Bounds;

            // проверяем, пересекаются ли границы контрола и родительского контрола
            bool isVisible = parentBounds.IntersectsWith(controlBounds);

            if (isVisible)
            {
                IsMinimizedMode = false;
            }
            else
            {
                IsMinimizedMode = true;
            }
        }

        public void clearControlMemory()
        {
            isMinimizedMode = true;
            pictureBoxImage.Image = loaderImage;
            pictureBoxImage.SizeMode = PictureBoxSizeMode.CenterImage;
            ratingControl1.Hide();
        }

        public void enableStandardState()
        {
            isMinimizedMode = false;
            OnControlVisible();
            ratingControl1.Show();
        }

        private void FilmPreviewCard_VisibleChanged(object sender, EventArgs e)
        {
            if (((Control)sender).Visible)
            {
                // Если элемент управления стал видимым
                OnControlVisible();
            }
            else
            {
                // Если элемент управления стал невидимым
                // pictureBoxFilmImage.Image.Dispose();
            }
        }

        private int GetFilmScore()
        {
            IEnumerable<Review> reviews = DataBase.ReviewCollection.Where(item => item.FilmId == Film.Id);
            if (reviews.Count() == 0)
                return 0;
            int score = 0;
            foreach (Review review in reviews)
            {
                score += review.Score;
            }
            return score / reviews.Count();
        }

        private void FilmPreviewCard_Load(object sender, EventArgs e)
        {
            ratingControl1.CurrentReting = GetFilmScore();
        }

        //protected new virtual void Dispose(bool disposing)
        //{

        //    if (_disposed)
        //        return;

        //    if (disposing)
        //    {
        //        //dispose managed resources
        //    }
        //    // Free any unmanaged objects here.
        //    hoverEventTimer.Tick -= OnHoverTimerTick;
        //    clickEventTimer.Tick -= OnClickTimerTick;
        //    clickEventTimer.Dispose();
        //    hoverEventTimer.Dispose();
        //    pictureBoxImage.Dispose();
        //    RemoveControlEvents(this);
        //    OnClick = null;
        //    film = null;

        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);

        //    _disposed = true;
        //}

        //public new void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}

        //~FilmPreviewCard()
        //{
        //    Dispose(false);
        //}
    }
}
