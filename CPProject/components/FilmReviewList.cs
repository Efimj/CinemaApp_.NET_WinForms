using CPProject.DataBaseModel;
using CPProject.DataBaseModel.entities;
using CPProject.DataBaseModel.types;
using CPProject.Forms;
using CPProject.User;
using CPProject.User.helpers;
using CPProject.User.types;
using System.ComponentModel;
using System.Reflection;

namespace CPProject.components
{
    public partial class FilmReviewList : UserControl
    {
        private enum ReviewListFilter
        {
            [Description("All reviews")]
            All,

            [Description("Score (descending)")]
            ScoreDescending,

            [Description("Score (ascending)")]
            ScoreAscending,

            [Description("Newest first")]
            Newest,

            [Description("Oldest first")]
            Oldest
        }
        private Film film;
        private static CinemaDataBase? DBInstance = null;
        private Review? userReview;
        private List<Review>? reviews;
        private int countReviewLoad = 3;

        private Review? UserReview { get => userReview; set { userReview = value; OnUserReviewChange(); } }
        public Film Film { get => film; set => film = value; }
        private List<Review>? Reviews { get => reviews; set => reviews = value; }
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
        public FilmReviewList(Film film)
        {
            InitializeComponent();
            Film = film;
        }

        private void InitializeComboBoxFilterReview()
        {
            foreach (ReviewListFilter value in Enum.GetValues(typeof(ReviewListFilter)))
            {
                var field = value.GetType().GetField(value.ToString());
                var descriptionAttribute = field.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;
                var description = descriptionAttribute?.Description ?? value.ToString();
                comboBoxFilterReview.Items.Add(new { description, Value = value });
            }

            comboBoxFilterReview.DisplayMember = "Description";
            comboBoxFilterReview.SelectedIndex = 0;
        }

        private Review? SetUserReview()
        {
            if (AccountHandler.Instance.User != null)
                UserReview = DataBase.ReviewCollection.Find(item => item.UserId == AccountHandler.Instance.User.Id && item.FilmId == Film.Id);
            else
                UserReview = null;
            return UserReview;
        }

        private void InitializeUserReview()
        {
            if (AccountHandler.Instance.User != null)
                customerReview.UserName = AccountHandler.Instance.User.Login;
            customerReview.DeleteReview += deleteUserReview;
            customerReview.SaveReview += saveUserReview;
        }

        private void OnUserReviewChange()
        {
            if (AccountHandler.Instance.User == null)
            {
                customerReview.Review = null;
                customerReview.Hide();
                return;
            }
            if (UserReview == null)
            {
                customerReview.Review = null;

            }
            else
            {
                customerReview.Show();
                customerReview.Review = UserReview;
                return;
            }
            if (!new CustomerHandlers().checkIfThereWasSession(AccountHandler.Instance.User.Id, Film.Id))
            {
                customerReview.Hide();
            }
        }

        private bool deleteUserReview()
        {
            DialogResult result = MessageBox.Show(
                "Delete review?",
                "Deleting a review",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result != DialogResult.Yes)
                return false;
            if (AccountHandler.Instance.User == null || UserReview == null)
                return false;
            bool resultRemoving;
            switch (AccountHandler.Instance.User.UserType)
            {
                case DataBaseModel.types.UserType.Customer:
                    resultRemoving = ((Customer)AccountHandler.Instance.User).removeReview(UserReview.Id);
                    break;
                case DataBaseModel.types.UserType.Admin:
                    resultRemoving = ((Admin)AccountHandler.Instance.User).removeReview(UserReview.Id);
                    break;
                default: return false;
            }
            SetUserReview();
            return resultRemoving;
        }

        private Review? saveUserReview(int score, string description)
        {
            if (AccountHandler.Instance.User == null)
                return null;
            switch (AccountHandler.Instance.User.UserType)
            {
                case UserType.Customer:
                    if (UserReview == null)
                        ((Customer)AccountHandler.Instance.User).makeReview(Film.Id, description, score);
                    else
                        ((Customer)AccountHandler.Instance.User).updateReview(UserReview.Id, description, score);
                    break;
                case UserType.Admin:
                    if (UserReview == null)
                        ((Admin)AccountHandler.Instance.User).makeReview(Film.Id, description, score);
                    else
                        ((Admin)AccountHandler.Instance.User).updateReview(UserReview.Id, description, score);
                    break;
            }
            return SetUserReview();
        }

        public void addMoreReviews()
        {
            IEnumerable<Review>? nextReviewCollection = null;
            nextReviewCollection = GetMoreReviews(nextReviewCollection);
            if (nextReviewCollection == null)
                return;
            if (Reviews == null)
            {
                Reviews = new List<Review>();
            }

            List<PreviewReview> previewReviews = new List<PreviewReview>();
            foreach (var reviewItem in nextReviewCollection)
            {
                DataBaseModel.entities.User? user = DataBase.UserCollection.Find(item => item.Id == reviewItem.UserId);
                BlockedUser? blockedUser = DataBase.BlockedUserCollection.Find(item => item.UserId == reviewItem.UserId);
                if (user == null || blockedUser != null)
                {
                    Reviews.Add(reviewItem);
                    continue;
                }
                PreviewReview previewReview;
                if (AccountHandler.Instance.User != null && AccountHandler.Instance.User.UserType == UserType.Admin)
                    previewReview = new PreviewReview(reviewItem, user, DeleteReview, BanReview);
                else
                    previewReview = new PreviewReview(reviewItem, user);
                previewReview.Padding = new Padding(0, 0, 0, 10);
                previewReview.MinimumSize = new Size(flowLayoutPanelReviews.MinimumSize.Width, 0);
                previewReviews.Add(previewReview);
                Reviews.Add(reviewItem);
            }

            foreach (PreviewReview previewReview in previewReviews)
            {
                flowLayoutPanelReviews.Controls.Add(previewReview);
            }
        }

