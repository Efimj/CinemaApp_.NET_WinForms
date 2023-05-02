using CPProject.DataBaseModel;
using CPProject.DataBaseModel.entities;
using CPProject.DataBaseModel.types;
using CPProject.User.types;
using Tests.helpers;

namespace Tests.Users
{
    [TestClass]
    public class AdminTests
    {
        [TestMethod]
        public void Return_Ticket()
        {
            // Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            admin.buyTicket(
               db.SessionCollection.Find(item => item.TicketCount == 1).Id,
               1,
               250);
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            bool result = admin.returnTicket(db.TicketCollection.Find(item => item.UserId == admin.Id).Id);
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Return_Returned_Ticket()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act

            Admin admin = Helpers.getAdmin(db);
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            admin.buyTicket(
               db.SessionCollection.Find(item => item.TicketCount == 1).Id,
               1,
               250);
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            admin.returnTicket(db.TicketCollection.Find(item => item.UserId == admin.Id).Id);
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            bool result = admin.returnTicket(db.TicketCollection.Find(item => item.UserId == admin.Id).Id);
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Return_Not_Existed_Ticket()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
            bool result = admin.returnTicket("2231");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Buy_Second_Ticket()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            bool result = admin.buyTicket(
                db.SessionCollection.Find(item => item.TicketCount == 2).Id,
                2,
                250);
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Buy_Single_Ticket()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            bool result = admin.buyTicket(
                db.SessionCollection.Find(item => item.TicketCount == 1).Id,
                1,
                250);
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Buy_Non_Existent_Place_Ticket()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            bool result = admin.buyTicket(
                db.SessionCollection.Find(item => item.TicketCount == 1).Id,
                5,
                250);
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Buy_Non_Existent_Session_Ticket()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
            bool result = admin.buyTicket(
                "wss",
                1,
                250);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Remove_Ticket()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            admin.buyTicket(
                db.SessionCollection.Find(item => item.TicketCount == 2).Id,
                2,
                250);
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            bool result = admin.returnTicket(
                db.TicketCollection.Find(item => item.UserId == admin.Id).Id);
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Remove_Another_User_Ticket()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Customer customer = Helpers.getCustomer(db);
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            customer.buyTicket(
                db.SessionCollection.Find(item => item.TicketCount == 2).Id,
                2,
                250);
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

            Admin admin = Helpers.getAdmin(db);
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            bool result = admin.returnTicket(
                db.TicketCollection.Find(
                    item => item.UserId == db.UserCollection.Find(
                        item => item.Login == Helpers.customer_login).Id).Id);
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Remove_Not_Existent_Ticket()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
            bool result = admin.returnTicket("");

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Remove_Review()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            bool result = admin.removeReview(
                db.ReviewCollection.Find(item => item.UserId == admin.Id).Id
                );
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Remove_Not_Exists_Review()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
            bool result = admin.removeReview("");

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Remove_Another_User_Review()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            bool result = admin.removeReview(
                db.ReviewCollection.Find(
                    item => item.UserId == db.UserCollection.Find(
                        item => item.Login == Helpers.admin_login).Id).Id
                );
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Update_Review()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            bool result = admin.updateReview(
                db.ReviewCollection.Find(item => item.UserId == admin.Id).Id,
                "ssss",
                1
                );
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Update_Review_Score_Biggest_Then_5()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            bool result = admin.updateReview(
                db.ReviewCollection.Find(item => item.UserId == admin.Id).Id,
                "ssss",
                6
                );
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Update_Review_Score_Less_Then_1()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            bool result = admin.updateReview(
                db.ReviewCollection.Find(item => item.UserId == admin.Id).Id,
                "ssss",
                0
                );
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Update_Not_Existed_Review()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
            bool result = admin.updateReview(
                "",
                "ssss",
                3
                );

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Update_Another_User_Review()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            bool result = admin.updateReview(
                db.ReviewCollection.Find(item => item.UserId == Helpers.getAdmin(db).Id).Id,
                "ssss",
                3
                );
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Make_Review_Again_For_One_Film()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
            bool result = admin.makeReview(
                db.FilmCollection[0].Id,
                "ssss",
                3
                );

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Make_Review_For_Not_Existed_Film()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
            bool result = admin.makeReview(
                "sw",
                "ssss",
                3
                );

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Make_Review()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
            bool result = admin.makeReview(
                db.FilmCollection[1].Id,
                "ssss",
                1
                );

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Check_If_There_Was_Session()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
            bool result = admin.checkIfThereWasSession(db.FilmCollection[1].Id);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Check_If_No_There_Was_Session()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
            bool result = admin.checkIfThereWasSession(db.FilmCollection[0].Id);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Create_Film()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
            Film? result = admin.createFilm(
                "tit",
                "desc",
                "photo",
                FilmGenre.Comedy,
                DateTime.Now.AddDays(1),
                AgeRating.R
                );

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Create_Film_When_No_Name()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
            Film? result = admin.createFilm(
                "",
                "desc",
                "photo",
                FilmGenre.Comedy,
                DateTime.Now.AddDays(1),
                AgeRating.R
                );

