using CPProject.DataBaseModel;
using CPProject.DataBaseModel.entities;
using CPProject.DataBaseModel.types;
using CPProject.User.types;
using MongoDB.Bson;

namespace Tests.helpers
{
    public static class Helpers
    {
        public static string admin_login = "adminLogin1";
        public static string admin_password = "12345qwerty";

        public static string customer_login = "customerLogin";
        public static string customer_password = "54321qwerty";

        public static string customer_login_blocked = "customerLoginBlocked";
        public static string customer_blocked_password = "44423qwerty";

        public static string film1_title = "Title1";
        public static string film2_title = "Title2";
        public static string film3_title = "Title3";

        public static CinemaDataBase initializeCinemaDb()
        {
            CinemaDataBase cinemaDataBase = CinemaDataBase.Instance;

            cinemaDataBase.ClearDB();

            cinemaDataBase.IsDbSerializabl = false;

            User admin = new Admin(ObjectId.GenerateNewId().ToString(), admin_login, admin_password, DateTime.Now.AddYears(-20), UserType.Admin);
            User customer = new Customer(ObjectId.GenerateNewId().ToString(), customer_login, customer_password, DateTime.Now.AddYears(-22), UserType.Customer);
            User customerBlocked = new Customer(ObjectId.GenerateNewId().ToString(), customer_login_blocked, customer_blocked_password, DateTime.Now.AddYears(-15), UserType.Customer);

            cinemaDataBase.UserCollection.Add(admin);
            cinemaDataBase.UserCollection.Add(customer);
            cinemaDataBase.UserCollection.Add(customerBlocked);

            Film film1 = new Film(ObjectId.GenerateNewId().ToString(), film1_title, "Description1", "photo1", FilmGenre.Comedy, DateTime.Now.AddYears(-1), AgeRating.R);
            Film film2 = new Film(ObjectId.GenerateNewId().ToString(), film2_title, "Description2", "photo2", FilmGenre.Adventure, DateTime.Now.AddYears(-11), AgeRating.None);
            Film film3 = new Film(ObjectId.GenerateNewId().ToString(), film3_title, "Description3", "photo3", FilmGenre.Romance, DateTime.Now.AddYears(-4), AgeRating.PG13);

            cinemaDataBase.FilmCollection.Add(film1);
            cinemaDataBase.FilmCollection.Add(film2);
            cinemaDataBase.FilmCollection.Add(film3);

#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            BlockedUser blockedUser = new BlockedUser(
                ObjectId.GenerateNewId().ToString(),
                cinemaDataBase.UserCollection.Find(item => item.Login == customer_login_blocked).Id,
                BlockDurationType.TwoDays,
                BlockReasonType.Spamming,
                DateTime.Now.AddDays(-1));
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

            cinemaDataBase.BlockedUserCollection.Add(blockedUser);

#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            Review review1 = new Review(
                ObjectId.GenerateNewId().ToString(),
                cinemaDataBase.FilmCollection.Find(item => item.Title == film1_title).Id,
                cinemaDataBase.UserCollection.Find(item => item.Login == customer_login).Id,
                "Good",
                4,
                DateTime.Now);
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            Review review2 = new Review(
                ObjectId.GenerateNewId().ToString(),
                cinemaDataBase.FilmCollection.Find(item => item.Title == film2_title).Id,
                cinemaDataBase.UserCollection.Find(item => item.Login == admin_login).Id,
                "bad",
                1,
                DateTime.Now);
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

            cinemaDataBase.ReviewCollection.Add(review1);
            cinemaDataBase.ReviewCollection.Add(review2);

#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            Session session1 = new Session(
                ObjectId.GenerateNewId().ToString(),
                cinemaDataBase.FilmCollection.Find(item => item.Title == film2_title).Id,
                "address_1",
                DateTime.Now.AddDays(5),
                2,
                350
                );
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            Session session2 = new Session(
                ObjectId.GenerateNewId().ToString(),
                cinemaDataBase.FilmCollection.Find(item => item.Title == film1_title).Id,
                "address_2",
                DateTime.Now.AddDays(15),
                1,
                550
                );
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

            cinemaDataBase.SessionCollection.Add(session1);
            cinemaDataBase.SessionCollection.Add(session2);

#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            Ticket ticket1 = new Ticket(
                ObjectId.GenerateNewId().ToString(),
                cinemaDataBase.UserCollection.Find(item => item.Login == customer_login).Id,
                cinemaDataBase.SessionCollection.Find(item => item.Address == "address_1").Id,
                250,
                1,
                DateTime.Now,
                TicketState.Paid
                );
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

            cinemaDataBase.TicketCollection.Add(ticket1);

            return cinemaDataBase;
        }

        public static Admin getAdmin(CinemaDataBase db)
        {
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
#pragma warning disable CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
            return (Admin)db.UserCollection.Find(item => item.Login == admin_login);
#pragma warning restore CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
        }
        public static Customer getCustomer(CinemaDataBase db)
        {
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
#pragma warning disable CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
            return (Customer)db.UserCollection.Find(item => item.Login == customer_login);
#pragma warning restore CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
        }
        public static Customer getBlockedUser(CinemaDataBase db)
        {
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
#pragma warning disable CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
            return (Customer)db.UserCollection.Find(item => item.Login == customer_login_blocked);
#pragma warning restore CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
        }

    }
}
