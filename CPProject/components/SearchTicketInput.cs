using CPProject.DataBaseModel;
using CPProject.DataBaseModel.entities;

namespace CPProject.components
{
    public partial class SearchTicketInput : UserControl
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
        public Action<Ticket> OnTicketFound { get; set; }
        public SearchTicketInput(Action<Ticket> onTicketFound)
        {
            InitializeComponent();
            InputInitialize();
            OnTicketFound = onTicketFound;
            labelInformation.Text = string.Empty;
        }

        private void InputInitialize()
        {
            maskedTextBoxTicketID.PromptChar = 'X';
            maskedTextBoxTicketID.Mask = "AAAAAA-AAAAAA-AAAAAA-AAAAAA";
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBoxTicketID.MaskFull)
            {
                roundedButtonFind.Enabled = true;
            }
            else
            {
                roundedButtonFind.Enabled = false;
            }
        }

        private void SearchTicketInput_Load(object sender, EventArgs e)
        {
            roundedButtonFind.Enabled = false;
        }

        private void roundedButtonFind_Click(object sender, EventArgs e)
        {
            FindTicket();
        }

        private void FindTicket()
        {
            Ticket? ticket = DataBase.TicketCollection.Find(item => item.Id == maskedTextBoxTicketID.Text.ToLower().Replace("-", ""));
            if (ticket == null)
            {
                labelInformation.Text = "Ticket Not found :(";
                return;
            }
            labelInformation.Text = string.Empty;
            OnTicketFound?.Invoke(ticket);
        }
    }
}
