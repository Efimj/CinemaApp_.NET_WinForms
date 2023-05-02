using CPProject.DataBaseModel;
using CPProject.DataBaseModel.handlers;
using CPProject.User;
using CPProject.User.types;

namespace CPProject.Controls.Pages
{
    public partial class AccountSettingsPage : UserControl
    {

        private int minAge = 12;
        private string loginValue = "";
        private string passwordValue = "";
        private string passwordRepeteValue = "";
        private DateTime ageValue;

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
        public AccountSettingsPage()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            buttonRegistrationDisable();
            dateTimePickerAge.MaxDate = DateTime.Today.AddYears(-minAge);
            ActiveControl = inputLogin;
            if (AccountHandler.Instance.User != null)
            {
                inputLogin.Texts = AccountHandler.Instance.User.Login;
                ageValue = AccountHandler.Instance.User.BirthdayDate;
                dateTimePickerAge.Value = AccountHandler.Instance.User.BirthdayDate;
            }
        }

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
            if (AccountHandler.Instance.User == null)
                return false;
            if (AccountHandler.Instance.User.Login == loginValue)
            {
                inputLogin.BorderColor = Color.Silver;
                return true;
            }
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

        private void inputLogin__TextChanged(object sender, EventArgs e)
        {
            loginValue = inputLogin.Texts;
            validateAll();
        }

        private void inputPassword__TextChanged(object sender, EventArgs e)
        {
            passwordValue = inputPassword.Texts;
            validateAll();
        }

        private void inputRepeatePassword__TextChanged(object sender, EventArgs e)
        {
            passwordRepeteValue = inputRepeatePassword.Texts;
            validateAll();
        }

        private void dateTimePickerAge_ValueChanged(object sender, EventArgs e)
        {
            ageValue = dateTimePickerAge.Value;
            validateAll();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            DataBaseModel.entities.User? user = AccountHandler.Instance.User;
            if (user == null)
            {
                return;
            }
            switch (user.UserType)
            {
                case DataBaseModel.types.UserType.Customer:
                    ((Customer)user).updateUser(user.Id, loginValue, passwordValue, ageValue);
                    break;
                case DataBaseModel.types.UserType.Admin:
                    ((Admin)user).updateUser(user.Id, loginValue, passwordValue, ageValue);
                    break;
                default:
                    return;
            }
            AccountHandler.Instance.updateUser();
            MessageBox.Show("Account updated", "Account Status");
        }
    }
}
