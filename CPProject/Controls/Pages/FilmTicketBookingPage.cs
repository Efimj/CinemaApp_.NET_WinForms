using CPProject.DataBaseModel;
using CPProject.DataBaseModel.entities;
using CPProject.DataBaseModel.types;
using CPProject.User;
using CPProject.User.types;
using System.Diagnostics;

namespace CPProject.Controls.Pages
{
    public partial class FilmTicketBookingPage : UserControl
    {
        private Film? film;
        private Session? session;
        private static CinemaDataBase? DBInstance = null;
        private IEnumerable<Session>? sessions;
        private readonly string DateTimeStringFormat = "dd.MM.yyyy HH:mm";
        private Film? Film { get => film; set { film = value; OnFilmChange(Film); } }
        private Session? Session { get => session; set { session = value; OnSessionChange(Session); } }
        private IEnumerable<Session>? Sessions { get => sessions; set => sessions = value; }
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

        public FilmTicketBookingPage(Film film, Session? session = null)
        {
            InitializeComponent();
            this.film = film;
            this.session = session;
        }

        private void FilmTicketBookingPage_Load(object sender, EventArgs e)
        {
            Session = session;
            Film = film;
        }

        private void OnSessionChange(Session session)
        {
            if (session == null)
                return;
            customComboBoxLocation.Items.Add(session.Address);
            customComboBoxTime.Items.Add(session.Date.ToString(DateTimeStringFormat));

            List<int> countTickets = GetAvalibleTickets(session);
            if (countTickets.Count < 1)
            {
                WhenTicketCountLessOne();
                goBack();
                return;
            }

            customComboBoxSeat.DataSource = countTickets;
            labelPrice.Text = session.DefaultTicketPrice.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));

