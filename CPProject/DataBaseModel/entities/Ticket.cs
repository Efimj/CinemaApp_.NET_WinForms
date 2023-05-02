using CPProject.DataBaseModel.types;

namespace CPProject.DataBaseModel.entities
{
    [Serializable]
    public class Ticket
    {
        private string id;
        private string userId;
        private string sessionId;
        private double price;
        private int place;
        private DateTime purchaseDate;
        private TicketState state;

        public string Id { get => id; set => id = value; }
        public string UserId
        {
            get => userId; set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException();
                }
                userId = value;
            }
        }
        public string SessionId
        {
            get => sessionId; set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException();
                }
                sessionId = value;
            }
        }
        public double Price
        {
            get => price; set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                price = value;
            }
        }
        public int Place
        {
            get => place;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                place = value;
            }
        }
        public DateTime PurchaseDate
        {
            get => purchaseDate;
            set
            {
                var isFutureDate = value > DateTime.Now;
                if (isFutureDate)
                {
                    throw new ArgumentException();
                }
                purchaseDate = value;

            }
        }
        public TicketState State { get => state; set => state = value; }

#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public Ticket(string id, string userId, string sessionId, double price, int place, DateTime purchaseDate, TicketState state)
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            UserId = userId ?? throw new ArgumentNullException(nameof(userId));
            SessionId = sessionId ?? throw new ArgumentNullException(nameof(sessionId));
            Price = price;
            Place = place;
            PurchaseDate = purchaseDate;
            State = state;
        }
    }
}
