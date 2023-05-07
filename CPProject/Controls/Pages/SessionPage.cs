using CPProject.components.ui;
using CPProject.DataBaseModel;
using CPProject.DataBaseModel.entities;
using CPProject.DataBaseModel.types;
using CPProject.User;
using System.Diagnostics;

namespace CPProject.Controls.Pages
{
    public partial class SessionPage : UserControl
    {
        private enum SessionsDGVMode
        {
            Future,
            Archive,
            My,
        }
        private RoundedButton? lastButtonActivated;
        private SessionsDGVMode sessionsDGVMode;
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

        private int? selectedRowIndex = null;

        private int? SelectedRowIndex
        {
            get => selectedRowIndex;
            set
            {
                selectedRowIndex = value;
                SetButtonEditSessionActive();
                SetButtonBuyTicketActive();
            }
        }

        private SessionsDGVMode CurrentSessionsDGVMode { get => sessionsDGVMode; set { sessionsDGVMode = value; DGVModeChange(); } }
        public SessionPage()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            SelectedRowIndex = null;
            CurrentSessionsDGVMode = SessionsDGVMode.Future;
            setButtonActive(roundedButtonFutureSession);
            DGVInitialize();
            ButtonShowerInitialize();
        }

        private void DGVInitialize()
        {
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void DGVModeChange()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = GetRowCount();
        }

        private int GetRowCount()
        {
            int? count = 0;
            switch (CurrentSessionsDGVMode)
            {
                case SessionsDGVMode.Future:
                    count = GetFutureSessionCount();
                    break;
                case SessionsDGVMode.Archive:
                    count = GetArchiveSessionCount();
                    break;
                case SessionsDGVMode.My:
                    count = GetMySessionCount();
                    break;
            }
            return count == null ? 0 : (int)count;
        }