            customComboBoxLocation.SelectedIndex = 0;
            customComboBoxTime.SelectedIndex = 0;
            customComboBoxSeat.SelectedIndex = 0;
        }

        private void WhenTicketCountLessOne()
        {
            MessageBox.Show("Sorry, the tickets have run out.", "Ticket Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private IEnumerable<Session> GetFutureSessionsForFilm(Film film)
        {
            try
            {
                return DataBase.SessionCollection
                                     .Where(item => item.FilmId == film.Id && item.Date > DateTime.Now)
                                     .OrderBy(item => item.Date).Where(item => GetAvalibleTickets(item).Count > 0);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        private List<int> GetAvalibleTickets(Session session)
        {
            List<int> tickets = new List<int>();
            var OrderedTickets = DataBase.TicketCollection.Where(item => item.SessionId == session.Id && item.State != TicketState.Returned);
            for (int i = 1; i <= session.TicketCount; i++)
            {
                if (!OrderedTickets.Any(item => item.Place == i))
                    tickets.Add(i);
            }
            return tickets;
        }

        private void OnFilmChange(Film film)
        {
            customComboBoxLocation.Items.Clear();
            customComboBoxTime.Items.Clear();
            customComboBoxSeat.Items.Clear();

            labelFilmTitle.Text = film.Title;
            if (Session != null)
                return;
            List<Session> sessions = GetFutureSessionsForFilm(film).ToList();
            Sessions = sessions;
            if (sessions == null || sessions.Count < 1)
            {
                WhenTicketCountLessOne();
                goBack();
                return;
            }
            foreach (Session session in sessions)
            {
                customComboBoxLocation.Items.Add(session.Address);
            }
            customComboBoxLocation.SelectedIndex = 0;
        }



        private void goBack()
        {
            this.Hide();
            Panel? parentPanel = (Panel?)this.Parent;
            if (parentPanel != null)
            {
                parentPanel.Controls.Remove(this);
                parentPanel.Controls[parentPanel.Controls.Count - 1].Show();
            }
            this.DestroyHandle();
        }

        private void customRoundedButtonGoBack_Click(object sender, EventArgs e)
        {
            goBack();
        }

        private void customComboBoxAge_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (Sessions == null)
                return;
            List<Session> sessions = Sessions.ToList();
            string currentLocation = customComboBoxLocation.SelectedItem as string ?? "";
            DateTime currentDate = Convert.ToDateTime(customComboBoxTime.SelectedItem ?? DateTime.Now); ;
            int currentSeat = Convert.ToInt32(customComboBoxSeat.SelectedItem ?? 0);
            foreach (Session session in sessions)
            {
                if (GetAvalibleTickets(session).Any(item => item == currentSeat) && session.Address == currentLocation && session.Date.ToString(DateTimeStringFormat) == currentDate.ToString(DateTimeStringFormat))
                {
                    labelPrice.Text = session.DefaultTicketPrice.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                    return;
                }
            }
            WhenTicketCountLessOne();
        }

        private void customComboBoxGenre_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (Sessions == null)
                return;
            List<Session> sessions = Sessions.ToList();
            string currentLocation = customComboBoxLocation.SelectedItem as string ?? "";
            DateTime currentDate = Convert.ToDateTime(customComboBoxTime.SelectedItem ?? DateTime.Now);
            customComboBoxSeat.Items.Clear();
            bool isTicketRunOut = true;
            foreach (Session session in sessions)
            {
                if (session.Address == currentLocation && session.Date.ToString(DateTimeStringFormat) == currentDate.ToString(DateTimeStringFormat))
                {
                    List<int> countTickets = GetAvalibleTickets(session);
                    if (countTickets.Count < 1)
                    {
                        continue;
                    }
                    isTicketRunOut = false;
                    customComboBoxSeat.Items.AddRange(countTickets.Cast<object>().ToArray());
                }
            }
            if (isTicketRunOut)
            {
                WhenTicketCountLessOne();
                return;
            }
            customComboBoxSeat.SelectedIndex = 0;
        }

        private void customComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (Sessions == null)
                return;
            List<Session> sessions = Sessions.ToList();
            string currentLocation = customComboBoxLocation.SelectedItem as string ?? "";
            customComboBoxTime.Items.Clear();
            foreach (Session session in sessions)
            {
                if (session.Address == currentLocation)
                {
                    customComboBoxTime.Items.Add(session.Date.ToString(DateTimeStringFormat));
                }
            }
            customComboBoxTime.SelectedIndex = 0;
        }

        private void roundedButtonSave_Click(object sender, EventArgs e)
        {
            var user = AccountHandler.Instance.User;
            bool result = false;
            string sessionId = "";
            int seatNumber = (int)customComboBoxSeat.SelectedItem;
            double ticketPrice = 0;
            if (Session != null)
            {
                sessionId = Session.Id;
                ticketPrice = Session.DefaultTicketPrice;
            }
            else
            {
                if (Sessions == null)
                    return;
                List<Session> sessions = Sessions.ToList();
                string currentLocation = customComboBoxLocation.SelectedItem as string ?? "";
                DateTime currentDate = Convert.ToDateTime(customComboBoxTime.SelectedItem ?? DateTime.Now); ;
                int currentSeat = Convert.ToInt32(customComboBoxSeat.SelectedItem ?? 0);
                foreach (Session session in sessions)
                {
                    if (GetAvalibleTickets(session).Any(item => item == currentSeat) && session.Address == currentLocation && session.Date.ToString(DateTimeStringFormat) == currentDate.ToString(DateTimeStringFormat))
                    {
                        sessionId = session.Id;
                        ticketPrice = session.DefaultTicketPrice;
                        break;
                    }
                }
            }

            if (sessionId == "")
            {
                MessageBox.Show("Sorry, the tickets have run out.", "Ticket Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (user is Admin admin)
                {
                    result = admin.buyTicket(sessionId, seatNumber, ticketPrice);
                }
                else if (user is Customer customer)
                {
                    result = customer.buyTicket(sessionId, seatNumber, ticketPrice);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            if (result)
            {
                MessageBox.Show("Ticket bought! Thank you for your purchase.", "Ticket Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Session != null)
                OnSessionChange(Session);
            else
                if (Film != null)
                OnFilmChange(Film);
        }


    }
}
