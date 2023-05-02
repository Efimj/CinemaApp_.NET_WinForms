using CPProject.DataBaseModel.handlers;
using CPProject.DataBaseModel.types;

namespace CPProject.DataBaseModel.entities
{
    [Serializable]
    public abstract class User
    {
        private string id;
        private string login;
        private string password;
        private DateTime birthdayDate;
        private UserType userType;

        public string Id { get => id; private set => id = value; }
        public string Login
        {
            get => login;
            private set
            {
                if (!Helpers.CheckLogin(value))
                {
                    throw new ArgumentOutOfRangeException();
                }
                login = value;
            }
        }
        public string Password
        {
            get => password;
            private set
            {
                if (!Helpers.CheckPassword(value))
                {
                    throw new ArgumentOutOfRangeException();
                }
                password = value;
            }
        }
        public DateTime BirthdayDate
        {
            get => birthdayDate;
            private set
            {
                const int minUserAge = 12;
                if (Helpers.CalculateAge(value) < minUserAge)
                {
                    throw new ArgumentOutOfRangeException();
                }
                birthdayDate = value;
            }
        }
        public UserType UserType { get => userType; private set => userType = value; }

#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public User(string id, string login, string password, DateTime birthdayDate, UserType userType)
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            Login = login ?? throw new ArgumentNullException(nameof(login));
            Password = password ?? throw new ArgumentNullException(nameof(password));
            BirthdayDate = birthdayDate;
            UserType = userType;
        }

        public bool passwordCheck(string password)
        {
            if (password != Password)
            {
                return false;
            }
            return true;
        }

        public bool updateUserData(string login, string password)
        {
            if (!Helpers.CheckLogin(login))
            {
                return false;
            }
            if (!Helpers.CheckPassword(password))
            {
                return false;
            }

            Login = login;
            Password = password;

            return true;
        }
    }
}
