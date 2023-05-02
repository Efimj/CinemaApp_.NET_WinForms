using CPProject.DataBaseModel.entities;
using CPProject.DataBaseModel.types;

namespace Tests.entities
{
    [TestClass]
    public class TicketTests
    {
        [TestMethod]
        public void TestConstructor()
        {
            // Arrange
            string id = "1";
            string userId = "user123";
            string sessionId = "session456";
            double price = 9.99;
            int place = 5;
            DateTime purchaseDate = DateTime.Now;
            TicketState state = TicketState.Paid;

            // Act
            Ticket ticket = new Ticket(id, userId, sessionId, price, place, purchaseDate, state);

            // Assert
            Assert.AreEqual(id, ticket.Id);
            Assert.AreEqual(userId, ticket.UserId);
            Assert.AreEqual(sessionId, ticket.SessionId);
            Assert.AreEqual(price, ticket.Price);
            Assert.AreEqual(place, ticket.Place);
            Assert.AreEqual(purchaseDate, ticket.PurchaseDate);
            Assert.AreEqual(state, ticket.State);
        }

        [TestMethod]
        public void TestInvalidUserId()
        {
            // Arrange
            string id = "1";
            string userId = "";
            string sessionId = "session456";
            double price = 9.99;
            int place = 5;
            DateTime purchaseDate = DateTime.Now;
            TicketState state = TicketState.Paid;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => new Ticket(id, userId, sessionId, price, place, purchaseDate, state));
        }

        [TestMethod]
        public void TestInvalidSessionId()
        {
            // Arrange
            string id = "1";
            string userId = "user123";
            string sessionId = "";
            double price = 9.99;
            int place = 5;
            DateTime purchaseDate = DateTime.Now;
            TicketState state = TicketState.Paid;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => new Ticket(id, userId, sessionId, price, place, purchaseDate, state));
        }

        [TestMethod]
        public void TestInvalidPrice()
        {
            // Arrange
            string id = "1";
            string userId = "user123";
            string sessionId = "session456";
            double price = -1;
            int place = 5;
            DateTime purchaseDate = DateTime.Now;
            TicketState state = TicketState.Paid;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => new Ticket(id, userId, sessionId, price, place, purchaseDate, state));
        }

        [TestMethod]
        public void TestInvalidPlace()
        {
            // Arrange
            string id = "1";
            string userId = "user123";
            string sessionId = "session456";
            double price = 9.99;
            int place = 0;
            DateTime purchaseDate = DateTime.Now;
            TicketState state = TicketState.Paid;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => new Ticket(id, userId, sessionId, price, place, purchaseDate, state));
        }

        [TestMethod]
        public void TestInvalidPurchaseDate()
        {
            // Arrange
            string id = "1";
            string userId = "user123";
            string sessionId = "session456";
            double price = 9.99;
            int place = 5;
            DateTime purchaseDate = DateTime.Now.AddDays(1);
            TicketState state = TicketState.Paid;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => new Ticket(id, userId, sessionId, price, place, purchaseDate, state));
        }
        [TestMethod]
        public void TestConstructorWithNullId()
        {
            // Arrange
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            string id = null;
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            string userId = "user1";
            string sessionId = "session1";
            double price = 10.0;
            int place = 1;
            DateTime purchaseDate = DateTime.Now;
            TicketState state = TicketState.Paid;

            // Act & Assert
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            Assert.ThrowsException<ArgumentNullException>(() => new Ticket(id, userId, sessionId, price, place, purchaseDate, state));
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
        }

        [TestMethod]
        public void TestConstructorWithEmptyUserId()
        {
            // Arrange
            string id = "ticket1";
            string userId = "";
            string sessionId = "session1";
            double price = 10.0;
            int place = 1;
            DateTime purchaseDate = DateTime.Now;
            TicketState state = TicketState.Paid;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Ticket(id, userId, sessionId, price, place, purchaseDate, state));
        }

        [TestMethod]
        public void TestConstructorWithEmptySessionId()
        {
            // Arrange
            string id = "ticket1";
            string userId = "user1";
            string sessionId = "";
            double price = 10.0;
            int place = 1;
            DateTime purchaseDate = DateTime.Now;
            TicketState state = TicketState.Paid;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Ticket(id, userId, sessionId, price, place, purchaseDate, state));
        }

        [TestMethod]
        public void TestConstructorWithNegativePrice()
        {
            // Arrange
            string id = "ticket1";
            string userId = "user1";
            string sessionId = "session1";
            double price = -1.0;
            int place = 1;
            DateTime purchaseDate = DateTime.Now;
            TicketState state = TicketState.Paid;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Ticket(id, userId, sessionId, price, place, purchaseDate, state));
        }

        [TestMethod]
        public void TestConstructorWithZeroOrNegativePlace()
        {
            // Arrange
            string id = "ticket1";
            string userId = "user1";
            string sessionId = "session1";
            double price = 10.0;
            int place = -1;
            DateTime purchaseDate = DateTime.Now;
            TicketState state = TicketState.Paid;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Ticket(id, userId, sessionId, price, place, purchaseDate, state));

            place = 0;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Ticket(id, userId, sessionId, price, place, purchaseDate, state));
        }

        [TestMethod]
        public void TestConstructorWithFuturePurchaseDate()
        {
            // Arrange
            string id = "ticket1";
            string userId = "user1";
            string sessionId = "session1";
            double price = 10.0;
            int place = 1;
            DateTime purchaseDate = DateTime.Now.AddDays(1);
            TicketState state = TicketState.Paid;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Ticket(id, userId, sessionId, price, place, purchaseDate, state));
        }
    }
}
