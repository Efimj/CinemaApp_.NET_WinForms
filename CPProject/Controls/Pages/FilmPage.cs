using CPProject.components;
using CPProject.Controls.ControlHandlers;
using CPProject.DataBaseModel;
using CPProject.DataBaseModel.entities;
using CPProject.DataBaseModel.types;
using CPProject.imageHandler;
using CPProject.User;
using System.Diagnostics;

namespace CPProject.Controls.Pages
{
    public partial class FilmPage : UserControl
    {
        private Film film;
        private static CinemaDataBase? DBInstance = null;
        private Film Film { get => film; set { film = value; setFilmOnPageDescriptions(Film); } }
        public Action<Film>? OnUpdateFilm { get; set; }
        private ElementListScrollEnd pageScrollEnd;
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
        public FilmPage(Film film, Action<Film>? onUpdateFilm)
        {
            InitializeComponent();
            OnUpdateFilm = onUpdateFilm;
            Film = film;
            if (this.Visible) { OnControlVisible(); }
            ByTicketButtonInitialize();
            EditFilmButtonSetEnabled();
        }

        private IEnumerable<Session> GetFutureSessionsForFilm(Film film)
        {
            try
            {
                return DataBase.SessionCollection
                                     .Where(item => item.FilmId == film.Id && item.Date > DateTime.Now)
                                     .OrderBy(item => item.Date).Where(item => GetAvalibleTickets(item).Count > 0);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        private List<int> GetAvalibleTickets(Session session)
        {
            List<int> tickets = new List<int>();
            var OrderedTickets = DataBase.TicketCollection.Where(item => item.SessionId == session.Id && item.State != TicketState.Returned);
            for (int i = 1; i <= session.TicketCount; i++)
            {
                if (!OrderedTickets.Any(item => item.Place == i))
                    tickets.Add(i);
            }
            return tickets;
        }

        private void ByTicketButtonInitialize()
        {
            if (AccountHandler.Instance.User == null || GetFutureSessionsForFilm(Film).Count() < 1)
            {
                BuyTicketButtonToolTip();
                SetBuyTicketButtonStyleOnDisabled();
            }
            else
            {
                SetBuyTicketButtonStyleOnEnabled();
            }
        }

        private void EditFilmButtonSetEnabled()
        {
            if (AccountHandler.Instance.User?.UserType == UserType.Admin)
            {
                customRoundedButtonEditFilm.Visible = true;
                customRoundedButtonEditFilm.Enabled = true;
            }
            else
            {
                customRoundedButtonEditFilm.Visible = false;
                customRoundedButtonEditFilm.Enabled = false;
            }
        }

        private void SetBuyTicketButtonStyleOnDisabled()
        {
            customRoundedButtonByTicket.BackColor = Color.White;
            customRoundedButtonByTicket.ForeColor = Color.Black;
            customRoundedButtonByTicket.BorderSize = 1;
            customRoundedButtonByTicket.BorderColor = Color.Gray;
            customRoundedButtonByTicket.Enabled = false;
        }

        private void SetBuyTicketButtonStyleOnEnabled()
        {
            customRoundedButtonByTicket.BackColor = Color.MediumSlateBlue;
            customRoundedButtonByTicket.ForeColor = Color.White;
            customRoundedButtonByTicket.BorderSize = 0;
            customRoundedButtonByTicket.Enabled = true;
        }

        private void BuyTicketButtonToolTip()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.BackColor = Color.White;
            toolTip.SetToolTip(customRoundedButtonByTicket, "Log in please :)");
        }

        private void setFilmOnPageDescriptions(Film film)
        {
            labelTitle.Text = film.Title;
            labelGanre.Text = film.Genre.ToString();
            labelAge.Text = $"{(AgeRating)Enum.GetValues(typeof(AgeRating)).GetValue((int)film.AgeRating)}";
            labelRelease.Text = film.ReleaseDate.ToString("dd MMMM yyyy");
            labelDescription.Text = film.Description;
        }

        private void customRoundedButtonGoBack_Click_1(object sender, EventArgs e)
        {
            goBack();
        }

        private void goBack()
        {
            this.Hide();
            Panel? parentPanel = (Panel?)this.Parent;
            if (parentPanel != null)
            {
                parentPanel.Controls.Remove(this);
                parentPanel.Controls[parentPanel.Controls.Count - 1].Show();
            }
            this.DestroyHandle();
        }

        private void setNewPage(UserControl page)
        {
            this.Hide();
            page.Dock = DockStyle.Fill;
            Panel? parentPanel = (Panel?)this.Parent;
            if (parentPanel != null)
            {
                parentPanel.Controls.Add(page);
            }
        }

        private void OnFilmUpdated(Film film)
        {
            Film = film;
            OnUpdateFilm?.Invoke(film);
        }

        private void customRoundedButtonEditFilm_Click(object sender, EventArgs e)
        {
            setNewPage(new CreateFilmPage(Film, OnFilmUpdated));
        }

        private void FilmPage_VisibleChanged(object sender, EventArgs e)
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

        private void OnControlVisible()
        {
            try
            {
                ImageHandler.LoadImageToPictureBox(
                    $"{image_path.Default.FilmPreviewFolder}{Film.PhotoName}",
                    pictureBoxFilmImage,
                    Properties.Resources.image_error
                    );
            }
            catch (Exception ex)
            {
                pictureBoxFilmImage.Image = null;
            }
        }

        private void WhenTicketCountLessOne()
        {
            MessageBox.Show("Sorry, the tickets have run out.", "Ticket Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void customRoundedButtonByTicket_Click(object sender, EventArgs e)
        {
            if (GetFutureSessionsForFilm(Film).Count() < 1)
            {
                ByTicketButtonInitialize();
                WhenTicketCountLessOne();
                return;
            }
            setNewPage(new FilmTicketBookingPage(Film));
        }

        private void FilmPage_Load(object sender, EventArgs e)
        {
            LoadReviewPanel();
        }

        private void LoadReviewPanel()
        {
            FilmReviewList filmReviewList = new FilmReviewList(Film);
            pageScrollEnd = new ElementListScrollEnd(this, () => filmReviewList.addMoreReviews());

            filmReviewList.Dock = DockStyle.Top;
            panelReviws.Controls.Add(filmReviewList);
        }

        private void HorizontalCenterControl(Control control)
        {
            control.Left = (this.ClientSize.Width - control.Width) / 2;
        }

        private void FilmPage_Resize(object sender, EventArgs e)
        {
            HorizontalCenterControl(panelReviws);
        }
    }
}