        private static int? GetFutureSessionCount()
        {
            try
            {
                return DataBase.SessionCollection
                                    .Where(item => item.Date > DateTime.Now)
                                    .OrderBy(item => item.Date)
                                    .Count();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        private static int? GetArchiveSessionCount()
        {
            try
            {
                return DataBase.SessionCollection
                                    .Where(item => item.Date < DateTime.Now)
                                    .OrderByDescending(item => item.Date)
                                    .Count();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        private static int? GetMySessionCount()
        {
            try
            {
                if (AccountHandler.Instance.User == null)
                    return null;
                return DataBase.TicketCollection
                    .Where(item => AccountHandler.Instance.User.Id == item.UserId)
                    .GroupBy(item => item.SessionId)
                    .Count();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        private static Session? GetFutureSession(int index)
        {
            try
            {
                return DataBase.SessionCollection
                                    .Where(item => item.Date > DateTime.Now)
                                    .OrderBy(item => item.Date)
                                    .ElementAt(index);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        private static Session? GetArchiveSession(int index)
        {
            try
            {
                return DataBase.SessionCollection
                                        .Where(item => item.Date < DateTime.Now)
                                        .OrderByDescending(item => item.Date)
                                        .ElementAt(index);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        private static Session? GetMySession(int index)
        {
            try
            {
                if (AccountHandler.Instance.User == null)
                    return null;
                Ticket? ticket = DataBase.TicketCollection
                    .Where(item => AccountHandler.Instance.User.Id == item.UserId)
                    .GroupBy(item => item.SessionId).ElementAt(index).First();
                if (ticket == null)
                    return null;
                return DataBase.SessionCollection.Find(item => item.Id == ticket.SessionId);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        class TicketSessionComparer : IEqualityComparer<Ticket>
        {
            public bool Equals(Ticket x, Ticket y)
            {
                return x.SessionId == y.SessionId;
            }

            public int GetHashCode(Ticket obj)
            {
                return obj.Id.GetHashCode();
            }
        }

        public void ButtonShowerInitialize()
        {
            roundedButtonBuyTicket.Enabled = false;
            roundedButtonEditSession.Enabled = false;

            if (AccountHandler.Instance.User == null)
            {
                HideAllButtons();
                return;
            }

            var userType = AccountHandler.Instance.User.UserType;
            roundedButtonCreateSession.Visible = userType == UserType.Admin;
            roundedButtonBuyTicket.Visible = true;
            roundedButtonSessionArchive.Visible = true;
            roundedButtonEditSession.Visible = userType == UserType.Admin;
        }

        private void HideAllButtons()
        {
            roundedButtonCreateSession.Visible = false;
            roundedButtonBuyTicket.Visible = false;
            roundedButtonMySession.Visible = false;
            roundedButtonEditSession.Visible = false;
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

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            setButtonActive((RoundedButton)sender);
            SelectedRowIndex = null;
            CurrentSessionsDGVMode = SessionsDGVMode.Future;
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            setButtonActive((RoundedButton)sender);
            SelectedRowIndex = null;
            CurrentSessionsDGVMode = SessionsDGVMode.Archive;
        }

        private void roundedButton1_Click_1(object sender, EventArgs e)
        {
            setButtonActive((RoundedButton)sender);
            SelectedRowIndex = null;
            CurrentSessionsDGVMode = SessionsDGVMode.My;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedRowIndex = e.RowIndex;
            }
        }
        private void SetButtonEditSessionActive()
        {
            if (SelectedRowIndex == null)
            {
                roundedButtonEditSession.Enabled = false;
                return;
            }
            Session? session = GetSession((int)SelectedRowIndex);
            if (session != null && session.Date >= DateTime.Now)
            {
                roundedButtonEditSession.Enabled = true;
            }
            else
            {
                roundedButtonEditSession.Enabled = false;
            }
        }
        private void SetButtonBuyTicketActive()
        {
            if (SelectedRowIndex == null)
            {
                roundedButtonBuyTicket.Enabled = false;
                return;
            }
            int? freeTickets = GetSessionTicketBookedCount((int)SelectedRowIndex);
            if (freeTickets != null && freeTickets > 0 && GetSession((int)SelectedRowIndex)?.Date > DateTime.Now)
            {
                roundedButtonBuyTicket.Enabled = true;
            }
            else
            {
                roundedButtonBuyTicket.Enabled = false;
            }
        }

        private void setNewPage(UserControl page)
        {
            this.Hide();
            page.Dock = DockStyle.Fill;
            Panel? parentPanel = (Panel?)this.Parent;
            if (parentPanel != null)
            {
                parentPanel.Controls.Add(page);
            }
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            setNewPage(new CreateSessionPage());
        }

        private void dataGridView1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
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
                        e.Value = GetSessionTicketCount(rowIndex);
                        break;
                    case 4:
                        e.Value = GetSessionTicketPrice(rowIndex)?.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
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

        private double? GetSessionTicketPrice(int rowIndex)
        {

            Session? session = GetSession(rowIndex);
            if (session == null)
                return null;
            double cost = 0;
            switch (CurrentSessionsDGVMode)
            {
                case SessionsDGVMode.My:
                    if (AccountHandler.Instance.User == null)
                        return 0;
                    cost = DataBase.TicketCollection.Where(item => item.UserId == AccountHandler.Instance.User.Id && item.SessionId == session.Id).Sum(item => item.Price);
                    break;
                default:
                    cost = session.DefaultTicketPrice;
                    break;
            }
            return cost;
        }

        private int? GetSessionTicketCount(int rowIndex)
        {
            Session? session = GetSession(rowIndex);
            if (session == null)
                return null;

            int count = 0;
            switch (CurrentSessionsDGVMode)
            {
                case SessionsDGVMode.My:
                    if (AccountHandler.Instance.User == null)
                        return 0;
                    string userId = AccountHandler.Instance.User.Id;
                    count = DataBase.TicketCollection.Count(item => item.SessionId == session.Id && item.State != TicketState.Returned && item.UserId == userId);
                    break;
                default:
                    int countOrderedTickets = DataBase.TicketCollection.Count(item => item.SessionId == session.Id && item.State != TicketState.Returned);
                    count = session.TicketCount - countOrderedTickets;
                    break;
            }

            return count;
        }

        private int? GetSessionTicketBookedCount(int rowIndex)
        {
            Session? session = GetSession(rowIndex);
            if (session == null)
                return null;

            int countOrderedTickets = DataBase.TicketCollection.Count(item => item.SessionId == session.Id && item.State != TicketState.Returned);
            return session.TicketCount - countOrderedTickets;
        }

        private DateTime GetSessionDate(int rowIndex)
        {
            Session? session = GetSession(rowIndex);
            return session != null ? session.Date : DateTime.Now;
        }

        private string GetSessionAddress(int rowIndex)
        {
            Session? session = GetSession(rowIndex);
            return session != null ? session.Address : "No have address.";
        }

        private string GetFilmTitle(int rowIndex)
        {
            Film? film = GetFilm(rowIndex);
            return film != null ? film.Title : "No have title (";
        }

        private Session? GetSession(int rowIndex)
        {
            Session? session;
            switch (CurrentSessionsDGVMode)
            {
                case SessionsDGVMode.Future:
                    session = GetFutureSession(rowIndex);
                    break;
                case SessionsDGVMode.Archive:
                    session = GetArchiveSession(rowIndex);
                    break;
                case SessionsDGVMode.My:
                    session = GetMySession(rowIndex);
                    break;
                default:
                    session = null;
                    break;
            }
            return session;
        }

        private Film? GetFilm(int rowIndex)
        {
            Session? session = GetSession(rowIndex);
            if (session == null)
                return null;
            return DataBase.FilmCollection.Find(item => item.Id == session.FilmId);
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            if (SelectedRowIndex == null)
                return;
            Session? session = GetSession((int)SelectedRowIndex);
            if (session == null)
                return;
            setNewPage(new CreateSessionPage(session));
        }

        private void roundedButtonBuyTicket_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedRowIndex == null)
                    return;
                Film? film = GetFilm((int)SelectedRowIndex);
                if (film == null)
                    return;
                Session? session = GetSession((int)SelectedRowIndex);
                if (session == null)
                    return;
                if (GetSessionTicketCount((int)SelectedRowIndex) < 1)
                {
                    MessageBox.Show("Sorry, the tickets have run out.", "Ticket Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                setNewPage(new FilmTicketBookingPage(film, session));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
