using CPProject.DataBaseModel.entities;
using CPProject.DataBaseModel.handlers;
using CPProject.DataBaseModel.interfaces;
using CPProject.DataBaseModel.serialization;

namespace CPProject.DataBaseModel.collections
{
    [Serializable]
    public class SessionCollection : List<Session>, IJSONAutoSerializable
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
        public List<Session> SortByDate()
        {
            return this.OrderBy(item => item.Date).ToList();
        }
        public new bool Add(Session session)
        {
            int targetIndex = this.FindIndex(item => item.Id == session.Id);
            if (targetIndex != -1)
            {
                return false;
            }

            if (!CheckFilmExistence(session.FilmId))
            {
                return false;
            }

            base.Add(session);

            return SerialiazeToJSON(serialize_config.Default.SerializeSessionCollectionPath);
        }

        public bool Update(Session session)
        {
            int targetIndex = this.FindIndex(item => item.Id == session.Id);
            if (targetIndex == -1)
            {
                return false;
            }

            if (!CheckFilmExistence(session.FilmId))
            {
                return false;
            }

            this[targetIndex] = session;
            if (this[targetIndex] != session)
            {
                return false;
            }

            return SerialiazeToJSON(serialize_config.Default.SerializeSessionCollectionPath);
        }

        public bool Remove(string sessionId, bool serialize = true)
        {
            if (!DeleteTickets(sessionId))
            {
                return false;
            }
            if (base.RemoveAll(item => item.Id == sessionId) > 0)
            {

                return serialize ? SerialiazeToJSON(serialize_config.Default.SerializeSessionCollectionPath) : true;
            }
            return false;
        }

        public bool RemoveAll(Predicate<Session> match, bool serialize = true)
        {
            int delitedCount = 0;
            for (int i = 0; i < this.Count; i++)
            {
                if (match(this[i]))
                {
                    DeleteTickets(this[i].Id, false);
                    this.RemoveAt(i);
                    delitedCount++;
                    i--;
                }
            }

            if (delitedCount > 0 && serialize)
            {
                return SerializeTicketsCollection()
                    && SerialiazeToJSON(serialize_config.Default.SerializeSessionCollectionPath);
            }

            return false;
        }

        private bool CheckFilmExistence(string filmId)
        {
            return DataBase.FilmCollection.Any(item => item.Id == filmId);
        }

        private bool DeleteTickets(string sessionId, bool serialize = true)
        {
            return DataBase.TicketCollection.RemoveAll(item => item.Id == sessionId, serialize);
        }

        private bool SerializeTicketsCollection()
        {
            return DataBase.TicketCollection.SerialiazeToJSON(serialize_config.Default.SerializeTicketCollectionPath);
        }

        public bool SerialiazeToJSON(string inFileName)
        {
            if (!DataBase.IsDbSerializabl)
            {
                return true;
            }
            List<Session> list = this;
            return Helpers.CreateDirectories(inFileName)
                && Serialization.SerialiazeToJSON(ref list, inFileName);
        }

        public bool DeserializationFromJSON(string fromFileName)
        {
            List<Session> list = new List<Session>();
            bool result = Serialization.DeserializationFromJSON(ref list, fromFileName);
            if (result)
            {
                base.Clear();
                base.AddRange(list);
                return true;
            }
            return false;
        }

        private new void AddRange(IEnumerable<Session> collection) { throw new Exception(); }
        private new void Insert(int index, Session item) { throw new Exception(); }
        private new void InsertRange(int index, IEnumerable<Session> collection) { throw new Exception(); }
        private new bool Remove(Session item) { throw new Exception(); }
        private new int RemoveAll(Predicate<Session> match) { throw new Exception(); }
    }
}
