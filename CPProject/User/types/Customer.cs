using CPProject.DataBaseModel;
using CPProject.DataBaseModel.entities;
using CPProject.DataBaseModel.types;
using CPProject.User.helpers;
using CPProject.User.interfaces;

namespace CPProject.User.types
{
    public class Customer : CPProject.DataBaseModel.entities.SimpleUser, ICustomer
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

        public Customer(string id, string login, string password,
            DateTime birthdayDate, UserType userType) :
            base(id, login, password, birthdayDate, userType)
        { }

        public bool updateUser(string userId, string login, string password, DateTime birthdayDate)
        {
            if (AccountHandler.Instance.User == null)
                return false;
            return new CustomerHandlers().updateUser(userId, login, password, birthdayDate, AccountHandler.Instance.User.UserType);
        }

        public List<Ticket> Tickets => DataBase.TicketCollection.FindAll(item => item.UserId == this.Id);

        public List<Review> Reviews => DataBase.ReviewCollection.FindAll(item => item.UserId == this.Id);

        public bool removeReview(string reviewId)
        {
            if (!DataBase.ReviewCollection.Any(item => item.Id == reviewId && item.UserId == base.Id))
            {
                return false;
            }
            return DataBase.ReviewCollection.Remove(reviewId);
        }

        public bool updateReview(string reviewId, string description, int score)
        {
            return new CustomerHandlers().updateReview(base.Id, reviewId, description, score);
        }

        public bool returnTicket(string ticketId)
        {
            return new CustomerHandlers().returnTicket(base.Id, ticketId);
        }

        public bool makeReview(string filmId, string description, int score)
        {
            return new CustomerHandlers().makeReview(base.Id, filmId, description, score);
        }

        public bool buyTicket(string sessionId, int seatNumber, double price)
        {
            return new CustomerHandlers().buyTicket(base.Id, sessionId, seatNumber, price);
        }
        public bool checkIfThereWasSession(string filmId)
        {
            return new CustomerHandlers().checkIfThereWasSession(base.Id, filmId);
        }
    }
}
