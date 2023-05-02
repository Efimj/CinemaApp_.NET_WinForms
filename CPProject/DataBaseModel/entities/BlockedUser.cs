using CPProject.DataBaseModel.types;

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

#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public BlockedUser(string id, string userId, BlockDurationType blockDuration, BlockReasonType blockReason, DateTime appointmentDate)
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            UserId = userId ?? throw new ArgumentNullException(nameof(userId));
            BlockDuration = blockDuration;
            BlockReason = blockReason;
            AppointmentDate = appointmentDate;
        }
    }
}
