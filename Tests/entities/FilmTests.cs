using CPProject.DataBaseModel.entities;
using CPProject.DataBaseModel.types;

namespace Tests.entities
{
    [TestClass]
    public class FilmTests
    {
#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        private Film _film;
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.

        [TestInitialize]
        public void TestInitialize()
        {
            // arrange
            _film = new Film("1", "title", "description", "ssxa.jpg", FilmGenre.Drama, new DateTime(1994, 9, 22), AgeRating.R);
        }

        [TestMethod]
        public void Constructor_ThrowsExceptionWhenIdIsNull()
        {
            // act and assert
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
            Assert.ThrowsException<ArgumentNullException>(() => new Film(null, "title", "description", "ssxa.jpg", FilmGenre.Drama, new DateTime(1994, 9, 22), AgeRating.R));
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        }

        [TestMethod]
        public void Constructor_ThrowsExceptionWhenTitleIsNull()
        {
            // act and assert
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
            Assert.ThrowsException<ArgumentNullException>(() => new Film("1", null, "description", "ssxa.jpg", FilmGenre.Drama, new DateTime(1994, 9, 22), AgeRating.R));
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        }

        [TestMethod]
        public void Constructor_ThrowsExceptionWhenDescriptionIsNull()
        {
            // act and assert
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
            Assert.ThrowsException<ArgumentNullException>(() => new Film("1", "title", null, "ssxa.jpg", FilmGenre.Drama, new DateTime(1994, 9, 22), AgeRating.R));
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
        }

        [TestMethod]
        public void SetTitle_ThrowsExceptionWhenValueIsEmpty()
        {
            // act and assert
            Assert.ThrowsException<ArgumentException>(() => _film.Title = string.Empty);
        }

        [TestMethod]
        public void SetDescription_ThrowsExceptionWhenValueIsEmpty()
        {
            // act and assert
            Assert.ThrowsException<ArgumentException>(() => _film.Description = string.Empty);
        }

        [TestMethod]
        public void Id_ReturnsExpectedValue()
        {
            // assert
            Assert.AreEqual("1", _film.Id);
        }

        [TestMethod]
        public void Title_ReturnsExpectedValue()
        {
            // assert
            Assert.AreEqual("title", _film.Title);
        }

        [TestMethod]
        public void SetTitle_ChangesTitle()
        {
            // act
            _film.Title = "The Godfather";

            // assert
            Assert.AreEqual("The Godfather", _film.Title);
        }

        [TestMethod]
        public void Description_ReturnsExpectedValue()
        {
            // assert
            Assert.AreEqual("description", _film.Description);
        }

        [TestMethod]
        public void SetDescription_ChangesDescription()
        {
            // act
            _film.Description = "desc23";

            // assert
            Assert.AreEqual("desc23", _film.Description);
        }

        [TestMethod]
        public void PhotoName_ReturnsExpectedValue()
        {
            // assert
            Assert.AreEqual("ssxa.jpg", _film.PhotoName);
        }
    }
}
