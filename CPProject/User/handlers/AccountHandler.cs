using CPProject.DataBaseModel;
using CPProject.DataBaseModel.entities;
using CPProject.DataBaseModel.handlers;
using CPProject.DataBaseModel.serialization;
using CPProject.DataBaseModel.types;
using CPProject.User.handlers;
using CPProject.User.types;
using MongoDB.Bson;
using System.Diagnostics;

namespace CPProject.User
{
    public class AccountHandler
    {
        private static readonly AccountHandler instance = new AccountHandler();
        public static AccountHandler Instance => instance;
        private AccountHandler() { }
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
        public delegate void CurrentUserChangedDelegate(DataBaseModel.entities.User? newCurrentUser);
        public event CurrentUserChangedDelegate OnUserChange;

        private DataBaseModel.entities.User? user;
        public DataBaseModel.entities.User? User
        {
            get => user;
            private set
            {
                user = value;
                OnUserChange?.Invoke(user);
            }
        }

        public UserType? UserType
        {
            get
            {
                if (User == null)
                {
                    return null;
                }
                else
                {
                    return User.UserType;
                }
            }
        }
        public bool logIn(string login, string password, bool remember)
        {
            DataBaseModel.entities.User? CurrentUser = DataBase.UserCollection.Find(item => item.Login == login && item.Password == password);
            if (CurrentUser == null)
            {
                return false;
            }
            User = CurrentUser;
            if (remember)
            {
                return SaveRememberUser(CurrentUser);
            }
            else
            {
                deleteSavedUser();
            }
            return true;
        }

        public bool updateUser()
        {
            if (User == null)
                return false;
            User = DataBase.UserCollection.Find(item => item.Id == User.Id);
            return true;
        }

        public bool logOut()
        {
            deleteSavedUser();
            User = null;
            return true;
        }

        public bool singIn(string login, string password, DateTime birthdayDate)
        {
            if (DataBase.UserCollection.Find(item => item.Login == login) != null)
            {
                return false;
            }
            try
            {
                string newObjectId = ObjectId.GenerateNewId().ToString();
                DataBaseModel.entities.User user = new SimpleUser(newObjectId, login, password, birthdayDate, DataBaseModel.types.UserType.Customer);
                return DataBase.UserCollection.Add(user);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return false;
        }

        public bool SaveRememberUser(DataBaseModel.entities.User CurrentUser)
        {
            return Helpers.CreateDirectories(user_config.Default.RememberUserPath)
                && Serialization.SerialiazeToJSON(ref CurrentUser, user_config.Default.RememberUserPath);
        }

        public bool loadSavedUser()
        {
            SimpleUser? currentSimpleUser = null;
            Serialization.DeserializationFromJSON(ref currentSimpleUser, user_config.Default.RememberUserPath);
            if (currentSimpleUser == null)
            {
                return false;
            }
            DataBaseModel.entities.User currentUser = currentSimpleUser;
            if (currentUser.UserType == DataBaseModel.types.UserType.Admin)
            {
                currentUser = new Admin(
                    currentSimpleUser.Id,
                    currentSimpleUser.Login,
                    currentSimpleUser.Password,
                    currentSimpleUser.BirthdayDate,
                    currentSimpleUser.UserType
                    );
            }
            if (currentUser.UserType == DataBaseModel.types.UserType.Customer)
            {
                currentUser = new Customer(
                    currentSimpleUser.Id,
                    currentSimpleUser.Login,
                    currentSimpleUser.Password,
                    currentSimpleUser.BirthdayDate,
                    currentSimpleUser.UserType
                    );
            }
            User = currentUser;
            return true;
        }

        public bool deleteSavedUser()
        {
            DataBaseModel.entities.User? CurrentUser = null;
            return Serialization.SerialiazeToJSON(ref CurrentUser, user_config.Default.RememberUserPath);
            //return FileHelpers.DeleteFile(user_config.Default.RememberUserPath);
        }
    }
}
