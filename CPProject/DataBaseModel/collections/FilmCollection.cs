using CPProject.DataBaseModel.entities;
using CPProject.DataBaseModel.handlers;
using CPProject.DataBaseModel.interfaces;
using CPProject.DataBaseModel.serialization;

namespace CPProject.DataBaseModel.collections
{
    [Serializable]
    public class FilmCollection : List<Film>, IJSONAutoSerializable
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
        public List<Film> SortByReleaseDate()
        {
            return this.OrderBy(item => item.ReleaseDate).ToList();
        }
        public new bool Add(Film film)
        {
            int targetIndex = this.FindIndex(item => item.Id == film.Id);
            if (targetIndex != -1)
            {
                return false;
            }

            base.Add(film);

            return SerialiazeToJSON(serialize_config.Default.SerializeFilmCollectionPath);
        }

        public bool Update(Film film)
        {
            int targetIndex = this.FindIndex(item => item.Id == film.Id);
            if (targetIndex == -1)
            {
                return false;
            }

            this[targetIndex] = film;
            if (!this[targetIndex].Equals(film))
            {
                return false;
            }

            return SerialiazeToJSON(serialize_config.Default.SerializeFilmCollectionPath);
        }

        public bool Remove(string filmId)
        {
            if (base.RemoveAll(item => item.Id == filmId) > 0)
            {
                return DeleteSessions(filmId)
                    && DeleteReviews(filmId)
                    && SerialiazeToJSON(serialize_config.Default.SerializeFilmCollectionPath);
            }
            return false;
        }

        private bool DeleteSessions(string filmId)
        {
            return DataBase.SessionCollection.RemoveAll(item => item.FilmId == filmId);
        }

        private bool DeleteReviews(string filmId)
        {
            return DataBase.ReviewCollection.RemoveAll(item => item.FilmId == filmId);
        }

        public bool SerialiazeToJSON(string inFileName)
        {
            if (!DataBase.IsDbSerializabl)
            {
                return true;
            }
            List<Film> list = this;
            return Helpers.CreateDirectories(inFileName)
                && Serialization.SerialiazeToJSON(ref list, inFileName);
        }

        public bool DeserializationFromJSON(string fromFileName)
        {
            List<Film> list = new List<Film>();
            bool result = Serialization.DeserializationFromJSON(ref list, fromFileName);
            if (result)
            {
                base.Clear();
                base.AddRange(list);
                return true;
            }
            return false;
        }

        private new void AddRange(IEnumerable<Film> collection) { throw new Exception(); }
        private new void Insert(int index, Film item) { throw new Exception(); }
        private new void InsertRange(int index, IEnumerable<Film> collection) { throw new Exception(); }
        private new bool Remove(Film item) { throw new Exception(); }
        private new int RemoveAll(Predicate<Film> match) { throw new Exception(); }
    }
}
