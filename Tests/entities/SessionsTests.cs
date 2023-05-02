using CPProject.DataBaseModel.entities;

namespace Tests.entities
{
    [TestClass]
    public class SessionsTests
    {
        [TestMethod]
        public void Constructor_Sets_Properties_Correctly()
        {
            // Arrange
            string id = "1";
            string filmId = "2";
            string address = "sddssaw";
            DateTime date = DateTime.Now.AddDays(1);
            int ticketCount = 100;
            double defaultTicketPrice = 9.99;

            // Act
            Session session = new Session(id, filmId, address, date, ticketCount, defaultTicketPrice);

            // Assert
            Assert.AreEqual(id, session.Id);
            Assert.AreEqual(filmId, session.FilmId);
            Assert.AreEqual(address, session.Address);
            Assert.AreEqual(date, session.Date);
            Assert.AreEqual(ticketCount, session.TicketCount);
            Assert.AreEqual(defaultTicketPrice, session.DefaultTicketPrice);
        }

        [TestMethod]
        public void FilmId_Throws_ArgumentOutOfRangeException_When_Length_Is_Less_Than_1()
        {
            // Arrange
            Session session = new Session("1", "2", "sddssaw", DateTime.Now.AddDays(1), 100, 9.99);

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => session.FilmId = "");
        }

        [TestMethod]
        public void Address_Throws_ArgumentOutOfRangeException_When_Length_Is_Less_Than_1()
        {
            // Arrange
            Session session = new Session("1", "2", "sddssaw", DateTime.Now.AddDays(1), 100, 9.99);

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => session.Address = "");
        }

        [TestMethod]
        public void Date_Throws_ArgumentOutOfRangeException_When_Value_Is_Less_Than_Current_DateTime()
        {
            // Arrange
            Session session = new Session("1", "2", "sddssaw", DateTime.Now.AddDays(1), 100, 9.99);

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => session.Date = DateTime.Now.AddDays(-1));
        }

        [TestMethod]
        public void TicketCount_Throws_ArgumentOutOfRangeException_When_Value_Is_Less_Or_Equal_To_0()
        {
            // Arrange
            Session session = new Session("1", "2", "sddssaw", DateTime.Now.AddDays(1), 100, 9.99);

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => session.TicketCount = 0);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => session.TicketCount = -1);
        }

        [TestMethod]
        public void DefaultTicketPrice_Throws_ArgumentOutOfRangeException_When_Value_Is_Less_Than_0()
        {
            // Arrange
            Session session = new Session("1", "2", "sddssaw", DateTime.Now.AddDays(1), 100, 9.99);

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => session.DefaultTicketPrice = -1);
        }
        [TestMethod]
        public void Constructor_Throws_ArgumentNullException_When_Id_Is_Null()
        {
            // Act & Assert
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
            Assert.ThrowsException<ArgumentNullException>(() => new Session(null, "2", "sddssaw", DateTime.Now.AddDays(1), 100, 9.99));
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        }

        [TestMethod]
        public void Constructor_Throws_ArgumentNullException_When_FilmId_Is_Null()
        {
            // Act & Assert
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
            Assert.ThrowsException<ArgumentNullException>(() => new Session("1", null, "sddssaw", DateTime.Now.AddDays(1), 100, 9.99));
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        }

        [TestMethod]
        public void Constructor_Throws_ArgumentNullException_When_Address_Is_Null()
        {
            // Act & Assert
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
            Assert.ThrowsException<ArgumentNullException>(() => new Session("1", "2", null, DateTime.Now.AddDays(1), 100, 9.99));
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        }

        [TestMethod]
        public void FilmId_Sets_Value_Correctly_When_Value_Is_Valid()
        {
            // Arrange
            Session session = new Session("1", "2", "sddssaw", DateTime.Now.AddDays(1), 100, 9.99);
            string newFilmId = "3";

            // Act
            session.FilmId = newFilmId;

            // Assert
            Assert.AreEqual(newFilmId, session.FilmId);
        }

        [TestMethod]
        public void Address_Sets_Value_Correctly_When_Value_Is_Valid()
        {
            // Arrange
            Session session = new Session("1", "2", "sddssaw", DateTime.Now.AddDays(1), 100, 9.99);
            string newAddress = "456 Second Ave";

            // Act
            session.Address = newAddress;

            // Assert
            Assert.AreEqual(newAddress, session.Address);
        }

        [TestMethod]
        public void Date_Sets_Value_Correctly_When_Value_Is_Valid()
        {
            // Arrange
            Session session = new Session("1", "2", "sddssaw", DateTime.Now.AddDays(1), 100, 9.99);
            DateTime newDate = DateTime.Now.AddDays(2);

            // Act
            session.Date = newDate;

            // Assert
            Assert.AreEqual(newDate, session.Date);
        }

        [TestMethod]
        public void TicketCount_Sets_Value_Correctly_When_Value_Is_Valid()
        {
            // Arrange
            Session session = new Session("1", "2", "sddssaw", DateTime.Now.AddDays(1), 100, 9.99);
            int newTicketCount = 200;

            // Act
            session.TicketCount = newTicketCount;

            // Assert
            Assert.AreEqual(newTicketCount, session.TicketCount);
        }

        [TestMethod]
        public void DefaultTicketPrice_Sets_Value_Correctly_When_Value_Is_Valid()
        {
            // Arrange
            Session session = new Session("1", "2", "sddssaw", DateTime.Now.AddDays(1), 100, 9.99);
            double newDefaultTicketPrice = 10.99;

            // Act
            session.DefaultTicketPrice = newDefaultTicketPrice;

            // Assert
            Assert.AreEqual(newDefaultTicketPrice, session.DefaultTicketPrice);
        }
    }
}
