namespace CPProject.DataBaseModel.entities
{
    [Serializable]
    public class Session
    {
        private string id;
        private string filmId;
        private string address;
        private DateTime date;
        private int ticketCount;
        private double defaultTicketPrice;

        public string Id { get => id; set => id = value; }
        public string FilmId
        {
            get => filmId; set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentOutOfRangeException();
                }
                filmId = value;
            }
        }

        public string Address
        {
            get => address; set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentOutOfRangeException();
                }
                address = value;
            }
        }

        public DateTime Date
        {
            get => date; set
            {
                if (value < DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException();
                }
                date = value;
            }
        }
        public int TicketCount
        {
            get => ticketCount; set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                ticketCount = value;
            }
        }

        public double DefaultTicketPrice
        {
            get => defaultTicketPrice; set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                defaultTicketPrice = value;
            }
        }

        public Session(string id, string filmId, string address, DateTime date, int ticketCount, double defaultTicketPrice)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            FilmId = filmId ?? throw new ArgumentNullException(nameof(filmId));
            Address = address ?? throw new ArgumentNullException(nameof(address));
            this.date = date;
            TicketCount = ticketCount;
            DefaultTicketPrice = defaultTicketPrice;
        }
    }
}
