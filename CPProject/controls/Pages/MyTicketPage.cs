using CPProject.components.ui;
using CPProject.DataBaseModel;
using CPProject.DataBaseModel.entities;
using CPProject.User;
using System.Diagnostics;

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

        private static CinemaDataBase? DBInstance = null;
        private int? selectedRowIndex = null;
        private RoundedButton? lastButtonActivated;
        private MyTicketPageState currentMyTicketPageState;
        private UserControl? lastUserControl;
        private MyTicketPageState CurrentMyTicketPageState
        {
            get => currentMyTicketPageState;
            set
            {
                currentMyTicketPageState = value;
                OnChangePageState();
            }
        }

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

        private int? SelectedRowIndex
        {
            get => selectedRowIndex;
            set
            {
                selectedRowIndex = value;
                OnSelectedRowChange();
            }
        }

        public MyTicketPage()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            InitializePage();
            DGVInitialize();
        }

        private void DGVInitialize()
        {
            dataGridViewTickets.ForeColor = Color.Black;
            dataGridViewTickets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void DGVModeChange()
        {
            dataGridViewTickets.Rows.Clear();
            dataGridViewTickets.RowCount = GetRowCount();
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

        private void OnSelectedRowChange()
        {
            //if (SelectedRowIndex < 0)
            //    return;
            //switch (CurrentMyTicketPageState)
            //{
            //    case MyTicketPageState.ActiveTickets:
            //        roundedButtonReturnTicket.Show();
            //        break;
            //    case MyTicketPageState.ArchiveTickets:
            //        roundedButtonReturnTicket.Hide();
            //        break;
            //    case MyTicketPageState.FindTicket:
            //        roundedButtonReturnTicket.Hide();
            //        roundedButtonTicketDetails.Hide();
            //        break;
            //}
        }

        private int GetRowCount()
        {
            switch (CurrentMyTicketPageState)
            {
                case MyTicketPageState.ActiveTickets:
                    return getCountActiveTickets();
                case MyTicketPageState.ArchiveTickets:
                    return getCountArchiveTickets();
                case MyTicketPageState.FindTicket:
                    return 0;
                default: return 0;
            }
        }

        private int getCountArchiveTickets()
        {
            if (AccountHandler.Instance.User == null)
                return 0;
            return getArchiveTickets().Count();
        }

        private int getCountActiveTickets()
        {
            if (AccountHandler.Instance.User == null)
                return 0;
            return getActiveTickets().Count();
        }

        private IEnumerable<Ticket> getActiveTickets()
        {
            return DataBase.TicketCollection
                .Where(ticket => ticket.UserId.Equals(AccountHandler.Instance.User.Id) && ticket.State == DataBaseModel.types.TicketState.Paid)
                .Where(ticket =>
                {
                    Session? session = DataBase.SessionCollection.Find(session => session.Id == ticket.SessionId);
                    return session == null ? false : session.Date > DateTime.Now;
                });
        }

        private IEnumerable<Ticket> getArchiveTickets()
        {
            return DataBase.TicketCollection
                .Where(ticket => ticket.UserId.Equals(AccountHandler.Instance.User.Id))
                .Where(ticket =>
                {
                    Session? session = DataBase.SessionCollection.Find(session => session.Id == ticket.SessionId);
                    return session == null ? false : session.Date <= DateTime.Now;
                });
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
                    roundedButtonReturnTicket.Show();
                    roundedButtonTicketDetails.Show();
                    DGVActivate();
                    break;
                case MyTicketPageState.ArchiveTickets:
                    setButtonActive(roundedButtonArchive);
                    roundedButtonReturnTicket.Hide();
                    roundedButtonTicketDetails.Show();
                    DGVActivate();
                    break;
                case MyTicketPageState.FindTicket:
                    setButtonActive(roundedButtonSearch);
                    roundedButtonReturnTicket.Hide();
                    roundedButtonTicketDetails.Hide();
                    DGVHide();
                    break;
            }
            roundedPanelDGVContent.Controls.Remove(lastUserControl);
            DGVModeChange();
        }

        private void DGVHide()
        {
            roundedPanelDGVContent.Hide();
        }

        private void DGVActivate()
        {
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

        private Ticket? getActiveTicket(int index)
        {
            try
            {
                return getActiveTickets().ElementAt(index);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        private Ticket? getArchiveTicket(int index)
        {
            try
            {
                return getArchiveTickets().ElementAt(index);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        private Ticket? GetTicket(int rowIndex)
        {
            switch (CurrentMyTicketPageState)
            {
                case MyTicketPageState.ActiveTickets:
                    return getActiveTicket(rowIndex);
                case MyTicketPageState.ArchiveTickets:
                    return getArchiveTicket(rowIndex);
                default: return null;
            }
        }

        private Session? GetSessionByTicket(int rowIndex)
        {
            Ticket? ticket = GetTicket(rowIndex);
            if (ticket == null)
                return null;
            Session? session = DataBase.SessionCollection.Find(item => item.Id == ticket.SessionId);
            if (session == null)
                return null;
            return session;
        }

        private Film? GetFilmByTicket(int rowIndex)
        {
            Session? session = GetSessionByTicket(rowIndex);
            if (session == null)
                return null;
            Film? film = DataBase.FilmCollection.Find(item => item.Id == session.FilmId);
            if (film == null)
                return null;
            return film;
        }

        private string GetFilmTitle(int rowIndex)
        {
            Film? film = GetFilmByTicket(rowIndex);
            return film != null ? film.Title : "No have title (";
        }

        private string GetSessionAddress(int rowIndex)
        {
            Session? session = GetSessionByTicket(rowIndex);
            return session != null ? session.Address : "No have address (";
        }

        private DateTime GetSessionDate(int rowIndex)
        {
            Session? session = GetSessionByTicket(rowIndex);
            return session != null ? session.Date : DateTime.Now;
        }

        private int GetTicketSeat(int rowIndex)
        {
            Ticket? ticket = GetTicket(rowIndex);
            return ticket != null ? ticket.Place : -1;
        }

        private double GetTicketPrice(int rowIndex)
        {
            Ticket? ticket = GetTicket(rowIndex);
            return ticket != null ? ticket.Price : -1;
        }

        private void dataGridViewTickets_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 && e.RowIndex > DataBase.SessionCollection.Count)
                    return;
                int rowIndex = e.RowIndex;
                switch (e.ColumnIndex)
                {
                    case 0:
                        e.Value = GetFilmTitle(rowIndex);
                        break;
                    case 1:
                        e.Value = GetSessionAddress(rowIndex);
                        break;
                    case 2:
                        e.Value = GetSessionDate(rowIndex).ToString("dd.MM.yyyy HH:mm");
                        break;
                    case 3:
                        e.Value = GetTicketSeat(rowIndex);
                        break;
                    case 4:
                        e.Value = GetTicketPrice(rowIndex).ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("dataGridView1_CellValueNeeded");
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                Debug.WriteLine(ex.Source);
            }
        }

        private void dataGridViewTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRowIndex = e.RowIndex;
        }

        private void roundedButtonTicketDetails_Click(object sender, EventArgs e)
        {
            TicketDetails ticketDetails = new TicketDetails();
            ticketDetails.Dock = DockStyle.Fill;
            SuspendLayout();
            setButtonActive(roundedButtonSearch);
            CurrentMyTicketPageState = MyTicketPageState.FindTicket;
            roundedPanelContent.Controls.Add(ticketDetails);
            lastUserControl = ticketDetails;
            ResumeLayout(false);
        }
    }
}
