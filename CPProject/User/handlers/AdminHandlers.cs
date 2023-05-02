using CPProject.DataBaseModel;
using CPProject.DataBaseModel.entities;
using CPProject.DataBaseModel.types;
using MongoDB.Bson;
using System.Diagnostics;

namespace CPProject.User.handlers
{
    public class AdminHandlers
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

        public Film? createFilm(string title, string description, string photoName, FilmGenre genre, DateTime releaseDate, AgeRating ageRating)
        {
            try
            {
                string newObjectId = ObjectId.GenerateNewId().ToString();
                Film film = new Film(newObjectId, title, description, photoName, genre, releaseDate, ageRating);
                if (DataBase.FilmCollection.Add(film))
                {
                    return film;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return null;
        }

        public Film? updateFilm(string filmId, string title, string description, string photoName, FilmGenre genre, DateTime releaseDate, AgeRating ageRating)
        {
            Film? film = DataBase.FilmCollection.Find(item => item.Id == filmId);
            if (film == null)
            {
                return null;
            }
            try
            {
                film.Title = title;
                film.Description = description;
                film.Genre = genre;
                film.PhotoName = photoName;
                film.ReleaseDate = releaseDate;
                film.AgeRating = ageRating;
                if (DataBase.FilmCollection.Update(film))
                {
                    return film;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return null;
        }

        public bool blockUser(string userId, BlockDurationType blockDuration, BlockReasonType blockReason, DateTime appointmentDate)
        {
            try
            {
                if (DataBase.BlockedUserCollection.Any(item => item.UserId == userId))
                {
                    return false;
                }
                string newObjectId = ObjectId.GenerateNewId().ToString();
                BlockedUser blockedUser = new BlockedUser(newObjectId, userId, blockDuration, blockReason, appointmentDate);
                return DataBase.BlockedUserCollection.Add(blockedUser);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return false;
        }

        public bool createSession(string filmId, string address, DateTime date, int ticketCount, double defaultTicketPrice)
        {
            try
            {
                string newObjectId = ObjectId.GenerateNewId().ToString();
                Session session = new Session(newObjectId, filmId, address, date, ticketCount, defaultTicketPrice);
                return DataBase.SessionCollection.Add(session);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return false;
        }

        public bool updateSession(string sessionId, string filmId, string address, DateTime date, int ticketCount, double defaultTicketPrice)
        {
            try
            {
                Session session = new Session(sessionId, filmId, address, date, ticketCount, defaultTicketPrice);
                return DataBase.SessionCollection.Update(session);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return false;
        }
    }
}
