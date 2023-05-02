using CPProject.DataBaseModel;
using CPProject.DataBaseModel.entities;
using CPProject.DataBaseModel.types;
using CPProject.User.types;
using MongoDB.Bson;
using System.Diagnostics;

namespace CPProject.User.helpers
{
    public class CustomerHandlers
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

        public bool updateUser(string userId, string login, string password, DateTime birthdayDate, UserType userType)
        {
            DataBaseModel.entities.User user;
            try
            {
                switch (userType)
                {
                    case UserType.Customer:
                        user = new Customer(userId, login, password, birthdayDate, userType);
                        break;
                    case UserType.Admin:
                        user = new Admin(userId, login, password, birthdayDate, userType);
                        break;
                    default: return false;
                }
                return DataBase.UserCollection.Update(user);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return false;
        }

        public bool updateReview(string userId, string reviewId, string description, int score)
        {
            Debug.WriteLine(DataBase.ReviewCollection.Find(item => item.Id == reviewId));
            Review? review = DataBase.ReviewCollection.Find(item => item.UserId == userId && item.Id == reviewId);
            if (review == null)
            {
                return false;
            }
            try
            {
                review.Description = description;
                review.Score = score;
                return DataBase.ReviewCollection.Update(review);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return false;
        }

        public bool returnTicket(string userId, string ticketId)
        {
            Ticket? ticket = DataBase.TicketCollection.Find(item => item.Id == ticketId && userId == item.UserId);
            if (ticket == null)
            {
                return false;
            }
            try
            {
                if (ticket.State != TicketState.Paid)
                {
                    return false;
                }
                ticket.State = TicketState.Returned;
                return DataBase.TicketCollection.Update(ticket);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return false;
        }
        public bool checkIfThereWasSession(string userId, string filmId)
        {
            try
            {
                var sessions = DataBase.SessionCollection.Where(s => s.FilmId == filmId);
                var userTickets = DataBase.TicketCollection.Where(t => t.UserId == userId && sessions.Any(s => s.Id == t.SessionId));
                if (!userTickets.Any())
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return false;
        }
        public bool makeReview(string userId, string filmId, string description, int score)
        {
            try
            {
                if (!checkIfThereWasSession(userId, filmId))
                {
                    return false;
                }
                string newObjectId = ObjectId.GenerateNewId().ToString();
                Review review = new Review(newObjectId, filmId, userId, description, score, DateTime.Now);
                return DataBase.ReviewCollection.Add(review);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return false;
        }
        public bool buyTicket(string userId, string sessionId, int seatNumber, double price)
        {
            try
            {
                string newObjectId = ObjectId.GenerateNewId().ToString();
                Ticket ticket = new Ticket(newObjectId, userId, sessionId, price, seatNumber, DateTime.Now, TicketState.Paid);
                return DataBase.TicketCollection.Add(ticket);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return false;
        }
    }
}
