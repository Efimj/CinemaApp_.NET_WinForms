namespace CPProject.User.interfaces
{
    public interface ICustomer
    {
        public bool updateUser(string userId, string login, string password, DateTime birthdayDate);
        public bool removeReview(string reviewId);
        public bool updateReview(string reviewId, string description, int score);
        public bool returnTicket(string ticketId);
        public bool makeReview(string filmId, string description, int score);
        public bool buyTicket(string sessionId, int seatNumber, double price);
        public bool checkIfThereWasSession(string filmId);
    }
}
