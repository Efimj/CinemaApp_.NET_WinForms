using CPProject.DataBaseModel.types;
using System.ComponentModel;
using System.Reflection;

namespace CPProject.Forms
{
    public partial class DialogUserBan : Form
    {
        private DataBaseModel.entities.User user;
        private DateTime appointmentDate;
        private BlockDurationType blockDuration;
        private BlockReasonType blockReason;
        private readonly string DateTimeStringFormat = "dd.MM.yyyy HH:mm";

        public DataBaseModel.entities.User User { get => user; set { user = value; OnUserChange(); } }
        public BlockDurationType BlockDuration { get => blockDuration; set => blockDuration = value; }
        public BlockReasonType BlockReason { get => blockReason; set => blockReason = value; }
        public DateTime AppointmentDate { get => appointmentDate; set { appointmentDate = value; OnChangeAppointmentDate(); } }
        public DialogUserBan()
        {
            InitializeComponent();
            InitializeComboBoxBlockDuration();
            InitializeComboBoxBlockReason();
            AppointmentDate = DateTime.Now;
        }

        private void OnChangeAppointmentDate()
        {
            labelDate.Text = AppointmentDate.ToString(DateTimeStringFormat);
        }

        private void InitializeComboBoxBlockDuration()
        {
            foreach (BlockDurationType value in Enum.GetValues(typeof(BlockDurationType)))
            {
                var field = value.GetType().GetField(value.ToString());
                var descriptionAttribute = field.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;
                var description = descriptionAttribute?.Description ?? value.ToString();
                customComboBoxBlockDuration.Items.Add(new { description, Value = value });
            }

            customComboBoxBlockDuration.DisplayMember = "Description";
            customComboBoxBlockDuration.SelectedIndex = 3;
        }

        private void InitializeComboBoxBlockReason()
        {
            foreach (BlockReasonType value in Enum.GetValues(typeof(BlockReasonType)))
            {
                var field = value.GetType().GetField(value.ToString());
                var descriptionAttribute = field.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;
                var description = descriptionAttribute?.Description ?? value.ToString();
                customComboBoxBlockReason.Items.Add(new { description, Value = value });
            }

            customComboBoxBlockReason.DisplayMember = "Description";
            customComboBoxBlockReason.SelectedIndex = 2;
        }

        private void OnUserChange()
        {
            labelUserLogin.Text = User.Login;
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void roundedButtonBlock_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void customComboBoxBlockReason_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            BlockReason = (BlockReasonType)customComboBoxBlockReason.SelectedIndex;
        }

        private void customComboBoxBlockDuration_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            BlockDuration = (BlockDurationType)customComboBoxBlockDuration.SelectedIndex;
        }
    }
}