        private void DeleteReview(Review review)
        {
            if (AccountHandler.Instance.User == null || AccountHandler.Instance.User.UserType != UserType.Admin)
                return;
            DataBaseModel.entities.User? user = DataBase.UserCollection.Find(item => item.Id == review.UserId);
            string userName = user == null ? "" : user.Login;
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete this review?\n\nLogin: {userName}\nDescription: \"{review.Description}\"",
                "Deleting a review",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;
            if (!((Admin)AccountHandler.Instance.User).deleteUserReview(review.Id))
                return;
            ReviewRemoveFromFlowLayoutPanel(review);
        }

        private void ReviewRemoveFromFlowLayoutPanel(Review review)
        {
            //if (Reviews != null)
            //    Reviews.Remove(review);
            for (int i = 0; i < flowLayoutPanelReviews.Controls.Count; i++)
            {
                if (((PreviewReview)flowLayoutPanelReviews.Controls[i]).Review.Id == review.Id)
                {
                    flowLayoutPanelReviews.Controls.Remove(flowLayoutPanelReviews.Controls[i]);
                    i--;
                }
            }
        }

        private void ReviewRemoveFromFlowLayoutPanel(DataBaseModel.entities.User user)
        {
            //if (Reviews != null)
            //    Reviews.RemoveAll(item => item.UserId == user.Id);
            for (int i = 0; i < flowLayoutPanelReviews.Controls.Count; i++)
            {
                if (((PreviewReview)flowLayoutPanelReviews.Controls[i]).User.Id == user.Id)
                {
                    flowLayoutPanelReviews.Controls.Remove(flowLayoutPanelReviews.Controls[i]);

                    i--;
                }
            }
        }

        private void BanReview(DataBaseModel.entities.User user)
        {
            if (AccountHandler.Instance.User == null || AccountHandler.Instance.User.UserType != UserType.Admin)
                return;
            DialogUserBan dialogUserBan = new DialogUserBan();
            dialogUserBan.User = user;
            DialogResult dialogResult = dialogUserBan.ShowDialog();
            if (dialogResult != DialogResult.Yes)
                return;
            if (((Admin)AccountHandler.Instance.User).blockUser(
                user.Id,
                dialogUserBan.BlockDuration,
                dialogUserBan.BlockReason,
                dialogUserBan.AppointmentDate
                ))
            {
                ReviewRemoveFromFlowLayoutPanel(user);
            }
        }

        private IEnumerable<Review>? GetMoreReviews(IEnumerable<Review>? nextReviewCollection)
        {
            int countReviews = Reviews == null ? 0 : Reviews.Count;
            string userId = AccountHandler.Instance.User == null ? "" : AccountHandler.Instance.User.Id;
            switch ((ReviewListFilter)comboBoxFilterReview.SelectedIndex)
            {
                case ReviewListFilter.All:
                    nextReviewCollection = DataBase.ReviewCollection
                        .Where(item => item.UserId != userId && item.FilmId == Film.Id)
                        .OrderByDescending(item => item.ChangeTime)
                        .Skip(countReviews)
                        .Take(countReviewLoad);
                    break;
                case ReviewListFilter.Newest:
                    nextReviewCollection = DataBase.ReviewCollection
                        .Where(item => item.UserId != userId && item.FilmId == Film.Id)
                        .OrderByDescending(item => item.ChangeTime)
                        .Skip(countReviews)
                        .Take(countReviewLoad);
                    break;
                case ReviewListFilter.Oldest:
                    nextReviewCollection = DataBase.ReviewCollection
                        .Where(item => item.UserId != userId && item.FilmId == Film.Id)
                        .OrderBy(item => item.ChangeTime)
                        .Skip(countReviews)
                        .Take(countReviewLoad);
                    break;
                case ReviewListFilter.ScoreAscending:
                    nextReviewCollection = DataBase.ReviewCollection
                       .Where(item => item.UserId != userId && item.FilmId == Film.Id)
                       .OrderBy(item => item.Score)
                       .Skip(countReviews)
                       .Take(countReviewLoad);
                    break;
                case ReviewListFilter.ScoreDescending:
                    nextReviewCollection = DataBase.ReviewCollection
                       .Where(item => item.UserId != userId && item.FilmId == Film.Id)
                       .OrderByDescending(item => item.Score)
                       .Skip(countReviews)
                       .Take(countReviewLoad);
                    break;
                default:
                    break;
            }

            return nextReviewCollection;
        }

        //private void SelectLastReview()
        //{
        //    if (panelReviews.Controls.Count > 0)
        //    {
        //        this.SelectNextControl(panelReviews.Controls[0], true, true, true, true);
        //    }
        //}

        private void FilmReviewList_Load(object sender, EventArgs e)
        {
            SetUserReview();
            InitializeUserReview();
            InitializeComboBoxFilterReview();
        }

        private void ClearReviews()
        {
            if (Reviews != null)
                Reviews.Clear();
            flowLayoutPanelReviews.Controls.Clear();
        }

        private void comboBoxFilterReview_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            ClearReviews();
            addMoreReviews();
        }
    }
}
