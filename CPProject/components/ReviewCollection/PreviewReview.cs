using CPProject.DataBaseModel.entities;

namespace CPProject.components
{
    public partial class PreviewReview : UserControl
    {
        private Review review;
        private DataBaseModel.entities.User user;
        private Action<Review>? deleteReview;
        private Action<DataBaseModel.entities.User>? banUser;

        public Review Review { get => review; set => review = value; }
        public DataBaseModel.entities.User User { get => user; set => user = value; }
        public Action<Review>? DeleteReview { get => deleteReview; set { deleteReview = value; OnChangeActions(); } }
        public Action<DataBaseModel.entities.User>? BanUser { get => banUser; set { banUser = value; OnChangeActions(); } }
        public PreviewReview(Review review, DataBaseModel.entities.User user, Action<Review>? deleteReview = null, Action<DataBaseModel.entities.User>? banUser = null)
        {
            InitializeComponent();
            Review = review;
            User = user;
            DeleteReview = deleteReview;
            BanUser = banUser;
        }

        private void OnChangeActions()
        {
            if (DeleteReview == null)
                roundedButtonDeleteReview.Hide();
            else
                roundedButtonDeleteReview.Show();
            if (BanUser == null)
                roundedButtonBanUser.Hide();
            else
                roundedButtonBanUser.Show();
        }

        private void ResizeDescription()
        {
            tableLayoutPanel1.Size = new Size(labelDescription.Width - labelDescription.Padding.Horizontal, labelDescription.Height);
        }

        private void PreviewReview_Load(object sender, EventArgs e)
        {
            labelDescription.Text = Review.Description;
            ratingControlScore.CurrentReting = Review.Score;
            labelUserName.Text = User.Login;
            labelDate.Text = review.ChangeTime.ToString("dd.MM.yyyy HH:mm");
        }

        private void labelDescription_Resize(object sender, EventArgs e)
        {
            ResizeDescription();
        }

        private void roundedButtonBanUser_Click(object sender, EventArgs e)
        {
            BanUser?.Invoke(User);
        }

        private void roundedButtonDeleteReview_Click(object sender, EventArgs e)
        {
            DeleteReview?.Invoke(Review);
        }
    }
}
