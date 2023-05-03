using CPProject.components.ui;
using CPProject.User;

namespace CPProject.controls.Pages
{
    public partial class MyTicketPage : UserControl
    {
        private enum MyTicketPageState
        {
            ActiveTickets,
            ArchiveTickets,
            FindTicket,
        }

        private RoundedButton? lastButtonActivated;

        private MyTicketPageState currentMyTicketPageState;

        private MyTicketPageState CurrentMyTicketPageState
        {
            get => currentMyTicketPageState;
            set
            {
                currentMyTicketPageState = value;
                OnChangePageState();
            }
        }

        public MyTicketPage()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            InitializePage();
        }

        private void InitializePage()
        {
            CheckUserAccount();
        }

        private void CheckUserAccount()
        {
            if (AccountHandler.Instance.User == null)
            {
                CurrentMyTicketPageState = MyTicketPageState.FindTicket;
                HideButtons();
            }
            else
            {
                CurrentMyTicketPageState = MyTicketPageState.ActiveTickets;
                ShowButtons();
            }
        }

        private void ShowButtons()
        {
            roundedButtonArchive.Show();
            roundedButtonActive.Show();
            roundedButtonReturnTicket.Show();
        }

        private void HideButtons()
        {
            roundedButtonArchive.Hide();
            roundedButtonActive.Hide();
            roundedButtonReturnTicket.Hide();
        }

        private void OnChangePageState()
        {
            switch (CurrentMyTicketPageState)
            {
                case MyTicketPageState.ActiveTickets:
                    setButtonActive(roundedButtonActive);
                    DGVActivate();
                    break;
                case MyTicketPageState.ArchiveTickets:
                    setButtonActive(roundedButtonArchive);
                    DGVActivate();
                    break;
                case MyTicketPageState.FindTicket:
                    setButtonActive(roundedButtonSearch);
                    DGVHide();
                    break;
            }
        }

        private void DGVHide()
        {
            roundedButtonReturnTicket.Hide();
            roundedPanelDGVContent.Hide();
        }

        private void DGVActivate()
        {
            roundedButtonReturnTicket.Show();
            roundedPanelDGVContent.Show();
        }

        private void setButtonActive(RoundedButton nextButton)
        {
            if (lastButtonActivated != null)
            {
                lastButtonActivated.ForeColor = Color.Black;
                lastButtonActivated.BackColor = Color.White;
                lastButtonActivated.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            }
            nextButton.ForeColor = Color.White;
            nextButton.BackColor = Color.MediumSlateBlue;
            nextButton.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lastButtonActivated = nextButton;
        }

        private void roundedButtonActive_Click(object sender, EventArgs e)
        {
            setButtonActive((RoundedButton)sender);
            CurrentMyTicketPageState = MyTicketPageState.ActiveTickets;
        }

        private void roundedButtonArchive_Click(object sender, EventArgs e)
        {
            setButtonActive((RoundedButton)sender);
            CurrentMyTicketPageState = MyTicketPageState.ArchiveTickets;
        }

        private void roundedButtonSearch_Click(object sender, EventArgs e)
        {
            setButtonActive((RoundedButton)sender);
            CurrentMyTicketPageState = MyTicketPageState.FindTicket;
        }
    }
}
