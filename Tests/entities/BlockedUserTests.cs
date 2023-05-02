using CPProject.DataBaseModel.entities;
using CPProject.DataBaseModel.types;

namespace Tests.entities
{
    [TestClass]
    public class BlockedUserTests
    {
        [TestMethod]
        public void Constructor_ThrowsArgumentNullException_WhenIdIsNull()
        {
            // Arrange
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            string id = null;
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            string userId = "user123";
            BlockDurationType blockDuration = BlockDurationType.FourHours;
            BlockReasonType blockReason = BlockReasonType.SuspectedFraudulentActivity;
            DateTime appointmentDate = DateTime.Now;

            // Act & Assert
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            Assert.ThrowsException<ArgumentNullException>(() => new BlockedUser(id, userId, blockDuration, blockReason, appointmentDate));
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
        }

        [TestMethod]
        public void Constructor_ThrowsArgumentNullException_WhenUserIdIsNull()
        {
            // Arrange
            string id = "block123";
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            string userId = null;
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            BlockDurationType blockDuration = BlockDurationType.TwoWeeks;
            BlockReasonType blockReason = BlockReasonType.None;
            DateTime appointmentDate = DateTime.Now;

            // Act & Assert
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            Assert.ThrowsException<ArgumentNullException>(() => new BlockedUser(id, userId, blockDuration, blockReason, appointmentDate));
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
        }

        [TestMethod]
        public void AppointmentDate_SetterThrowsArgumentOutOfRangeException_WhenValueIsGreaterThanNow()
        {
            // Arrange
            string id = "block123";
            string userId = "user123";
            BlockDurationType blockDuration = BlockDurationType.Infinite;
            BlockReasonType blockReason = BlockReasonType.ViolationOfTermsOfService;
            DateTime appointmentDate = DateTime.Now.AddDays(1);
            var blockedUser = new BlockedUser(id, userId, blockDuration, blockReason, DateTime.Now);

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => blockedUser.AppointmentDate = appointmentDate);
        }
    }
}
