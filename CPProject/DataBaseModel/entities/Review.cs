namespace CPProject.DataBaseModel.entities
{
    [Serializable]
    public class Review
    {
        private string id;
        private string filmId;
        private string userId;
        private string description;
        private int score;
        private DateTime changeTime;

        public string Id { get => id; private set => id = value; }
        public string FilmId { get => filmId; set => filmId = value; }
        public string UserId { get => userId; set => userId = value; }
        public string Description
        {
            get => description; set
            {
                changeTime = DateTime.Now;
                description = value;
            }
        }
        public int Score
        {
            get => score; set
            {
                if (value < 1 || value > 5)
                {
                    throw new ArgumentException();
                }
                changeTime = DateTime.Now;
                score = value;
            }
        }
        public DateTime ChangeTime { get => changeTime; set => changeTime = value; }

#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public Review(string id, string filmId, string userId, string description, int score, DateTime changeTime)
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            FilmId = filmId ?? throw new ArgumentNullException(nameof(filmId));
            UserId = userId ?? throw new ArgumentNullException(nameof(userId));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Score = score;
            ChangeTime = changeTime;
        }
    }
}