            // Assert
            Assert.IsNull(result);
        }
        [TestMethod]
        public void Create_Film_When_No_Description()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
            Film? result = admin.createFilm(
                "Title",
                "",
                "photo",
                FilmGenre.Comedy,
                DateTime.Now.AddDays(1),
                AgeRating.R
                );

            // Assert
            Assert.IsNull(result);
        }
        [TestMethod]
        public void Update_Film_When_No_Description()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
            Film? result = admin.updateFilm(
                db.FilmCollection[0].Id,
                "title",
                "",
                "sdwd",
                FilmGenre.Comedy,
                DateTime.Now.AddDays(1),
                AgeRating.R
                );

            // Assert
            Assert.IsNull(result);
        }
        [TestMethod]
        public void Update_Film_When_No_Title()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
            Film? result = admin.updateFilm(
                db.FilmCollection[0].Id,
                "",
                "dwd",
                "sdwd",
                FilmGenre.Comedy,
                DateTime.Now.AddDays(1),
                AgeRating.R
                );

            // Assert
            Assert.IsNull(result);
        }
        [TestMethod]
        public void Update_Film_When_No_Film_Existed()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
            Film? result = admin.updateFilm(
                "d",
                "sdw",
                "dwd",
                "sdwd",
                FilmGenre.Comedy,
                DateTime.Now.AddDays(1),
                AgeRating.R
                );

            // Assert
            Assert.IsNull(result);
        }
        [TestMethod]
        public void Block_User()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
            bool result = admin.blockUser(
                db.UserCollection[1].Id,
                BlockDurationType.Infinite,
                BlockReasonType.Spamming,
                DateTime.Now
                );

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Block_Not_Existed_User()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
            bool result = admin.blockUser(
                "ss",
                BlockDurationType.Infinite,
                BlockReasonType.Spamming,
                DateTime.Now
                );

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Block_Blocked_User()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
            bool result = admin.blockUser(
                db.UserCollection[2].Id,
                BlockDurationType.Infinite,
                BlockReasonType.Spamming,
                DateTime.Now
                );

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Unblock_Blocked_User()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
            bool result = admin.unblockUser(
                db.UserCollection[2].Id
                );

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Unblock_User_When_No_Block()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
            bool result = admin.unblockUser(
                db.UserCollection[1].Id
                );

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Unblock_no_existed_user()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
            bool result = admin.unblockUser(
                "s"
                );

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Delete_user_review_when_no_existed()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
            bool result = admin.deleteUserReview(
                "s"
                );

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Delete_user_review()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
            bool result = admin.deleteUserReview(
                db.ReviewCollection[0].Id
                );

            // Assert
            Assert.IsTrue(result);
        }
    }
}
