using CPProject.DataBaseModel;
using CPProject.DataBaseModel.entities;
using CPProject.DataBaseModel.types;
using CPProject.User.handlers;
using CPProject.User.helpers;
using CPProject.User.interfaces;

namespace CPProject.User.types
{
    public class Admin : CPProject.DataBaseModel.entities.SimpleUser, ICustomer, IAdmin
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

        public Admin(string id, string login, string password,
            DateTime birthdayDate, UserType userType) :
            base(id, login, password, birthdayDate, userType)
        { }

        public List<Ticket> Tickets => DataBase.TicketCollection.FindAll(item => item.UserId == this.Id);
        public List<Review> Reviews => DataBase.ReviewCollection.FindAll(item => item.UserId == this.Id);
        public CPProject.DataBaseModel.entities.User? FindBlockedUser(string userId)
        {
            return DataBase.UserCollection.Find(item => item.Id == userId);
        }

        public bool updateUser(string userId, string login, string password, DateTime birthdayDate)
        {
            if (AccountHandler.Instance.User == null)
                return false;
            return new CustomerHandlers().updateUser(userId, login, password, birthdayDate, AccountHandler.Instance.User.UserType);
        }

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

        public Film? createFilm(string title, string description, string photoName, FilmGenre genre,
            DateTime releaseDate, AgeRating ageRating)
        {
            return new AdminHandlers().createFilm(title, description, photoName, genre,
             releaseDate, ageRating);
        }

        public Film? updateFilm(string filmId, string title, string description, string photoName, FilmGenre genre, DateTime releaseDate, AgeRating ageRating)
        {
            return new AdminHandlers().updateFilm(filmId, title, description, photoName, genre, releaseDate, ageRating);
        }

        public bool blockUser(string userId, BlockDurationType blockDuration, BlockReasonType blockReason, DateTime appointmentDate)
        {
            return new AdminHandlers().blockUser(userId, blockDuration, blockReason, appointmentDate);
        }

        public bool unblockUser(string userId)
        {
            if (!DataBase.BlockedUserCollection.Any(item => item.UserId == userId))
            {
                return false;
            }
            return DataBase.BlockedUserCollection.RemoveByUser(userId);
        }

        public bool deleteUserReview(string reviewId)
        {
            return DataBase.ReviewCollection.Remove(reviewId);
        }

        public bool createSession(string filmId, string address, DateTime date, int ticketCount, double defaultTicketPrice)
        {
            return new AdminHandlers().createSession(filmId, address, date, ticketCount, defaultTicketPrice);
        }

        public bool updateSession(string sessionId, string filmId, string address, DateTime date, int ticketCount, double defaultTicketPrice)
        {
            return new AdminHandlers().updateSession(sessionId, filmId, address, date, ticketCount, defaultTicketPrice);
        }

        public bool deleteSession(string sessionId)
        {
            return DataBase.SessionCollection.Remove(sessionId);
        }

        public bool checkIfThereWasSession(string filmId)
        {
            return new CustomerHandlers().checkIfThereWasSession(base.Id, filmId);
        }
    }
}
