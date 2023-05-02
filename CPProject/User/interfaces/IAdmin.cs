using CPProject.DataBaseModel.entities;
using CPProject.DataBaseModel.types;

namespace CPProject.User.interfaces
{
    public interface IAdmin
    {
        public Film? createFilm(string title, string description, string photoName, FilmGenre genre, DateTime releaseDate, AgeRating ageRating);
        public Film? updateFilm(string filmId, string title, string description, string photoName, FilmGenre genre, DateTime releaseDate, AgeRating ageRating);
        public bool blockUser(string userId, BlockDurationType blockDuration, BlockReasonType blockReason, DateTime appointmentDate);
        public bool unblockUser(string userId);
        public bool deleteUserReview(string reviewId);
        public bool createSession(string filmId, string address, DateTime date, int ticketCount, double defaultTicketPrice);
        public bool updateSession(string sessionId, string filmId, string address, DateTime date, int ticketCount, double defaultTicketPrice);
        public bool deleteSession(string sessionId);
    }
}
