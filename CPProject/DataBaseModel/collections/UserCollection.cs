using CPProject.DataBaseModel.entities;
using CPProject.DataBaseModel.handlers;
using CPProject.DataBaseModel.interfaces;
using CPProject.DataBaseModel.serialization;
using CPProject.User.types;

namespace CPProject.DataBaseModel.collections
{
    [Serializable]
    public class UserCollection : List<entities.User>, IJSONAutoSerializable
    {
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
        public new bool Add(entities.User user)
        {
            int targetIndex = this.FindIndex(item => item.Id == user.Id);
            if (targetIndex != -1)
            {
                return false;
            }

            base.Add(user);

            return SerialiazeToJSON(serialize_config.Default.SerializeUserCollectionPath);
        }

        public bool Update(entities.User user)
        {
            int targetIndex = this.FindIndex(item => item.Id == user.Id);
            if (targetIndex == -1)
            {
                return false;
            }

            this[targetIndex] = user;
            if (this[targetIndex] != user)
            {
                return false;
            }

            return SerialiazeToJSON(serialize_config.Default.SerializeUserCollectionPath);
        }

        public bool Remove(string userId)
        {
            if (base.RemoveAll(item => item.Id == userId) > 0)
            {
                return DeleteBlocked(userId)
                    && DeleteRevirews(userId)
                    && DeleteTickets(userId)
                    && SerialiazeToJSON(serialize_config.Default.SerializeUserCollectionPath);
            }
            return false;
        }

        private bool DeleteBlocked(string userId)
        {
            return DataBase.BlockedUserCollection.RemoveAll(item => item.UserId == userId);
        }

        private bool DeleteRevirews(string userId)
        {
            return DataBase.ReviewCollection.RemoveAll(item => item.UserId == userId);
        }

        private bool DeleteTickets(string userId)
        {
            return DataBase.TicketCollection.RemoveAll(item => item.UserId == userId);
        }

        public bool SerialiazeToJSON(string inFileName)
        {
            if (!DataBase.IsDbSerializabl)
            {
                return true;
            }
            List<entities.User> list = this;
            return Helpers.CreateDirectories(inFileName)
                && Serialization.SerialiazeToJSON(ref list, inFileName);
        }

        public bool DeserializationFromJSON(string fromFileName)
        {
            List<SimpleUser> listSimpleUser = new List<SimpleUser>();
            bool result = Serialization.DeserializationFromJSON(ref listSimpleUser, fromFileName);
            if (result)
            {
                base.Clear();
                List<entities.User> listUser = new List<entities.User>();
                foreach (SimpleUser user in listSimpleUser)
                {
                    entities.User currentUser = user;
                    if (user.UserType == types.UserType.Admin)
                    {
                        currentUser = new Admin(user.Id, user.Login, user.Password, user.BirthdayDate, user.UserType);
                    }
                    if (user.UserType == types.UserType.Customer)
                    {
                        currentUser = new Customer(user.Id, user.Login, user.Password, user.BirthdayDate, user.UserType);
                    }
                    listUser.Add(currentUser);
                }
                base.AddRange(listUser);
                return true;
            }
            return false;
        }

        private new void AddRange(IEnumerable<entities.User> collection) { throw new Exception(); }
        private new void Insert(int index, entities.User item) { throw new Exception(); }
        private new void InsertRange(int index, IEnumerable<entities.User> collection) { throw new Exception(); }
        private new bool Remove(entities.User item) { throw new Exception(); }
        private new int RemoveAll(Predicate<entities.User> match) { throw new Exception(); }
    }
}
