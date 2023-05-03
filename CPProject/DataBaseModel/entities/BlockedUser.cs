using CPProject.DataBaseModel.types;
using System.Text.Json.Serialization;

namespace CPProject.DataBaseModel.entities
{
    [Serializable]
    public class BlockedUser
    {
        private string id;
        private string userId;
        private BlockDurationType blockDuration;
        private BlockReasonType blockReason;
        private DateTime appointmentDate;
        public string Id { get => id; private set => id = value; }
        public string UserId { get => userId; private set => userId = value; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public BlockDurationType BlockDuration { get => blockDuration; set => blockDuration = value; }
        public BlockReasonType BlockReason { get => blockReason; set => blockReason = value; }
        public DateTime AppointmentDate
        {
            get => appointmentDate; set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException();
                }
                appointmentDate = value;
            }
        }

        public BlockedUser(string id, string userId, BlockDurationType blockDuration, BlockReasonType blockReason, DateTime appointmentDate)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            UserId = userId ?? throw new ArgumentNullException(nameof(userId));
            BlockDuration = blockDuration;
            BlockReason = blockReason;
            AppointmentDate = appointmentDate;
        }
    }
}
