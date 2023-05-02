using CPProject.User;

namespace CPProject.Forms
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            this.TopMost = true;
            labelError.Text = string.Empty;
            ActiveControl = roundedFieldLogin;
        }

        private void roundedSearchField1__TextChanged(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            if (AccountHandler.Instance.logIn(roundedFieldLogin.Texts.Trim(), roundedFieldPassword.Texts.Trim(), checkBoxRemember.Checked))
            {
                this.Close();
            }
            else
            {
                labelError.Text = "Wrong password or login.";
            }
        }
    }
}
