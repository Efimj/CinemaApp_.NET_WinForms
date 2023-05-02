using CPProject.DataBaseModel;
using CPProject.DataBaseModel.handlers;
using CPProject.User;

namespace CPProject.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            this.TopMost = true;
            labelError.Text = String.Empty;
            buttonRegistrationDisable();
            dateTimePickerAge.MaxDate = DateTime.Today.AddYears(-minAge);
            ActiveControl = inputLogin;
        }

        private static CinemaDataBase? DBInstance = null;
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

        private int minAge = 12;
        private string loginValue = "";
        private string passwordValue = "";
        private string passwordRepeteValue = "";
        private DateTime ageValue;

        private void validateAll()
        {
            if (!loginValidate())
            {
                buttonRegistrationDisable();
                return;
            }
            if (!passwordValidate())
            {
                buttonRegistrationDisable();
                return;
            }
            if (!passwordRepeateValidate())
            {
                buttonRegistrationDisable();
                return;
            }
            if (!ageValidate())
            {
                buttonRegistrationDisable();
                return;
            }
            buttonRegistrationActivate();
        }

        private void buttonRegistrationActivate()
        {
            buttonRegistration.Enabled = true;
            buttonRegistration.BackColor = Color.MediumSlateBlue;
            buttonRegistration.ForeColor = Color.White;
        }

        private void buttonRegistrationDisable()
        {
            buttonRegistration.Enabled = false;
            buttonRegistration.BackColor = Color.White;
            buttonRegistration.ForeColor = Color.Black;
        }

        private bool loginValidate()
        {
            if (!Helpers.CheckLogin(loginValue) || DataBase.UserCollection.Any(item => item.Login == loginValue))
            {
                inputLogin.BorderColor = Color.IndianRed;
                return false;
            }
            inputLogin.BorderColor = Color.Silver;
            return true;
        }

        private bool passwordValidate()
        {
            if (!Helpers.CheckPassword(passwordValue))
            {
                inputPassword.BorderColor = Color.IndianRed;
                return false;
            }
            inputPassword.BorderColor = Color.Silver;
            return true;
        }

        private bool passwordRepeateValidate()
        {
            if (passwordRepeteValue != passwordValue)
            {
                inputRepeatePassword.BorderColor = Color.IndianRed;
                return false;
            }
            inputRepeatePassword.BorderColor = Color.Silver;
            return true;
        }

        private bool ageValidate()
        {
            if (ageValue > DateTime.Today.AddYears(-minAge))
            {
                return false;
            }
            return true;
        }

        private void inputLogin_OnChangeTex(object sender, EventArgs e)
        {
            loginValue = inputLogin.Texts;
            validateAll();
        }

        private void inputPassword_OnChangeTex(object sender, EventArgs e)
        {
            passwordValue = inputPassword.Texts;
            validateAll();
        }

        private void inputRepeatePassword_CustomInputChanged(object sender, EventArgs e)
        {
            passwordRepeteValue = inputRepeatePassword.Texts;
            validateAll();
        }

        private void dateTimePickerAge_ValueChanged(object sender, EventArgs e)
        {
            ageValue = dateTimePickerAge.Value;
            validateAll();
        }

        private void buttonRegistration_Click_1(object sender, EventArgs e)
        {
            if (AccountHandler.Instance.singIn(loginValue, passwordValue, ageValue))
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
