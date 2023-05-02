using CPProject.DataBaseModel;
using CPProject.DataBaseModel.entities;
using CPProject.DataBaseModel.types;

namespace Tests.entities
{
    [TestClass]
    public class SimpleUserTests
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
        [TestMethod]
        public void Constructor_ValidInput_ObjectCreated()
        {
            // Arrange
            string id = "12345";
            string login = "test3login";
            string password = "testpas2sword";
            DateTime birthdayDate = DateTime.Now.AddYears(-20);
            UserType userType = UserType.Admin;

            // Act
            SimpleUser user = new SimpleUser(id, login, password, birthdayDate, userType);

            // Assert
            Assert.IsNotNull(user);
            Assert.AreEqual(id, user.Id);
            Assert.AreEqual(login, user.Login);
            Assert.AreEqual(password, user.Password);
            Assert.AreEqual(birthdayDate, user.BirthdayDate);
            Assert.AreEqual(userType, user.UserType);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_NullId_ThrowsException()
        {
            // Arrange
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            string id = null;
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            string login = "testlogin";
            string password = "testpassword";
            DateTime birthdayDate = DateTime.Now.AddYears(-20);
            UserType userType = UserType.Admin;

            // Act
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            User user = new SimpleUser(id, login, password, birthdayDate, userType);
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.

            // Assert
            // Expect ArgumentNullException to be thrown
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_NullLogin_ThrowsException()
        {
            // Arrange
            string id = "12345";
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            string login = null;
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            string password = "testpassw2ord";
            DateTime birthdayDate = DateTime.Now.AddYears(-20);
            UserType userType = UserType.Admin;

            // Act
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            User user = new SimpleUser(id, login, password, birthdayDate, userType);
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.

            // Assert
            // Expect ArgumentNullException to be thrown
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_NullPassword_ThrowsException()
        {
            // Arrange
            string id = "12345";
            string login = "test2login";
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            string password = null;
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            DateTime birthdayDate = DateTime.Now.AddYears(-20);
            UserType userType = UserType.Admin;

            // Act
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            User user = new SimpleUser(id, login, password, birthdayDate, userType);
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.

            // Assert
            // Expect ArgumentNullException to be thrown
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_UnderageUser_ThrowsException()
        {
            // Arrange
            string id = "12345";
            string login = "testlogin";
            string password = "testpassword";
            DateTime birthdayDate = DateTime.Now.AddYears(-11);
            UserType userType = UserType.Admin;

            // Act
            User user = new SimpleUser(id, login, password, birthdayDate, userType);

            // Assert
            // Expect ArgumentOutOfRangeException to be thrown
        }
        [TestMethod]
        public void PasswordCheck_CorrectPassword_ReturnsTrue()
        {
            // Arrange
            User user = new SimpleUser("12345", "testlogin", "testpa2ssw2ord", DateTime.Now.AddYears(-20), UserType.Admin);
            string password = "testpa2ssw2ord";

            // Act
            bool result = user.passwordCheck(password);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void PasswordCheck_IncorrectPassword_ReturnsFalse()
        {
            // Arrange
            User user = new SimpleUser("12345", "testlogin", "1testpassword", DateTime.Now.AddYears(-20), UserType.Admin);
            string password = "2wrongpassword";

            // Act
            bool result = user.passwordCheck(password);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void UpdateUserData_ValidInput_ReturnsTrue()
        {
            // Arrange
            User user = new SimpleUser("12345", "testlogin", "testpa1ssword", DateTime.Now.AddYears(-20), UserType.Admin);
            string newLogin = "newlogin";
            string newPassword = "newpas1sword";
            // Act
            bool result = user.updateUserData(newLogin, newPassword);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(newLogin, user.Login);
            Assert.AreEqual(newPassword, user.Password);
        }
        [TestMethod]
        public void UpdateUserData_InvalidPassword_ReturnsFalse()
        {
            // Arrange
            User user = new SimpleUser("12345", "testlogin", "te2stpassword", DateTime.Now.AddYears(-20), UserType.Admin);
            string newLogin = "newlogin";
            string newPassword = "123"; // invalid password

            // Act
            bool result = user.updateUserData(newLogin, newPassword);

            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual("testlogin", user.Login); // login should not have been updated
            Assert.AreEqual("te2stpassword", user.Password); // password should not have been updated
        }
    }
}
