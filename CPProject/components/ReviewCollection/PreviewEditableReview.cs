using CPProject.DataBaseModel.entities;

namespace CPProject.components.ReviewCollection
{
    public partial class PreviewEditableReview : UserControl
    {
        private string? userName;

        public Action? OnClickEdit { get; set; }
        public Action? OnClickDelete { get; set; }
        public Review? Review { get; set; }
        public string? UserName { get => userName; set { userName = value; OnChangeUserName(); } }
        public PreviewEditableReview(Action? onClickEdit = null, Action? onClickDelete = null, Review? review = null, string? userName = "UserName")
        {
            InitializeComponent();
            OnClickEdit = onClickEdit;
            OnClickDelete = onClickDelete;
            Review = review;
            UserName = userName;
            labelUserName.Text = UserName ?? "UserName";
            labelDescription.Text = Review?.Description;
            ratingControl1.CurrentReting = Review?.Score ?? 1;
        }

        private void OnChangeUserName()
        {
            labelUserName.Text = UserName ?? "UserName";
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            OnClickEdit?.Invoke();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            OnClickDelete?.Invoke();
        }

        private void labelDescription_SizeChanged_1(object sender, EventArgs e)
        {
            panel2.Size = new System.Drawing.Size(labelDescription.Width, labelDescription.Height);
        }
    }
}
