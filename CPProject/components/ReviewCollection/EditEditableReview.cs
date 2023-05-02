using CPProject.DataBaseModel.entities;

namespace CPProject.components.EditableReviewCollection
{
    public partial class EditEditableReview : UserControl
    {
        private string? userName;

        public Func<int, string, Review?>? SaveReview { get; set; }
        public Action? EditCancel { get; set; }
        public string? UserName { get => userName; set { userName = value; OnChangeUserName(); } }
        public Review? Review { get; set; }
        public EditEditableReview(Func<int, string, Review?>? saveReview = null, Action? editCancel = null, string? userName = null, Review? review = null)
        {
            InitializeComponent();
            SaveReview = saveReview;
            EditCancel = editCancel;
            UserName = userName;
            Review = review;
            labelUserName.Text = UserName;
            textBoxDescription.Text = Review?.Description;
            ratingControl1.CurrentReting = Review?.Score;
        }

        private void OnChangeUserName()
        {
            labelUserName.Text = UserName ?? "UserName";
        }

        private void ResizeDescriptionTextbox()
        {
            this.SuspendLayout();

            // amount of padding to add
            const int padding = 3;
            // get number of lines (first line is 0, so add 1)
            int numLines = this.textBoxDescription.GetLineFromCharIndex(this.textBoxDescription.TextLength) + 1;
            // get border thickness
            int border = this.textBoxDescription.Height - this.textBoxDescription.ClientSize.Height;
            // set height (height of one line * number of lines + spacing)
            this.textBoxDescription.Height = (this.textBoxDescription.Font.Height * numLines) + padding + border;

            this.ResumeLayout();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            if (ratingControl1.CurrentReting == null || ratingControl1.CurrentReting < 1)
            {
                labelErrorText.Visible = true;
                labelErrorText.Text = "Oops, you forgot to rate(";
                return;
            }
            if (SaveReview?.Invoke(ratingControl1.CurrentReting ?? 1, textBoxDescription.Text) == null)
            {
                labelErrorText.Visible = true;
                labelErrorText.Text = "Oops, something wrong(";
                return;
            }
            else
            {
                labelErrorText.Visible = false;
            }
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            ResizeDescriptionTextbox();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            EditCancel?.Invoke();
        }
    }
}
