using CPProject.DataBaseModel.entities;

namespace Tests.entities
{
    [TestClass]
    public class ReviewTests
    {
        [TestMethod]
        public void TestReviewConstructor()
        {
            // Arrange
            string id = "1";
            string filmId = "2";
            string userId = "3";
            string description = "Great movie!";
            int score = 5;
            DateTime changeTime = new DateTime(2023, 4, 6);

            // Act
            Review review = new Review(id, filmId, userId, description, score, changeTime);

            // Assert
            Assert.IsNotNull(review);
            Assert.AreEqual(id, review.Id);
            Assert.AreEqual(filmId, review.FilmId);
            Assert.AreEqual(userId, review.UserId);
            Assert.AreEqual(description, review.Description);
            Assert.AreEqual(score, review.Score);
            Assert.AreEqual(changeTime, review.ChangeTime);
        }

        [TestMethod]
        public void TestReviewConstructor_NullId_ThrowsArgumentNullException()
        {
            // Arrange
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            string id = null;
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            string filmId = "2";
            string userId = "3";
            string description = "Great movie!";
            int score = 5;
            DateTime changeTime = new DateTime(2023, 4, 6);

            // Act & Assert
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            Assert.ThrowsException<ArgumentNullException>(() => new Review(id, filmId, userId, description, score, changeTime));
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
        }

        [TestMethod]
        public void TestReviewConstructor_NullFilmId_ThrowsArgumentNullException()
        {
            // Arrange
            string id = "1";
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            string filmId = null;
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            string userId = "3";
            string description = "Great movie!";
            int score = 5;
            DateTime changeTime = new DateTime(2023, 4, 6);

            // Act & Assert
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            Assert.ThrowsException<ArgumentNullException>(() => new Review(id, filmId, userId, description, score, changeTime));
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
        }

        [TestMethod]
        public void TestReviewConstructor_NullUserId_ThrowsArgumentNullException()
        {
            // Arrange
            string id = "1";
            string filmId = "2";
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            string userId = null;
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            string description = "Great movie!";
            int score = 5;
            DateTime changeTime = new DateTime(2023, 4, 6);

            // Act & Assert
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            Assert.ThrowsException<ArgumentNullException>(() => new Review(id, filmId, userId, description, score, changeTime));
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
        }

        [TestMethod]
        public void TestReviewDescriptionSetter_ChangesDescriptionAndChangeTime()
        {
            // Arrange
            string id = "1";
            string filmId = "2";
            string userId = "3";
            string description = "Great movie!";
            int score = 5;
            DateTime initialChangeTime = new DateTime(2023, 4, 6);

            Review review = new Review(id, filmId, userId, description, score, initialChangeTime);

            // Act
            review.Description = "Amazing movie!";
            DateTime updatedChangeTime = DateTime.Now;

            // Assert
            Assert.AreEqual("Amazing movie!", review.Description);
            Assert.IsTrue(review.ChangeTime <= updatedChangeTime);
        }

        [TestMethod]
        public void TestReviewScoreSetter_InvalidScore_ThrowsArgumentException()
        {
            // Arrange
            string id = "1";
            string filmId = "2";
            string userId = "3";
            string description = "Great movie!";
            int score = 5;
            DateTime changeTime = new DateTime(2023, 4, 6);

            Review review = new Review(id, filmId, userId, description, score, changeTime);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => review.Score = 0);
            Assert.ThrowsException<ArgumentException>(() => review.Score = 6);
        }
        [TestMethod]
        public void TestReviewConstructor_ValidInput_CreatesObjectWithCorrectProperties()
        {
            // Arrange
            string id = "1";
            string filmId = "2";
            string userId = "3";
            string description = "Great movie!";
            int score = 5;
            DateTime changeTime = new DateTime(2023, 4, 6);

            // Act
            Review review = new Review(id, filmId, userId, description, score, changeTime);

            // Assert
            Assert.AreEqual(id, review.Id);
            Assert.AreEqual(filmId, review.FilmId);
            Assert.AreEqual(userId, review.UserId);
            Assert.AreEqual(description, review.Description);
            Assert.AreEqual(score, review.Score);
            Assert.AreEqual(changeTime, review.ChangeTime);
        }
    }
}
