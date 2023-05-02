using CPProject.DataBaseModel.entities;
using CPProject.DataBaseModel.handlers;
using CPProject.DataBaseModel.interfaces;
using CPProject.DataBaseModel.serialization;

namespace CPProject.DataBaseModel.collections
{
    [Serializable]
    public class ReviewCollection : List<Review>, IJSONAutoSerializable
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
        public List<Review> SortByDate()
        {
            return this.OrderBy(item => item.ChangeTime).ToList();
        }
        public new bool Add(Review review)
        {
            int targetIndex = this.FindIndex(item => item.Id == review.Id);
            if (targetIndex != -1)
            {
                return false;
            }

            if (!CheckUserAndFilmExistence(review.UserId, review.FilmId))
            {
                return false;
            }

            base.Add(review);

            return SerialiazeToJSON(serialize_config.Default.SerializeReviewCollectionPath);
        }

        public bool Update(Review review)
        {
            int targetIndex = this.FindIndex(item => item.Id == review.Id);
            if (targetIndex == -1)
            {
                return false;
            }

            if (!CheckUserAndFilmExistence(review.UserId, review.FilmId))
            {
                return false;
            }

            this[targetIndex] = review;
            if (this[targetIndex] != review)
            {
                return false;
            }

            return SerialiazeToJSON(serialize_config.Default.SerializeReviewCollectionPath);
        }

        private bool CheckUserAndFilmExistence(string userId, string filmId)
        {
            return DataBase.UserCollection.Any(item => item.Id == userId)
                   && DataBase.FilmCollection.Any(item => item.Id == filmId);
        }

        public bool Remove(string reviewId)
        {
            if (base.RemoveAll(item => item.Id == reviewId) > 0)
            {
                return SerialiazeToJSON(serialize_config.Default.SerializeReviewCollectionPath);
            }
            return false;
        }

        public bool RemoveByUser(string userId)
        {
            if (base.RemoveAll(item => item.UserId == userId) > 0)
            {
                return SerialiazeToJSON(serialize_config.Default.SerializeReviewCollectionPath);
            }
            return false;
        }

        public bool RemoveAll(Predicate<Review> match, bool serialize = true)
        {
            int count = base.RemoveAll(match);
            if (count > 0)
            {
                return serialize ? SerialiazeToJSON(serialize_config.Default.SerializeReviewCollectionPath) : true;
            }
            return false;
        }

        public bool SerialiazeToJSON(string inFileName)
        {
            if (!DataBase.IsDbSerializabl)
            {
                return true;
            }
            List<Review> list = this;
            return Helpers.CreateDirectories(inFileName)
                && Serialization.SerialiazeToJSON(ref list, inFileName);
        }

        public bool DeserializationFromJSON(string fromFileName)
        {
            List<Review> list = new List<Review>();
            bool result = Serialization.DeserializationFromJSON(ref list, fromFileName);
            if (result)
            {
                base.Clear();
                base.AddRange(list);
                return true;
            }
            return false;
        }

        private new void AddRange(IEnumerable<Review> collection) { throw new Exception(); }
        private new void Insert(int index, Review item) { throw new Exception(); }
        private new void InsertRange(int index, IEnumerable<Review> collection) { throw new Exception(); }
        private new bool Remove(Review item) { throw new Exception(); }
        private new int RemoveAll(Predicate<Review> match) { throw new Exception(); }
    }
}
