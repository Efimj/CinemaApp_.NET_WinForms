using CPProject.DataBaseModel.entities;
using CPProject.DataBaseModel.handlers;
using CPProject.DataBaseModel.interfaces;
using CPProject.DataBaseModel.serialization;

namespace CPProject.DataBaseModel.collections
{
    [Serializable]
    public class TicketCollection : List<Ticket>, IJSONAutoSerializable
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
        public new bool Add(Ticket ticket)
        {
            int targetIndex = this.FindIndex(item => item.Id == ticket.Id);
            if (targetIndex != -1)
            {
                return false;
            }

            if (!CheckUserAndSessionExistence(ticket.UserId, ticket.SessionId))
            {
                return false;
            }

            if (!SeatNotOccupied(ticket.SessionId, ticket.Place))
            {
                return false;
            }

            base.Add(ticket);

            return SerialiazeToJSON(serialize_config.Default.SerializeTicketCollectionPath);
        }

        public bool Update(Ticket ticket)
        {
            int targetIndex = this.FindIndex(item => item.Id == ticket.Id);
            if (targetIndex == -1)
            {
                return false;
            }

            if (!CheckUserAndSessionExistence(ticket.UserId, ticket.SessionId))
            {
                return false;
            }

            this[targetIndex] = ticket;
            if (this[targetIndex] != ticket)
            {
                return false;
            }

            return SerialiazeToJSON(serialize_config.Default.SerializeTicketCollectionPath);
        }
        private bool CheckUserAndSessionExistence(string userId, string sessionId)
        {
            return DataBase.UserCollection.Any(item => item.Id == userId)
                   && DataBase.SessionCollection.Any(item => item.Id == sessionId);
        }
        private bool SeatNotOccupied(string sessionId, int place)
        {
            Session? session = DataBase.SessionCollection.Find(item => item.Id == sessionId && place >= 1);
            if (session == null)
            {
                return false;
            }
            if (session.TicketCount < place)
            {
                return false;
            }
            return !DataBase.TicketCollection.Any(item => item.SessionId == sessionId && item.Place == place);
        }

        public bool Remove(string ticketId)
        {
            if (base.RemoveAll(item => item.Id == ticketId) > 0)
            {
                return SerialiazeToJSON(serialize_config.Default.SerializeTicketCollectionPath);
            }
            return false;
        }
        public bool RemoveAll(Predicate<Ticket> match, bool serialize = true)
        {
            int count = base.RemoveAll(match);
            if (count > 0)
            {
                return serialize ? SerialiazeToJSON(serialize_config.Default.SerializeTicketCollectionPath) : true;
            }
            return false;
        }

        public bool SerialiazeToJSON(string inFileName)
        {
            if (!DataBase.IsDbSerializabl)
            {
                return true;
            }
            List<Ticket> list = this;
            return Helpers.CreateDirectories(inFileName)
                && Serialization.SerialiazeToJSON(ref list, inFileName);
        }

        public bool DeserializationFromJSON(string fromFileName)
        {
            List<Ticket> list = new List<Ticket>();
            bool result = Serialization.DeserializationFromJSON(ref list, fromFileName);
            if (result)
            {
                base.Clear();
                base.AddRange(list);
                return true;
            }
            return false;
        }

        private new void AddRange(IEnumerable<Ticket> collection) { throw new Exception(); }
        private new void Insert(int index, Ticket item) { throw new Exception(); }
        private new void InsertRange(int index, IEnumerable<Ticket> collection) { throw new Exception(); }
        private new bool Remove(Ticket item) { throw new Exception(); }
        private new bool RemoveAll(Predicate<Ticket> match) { throw new Exception(); }
    }
}
