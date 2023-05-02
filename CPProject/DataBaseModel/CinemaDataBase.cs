using CPProject.DataBaseModel.collections;

namespace CPProject.DataBaseModel
{
    public class CinemaDataBase
    {
        private static readonly CinemaDataBase instance = new CinemaDataBase();
        private CinemaDataBase()
        {
            this.BlockedUserCollection = new BlockedUserCollection();
            this.FilmCollection = new FilmCollection();
            this.ReviewCollection = new ReviewCollection();
            this.TicketCollection = new TicketCollection();
            this.SessionCollection = new SessionCollection();
            this.UserCollection = new UserCollection();
            IsDbSerializabl = true;
        }

        public bool IsDbSerializabl { get; set; }

        public void ClearDB()
        {
            this.BlockedUserCollection = new BlockedUserCollection();
            this.FilmCollection = new FilmCollection();
            this.ReviewCollection = new ReviewCollection();
            this.TicketCollection = new TicketCollection();
            this.SessionCollection = new SessionCollection();
            this.UserCollection = new UserCollection();
        }

        public bool LoadDBData()
        {
            bool result = true;
            if (!BlockedUserCollection.DeserializationFromJSON(serialize_config.Default.SerializeBlockedUserCollectionPath))
            {
                result = false;
            }
            if (!FilmCollection.DeserializationFromJSON(serialize_config.Default.SerializeFilmCollectionPath))
            {
                result = false;
            }
            if (!ReviewCollection.DeserializationFromJSON(serialize_config.Default.SerializeReviewCollectionPath))
            {
                result = false;
            }
            if (!TicketCollection.DeserializationFromJSON(serialize_config.Default.SerializeTicketCollectionPath))
            {
                result = false;
            }
            if (!SessionCollection.DeserializationFromJSON(serialize_config.Default.SerializeSessionCollectionPath))
            {
                result = false;
            }
            if (!UserCollection.DeserializationFromJSON(serialize_config.Default.SerializeUserCollectionPath))
            {
                result = false;
            }

            return result;
        }

        public bool SaveDBData()
        {
            bool result = BlockedUserCollection.SerialiazeToJSON(serialize_config.Default.SerializeBlockedUserCollectionPath)
                & FilmCollection.SerialiazeToJSON(serialize_config.Default.SerializeFilmCollectionPath)
                & ReviewCollection.SerialiazeToJSON(serialize_config.Default.SerializeReviewCollectionPath)
                & TicketCollection.SerialiazeToJSON(serialize_config.Default.SerializeTicketCollectionPath)
                & SessionCollection.SerialiazeToJSON(serialize_config.Default.SerializeSessionCollectionPath)
                & UserCollection.SerialiazeToJSON(serialize_config.Default.SerializeUserCollectionPath);

            return result;
        }

        public static CinemaDataBase Instance => instance;
        public BlockedUserCollection BlockedUserCollection { get; private set; }
        public FilmCollection FilmCollection { get; private set; }
        public ReviewCollection ReviewCollection { get; private set; }
        public TicketCollection TicketCollection { get; private set; }
        public SessionCollection SessionCollection { get; private set; }
        public UserCollection UserCollection { get; private set; }
    }
}
