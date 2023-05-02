using CPProject.DataBaseModel;
using CPProject.User.types;
using Tests.helpers;

namespace Tests.Users
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void Return_Ticket()
        {
            // Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Customer customer = Helpers.getCustomer(db);
#pragma warning disable CS8602 // –азыменование веро€тной пустой ссылки.
            bool result = customer.returnTicket(db.TicketCollection.Find(item => item.UserId == customer.Id).Id);
#pragma warning restore CS8602 // –азыменование веро€тной пустой ссылки.

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Return_Returned_Ticket()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Customer customer = Helpers.getCustomer(db);
#pragma warning disable CS8602 // –азыменование веро€тной пустой ссылки.
            customer.returnTicket(db.TicketCollection.Find(item => item.UserId == customer.Id).Id);
#pragma warning restore CS8602 // –азыменование веро€тной пустой ссылки.
#pragma warning disable CS8602 // –азыменование веро€тной пустой ссылки.
            bool result = customer.returnTicket(db.TicketCollection.Find(item => item.UserId == customer.Id).Id);
#pragma warning restore CS8602 // –азыменование веро€тной пустой ссылки.

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Return_Not_Existed_Ticket()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Customer customer = Helpers.getCustomer(db);
            bool result = customer.returnTicket("2231");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Buy_Second_Ticket()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Customer customer = Helpers.getCustomer(db);
#pragma warning disable CS8602 // –азыменование веро€тной пустой ссылки.
            bool result = customer.buyTicket(
                db.SessionCollection.Find(item => item.TicketCount == 2).Id,
                2,
                250);
#pragma warning restore CS8602 // –азыменование веро€тной пустой ссылки.

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Buy_Single_Ticket()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Customer customer = Helpers.getCustomer(db);
#pragma warning disable CS8602 // –азыменование веро€тной пустой ссылки.
            bool result = customer.buyTicket(
                db.SessionCollection.Find(item => item.TicketCount == 1).Id,
                1,
                250);
#pragma warning restore CS8602 // –азыменование веро€тной пустой ссылки.

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Buy_Non_Existent_Place_Ticket()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Customer customer = Helpers.getCustomer(db);
#pragma warning disable CS8602 // –азыменование веро€тной пустой ссылки.
            bool result = customer.buyTicket(
                db.SessionCollection.Find(item => item.TicketCount == 1).Id,
                5,
                250);
#pragma warning restore CS8602 // –азыменование веро€тной пустой ссылки.

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Buy_Non_Existent_Session_Ticket()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Customer customer = Helpers.getCustomer(db);
            bool result = customer.buyTicket(
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
            Customer customer = Helpers.getCustomer(db);
#pragma warning disable CS8602 // –азыменование веро€тной пустой ссылки.
            bool result = customer.returnTicket(
                db.TicketCollection.Find(item => item.UserId == customer.Id).Id);
#pragma warning restore CS8602 // –азыменование веро€тной пустой ссылки.

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Remove_Another_User_Ticket()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Admin admin = Helpers.getAdmin(db);
#pragma warning disable CS8602 // –азыменование веро€тной пустой ссылки.
            admin.buyTicket(
                db.SessionCollection.Find(item => item.TicketCount == 2).Id,
                2,
                250);
#pragma warning restore CS8602 // –азыменование веро€тной пустой ссылки.

            Customer customer = Helpers.getCustomer(db);
#pragma warning disable CS8602 // –азыменование веро€тной пустой ссылки.
            bool result = customer.returnTicket(
                db.TicketCollection.Find(
                    item => item.UserId == db.UserCollection.Find(
                        item => item.Login == Helpers.admin_login).Id).Id);
#pragma warning restore CS8602 // –азыменование веро€тной пустой ссылки.

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Remove_Not_Existent_Ticket()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Customer customer = Helpers.getCustomer(db);
            bool result = customer.returnTicket("");

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Remove_Review()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Customer customer = Helpers.getCustomer(db);
#pragma warning disable CS8602 // –азыменование веро€тной пустой ссылки.
            bool result = customer.removeReview(
                db.ReviewCollection.Find(item => item.UserId == customer.Id).Id
                );
#pragma warning restore CS8602 // –азыменование веро€тной пустой ссылки.

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Remove_Not_Exists_Review()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Customer customer = Helpers.getCustomer(db);
            bool result = customer.removeReview("");

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Remove_Another_User_Review()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Customer customer = Helpers.getCustomer(db);
#pragma warning disable CS8602 // –азыменование веро€тной пустой ссылки.
            bool result = customer.removeReview(
                db.ReviewCollection.Find(
                    item => item.UserId == db.UserCollection.Find(
                        item => item.Login == Helpers.admin_login).Id).Id
                );
#pragma warning restore CS8602 // –азыменование веро€тной пустой ссылки.

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Update_Review()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Customer customer = Helpers.getCustomer(db);
#pragma warning disable CS8602 // –азыменование веро€тной пустой ссылки.
            bool result = customer.updateReview(
                db.ReviewCollection.Find(item => item.UserId == customer.Id).Id,
                "ssss",
                1
                );
#pragma warning restore CS8602 // –азыменование веро€тной пустой ссылки.

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Update_Review_Score_Biggest_Then_5()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Customer customer = Helpers.getCustomer(db);
#pragma warning disable CS8602 // –азыменование веро€тной пустой ссылки.
            bool result = customer.updateReview(
                db.ReviewCollection.Find(item => item.UserId == customer.Id).Id,
                "ssss",
                6
                );
#pragma warning restore CS8602 // –азыменование веро€тной пустой ссылки.

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Update_Review_Score_Less_Then_1()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Customer customer = Helpers.getCustomer(db);
#pragma warning disable CS8602 // –азыменование веро€тной пустой ссылки.
            bool result = customer.updateReview(
                db.ReviewCollection.Find(item => item.UserId == customer.Id).Id,
                "ssss",
                0
                );
#pragma warning restore CS8602 // –азыменование веро€тной пустой ссылки.

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Update_Not_Existed_Review()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Customer customer = Helpers.getCustomer(db);
            bool result = customer.updateReview(
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
            Customer customer = Helpers.getCustomer(db);
#pragma warning disable CS8602 // –азыменование веро€тной пустой ссылки.
            bool result = customer.updateReview(
                db.ReviewCollection.Find(item => item.UserId == Helpers.getAdmin(db).Id).Id,
                "ssss",
                3
                );
#pragma warning restore CS8602 // –азыменование веро€тной пустой ссылки.

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Make_Review_Again_For_One_Film()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Customer customer = Helpers.getCustomer(db);
            bool result = customer.makeReview(
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
            Customer customer = Helpers.getCustomer(db);
            bool result = customer.makeReview(
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
            Customer customer = Helpers.getCustomer(db);
            bool result = customer.makeReview(
                db.FilmCollection[1].Id,
                "ssss",
                1
                );

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Check_If_There_Was_Session()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Customer customer = Helpers.getCustomer(db);
            bool result = customer.checkIfThereWasSession(db.FilmCollection[1].Id);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Check_If_No_There_Was_Session()
        {
            //Arrange
            CinemaDataBase db = Helpers.initializeCinemaDb();

            // Act
            Customer customer = Helpers.getCustomer(db);
            bool result = customer.checkIfThereWasSession(db.FilmCollection[0].Id);

            // Assert
            Assert.IsFalse(result);
        }
    }
}