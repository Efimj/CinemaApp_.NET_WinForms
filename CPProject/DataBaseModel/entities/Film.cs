using CPProject.DataBaseModel.types;

namespace CPProject.DataBaseModel.entities
{
    [Serializable]
    public class Film
    {
        private string id;
        private string title;
        private string description;
        private string photoName;
        private FilmGenre genre;
        private DateTime releaseDate;
        private AgeRating ageRating;

        public string Id { get => id; private set => id = value; }
        public string Title
        {
            get => title;
            set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException();
                }
                title = value;
            }
        }
        public string Description
        {
            get => description;
            set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException();
                }
                description = value;
            }
        }
        public string PhotoName { get => photoName; set => photoName = value; }
        public FilmGenre Genre { get => genre; set => genre = value; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public AgeRating AgeRating { get => ageRating; set => ageRating = value; }

#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public Film(string id, string title, string description, string photoName, FilmGenre genre, DateTime releaseDate, AgeRating ageRating)
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            PhotoName = photoName ?? throw new ArgumentNullException(nameof(photoName));
            Genre = genre;
            ReleaseDate = releaseDate;
            AgeRating = ageRating;
        }
    }
}
