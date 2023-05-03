using CPProject.DataBaseModel.entities;
using CPProject.DataBaseModel.handlers;
using CPProject.DataBaseModel.interfaces;
using CPProject.DataBaseModel.serialization;

namespace CPProject.DataBaseModel.collections
{
    [Serializable]
    public class BlockedUserCollection : List<BlockedUser>, IJSONAutoSerializable
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
        public List<BlockedUser> SortByDate()
        {
            return this.OrderBy(item => item.AppointmentDate).ToList();
        }
        public new bool Add(BlockedUser blockedUser)
        {
            int targetIndex = this.FindIndex(item => item.Id == blockedUser.Id);
            if (targetIndex != -1)
            {
                return false;
            }

            if (!CheckUserExistence(blockedUser.UserId))
            {
                return false;
            }

            base.Add(blockedUser);

            return SerialiazeToJSON(serialize_config.Default.SerializeBlockedUserCollectionPath);
        }

        public bool Update(BlockedUser blockedUser)
        {
            int targetIndex = this.FindIndex(item => item.Id == blockedUser.Id);
            if (targetIndex == -1)
            {
                return false;
            }

            if (!CheckUserExistence(blockedUser.UserId))
            {
                return false;
            }

            this[targetIndex] = blockedUser;
            if (this[targetIndex] != blockedUser)
            {
                return false;
            }

            return SerialiazeToJSON(serialize_config.Default.SerializeBlockedUserCollectionPath);
        }

        public bool Remove(string blockedId)
        {
            if (base.RemoveAll(item => item.Id == blockedId) > 0)
            {
                return SerialiazeToJSON(serialize_config.Default.SerializeBlockedUserCollectionPath);
            }
            return false;
        }

        public bool RemoveByUser(string blockedUserId)
        {
            if (base.RemoveAll(item => item.UserId == blockedUserId) > 0)
            {
                return SerialiazeToJSON(serialize_config.Default.SerializeBlockedUserCollectionPath);
            }
            return false;
        }

        public bool RemoveAll(Predicate<BlockedUser> match, bool serialize = true)
        {
            int count = base.RemoveAll(match);
            if (count > 0)
            {
                return serialize ? SerialiazeToJSON(serialize_config.Default.SerializeBlockedUserCollectionPath) : true;
            }
            return false;
        }

        private bool CheckUserExistence(string userId)
        {
            return DataBase.UserCollection.Any(item => item.Id == userId);
        }

        public bool SerialiazeToJSON(string inFileName)
        {
            if (!DataBase.IsDbSerializabl)
            {
                return true;
            }
            List<BlockedUser> list = this;
            return Helpers.CreateDirectories(inFileName)
                && Serialization.SerialiazeToJSON(ref list, inFileName);
        }

        public bool DeserializationFromJSON(string fromFileName)
        {
            List<BlockedUser> list = new List<BlockedUser>();
            bool result = Serialization.DeserializationFromJSON(ref list, fromFileName);
            if (result)
            {
                base.Clear();
                base.AddRange(list);
                return true;
            }
            return false;
        }

        private new void AddRange(IEnumerable<BlockedUser> collection) { throw new Exception(); }
        private new void Insert(int index, BlockedUser item) { throw new Exception(); }
        private new void InsertRange(int index, IEnumerable<BlockedUser> collection) { throw new Exception(); }
        private new bool Remove(BlockedUser item) { throw new Exception(); }
        private new int RemoveAll(Predicate<BlockedUser> match) { throw new Exception(); }
    }
}
