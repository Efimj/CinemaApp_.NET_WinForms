using CPProject.DataBaseModel.entities;

namespace CPProject.components.EditableReview
{
    public partial class DefaultEditableReview : UserControl
    {
        private string userName;

        public Func<int, string, Review?>? SaveReview { get; set; }
        public string UserName { get => userName; set { userName = value; OnChangeUserName(); } }
        public DefaultEditableReview(Func<int, string, Review?>? saveReview = null, string? userName = null)
        {
            InitializeComponent();
            SaveReview = saveReview;
            labelErrorText.Visible = false;
            UserName = userName ?? "UserName";
            labelUserName.Text = UserName;
            ResizeDescriptionTextbox();
        }

        private void OnChangeUserName()
        {
            labelUserName.Text = UserName ?? "UserName";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ResizeDescriptionTextbox();
        }

        private void ResizeDescriptionTextbox()
        {
            this.SuspendLayout();

            // amount of padding to add
            const int padding = 3;
            // get number of lines (first line is 0, so add 1)
            int numLines = this.textBox1.GetLineFromCharIndex(this.textBox1.TextLength) + 1;
            // get border thickness
            int border = this.textBox1.Height - this.textBox1.ClientSize.Height;
            // set height (height of one line * number of lines + spacing)
            this.textBox1.Height = (this.textBox1.Font.Height * numLines) + padding + border;

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
            if (SaveReview?.Invoke(ratingControl1.CurrentReting ?? 0, textBox1.Text) == null)
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
    }
}
