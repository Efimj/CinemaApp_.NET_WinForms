using CPProject.DataBaseModel;
using CPProject.DataBaseModel.entities;
using CPProject.imageHandler;

namespace CPProject.controls
{
    public partial class TicketDetailsPage : UserControl
    {
        private Ticket ticket;
        private static CinemaDataBase? DBInstance = null;
        private readonly string DateTimeStringFormat = "dd.MM.yyyy HH:mm";
        private readonly string DateStringFormat = "dd.MM.yyyy";

        private Ticket Ticket { get => ticket; set { ticket = value; OnTicketChange(); } }
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
        public TicketDetailsPage(Ticket ticekt)
        {
            InitializeComponent();
            Ticket = ticekt;
        }

        private Session? GetSessionByTicket(Ticket ticket)
        {

            if (ticket == null)
                return null;
            Session? session = DataBase.SessionCollection.Find(item => item.Id == ticket.SessionId);
            if (session == null)
                return null;
            return session;
        }

        private Film? GetFilmByTicket(Ticket ticket)
        {
            Session? session = GetSessionByTicket(ticket);
            if (session == null)
                return null;
            Film? film = DataBase.FilmCollection.Find(item => item.Id == session.FilmId);
            if (film == null)
                return null;
            return film;
        }

        private void OnTicketChange()
        {
            Film? film = GetFilmByTicket(Ticket);
            Session? session = GetSessionByTicket(ticket);
            DataBaseModel.entities.User? user = DataBase.UserCollection.Find(item => item.Id == Ticket.UserId);
            if (film == null || session == null || user == null)
                return;
            pictureBoxFilmImage.SizeMode = PictureBoxSizeMode.StretchImage;
            ImageHandler.LoadImageToPictureBox(
                $"{image_path.Default.FilmPreviewFolder}{film.PhotoName}",
                pictureBoxFilmImage,
                Properties.Resources.image_error);
            labelFilmTitle.Text = film.Title;
            labelPurchaseDate.Text = Ticket.PurchaseDate.ToString(DateStringFormat);
            labelTicketId.Text = ticket.Id;
            labelAccountLogin.Text = user.Login;
            labelSessionAddress.Text = session.Address;
            labelSessionDate.Text = session.Date.ToString(DateTimeStringFormat);
            labelTicketSeat.Text = ticket.Place.ToString();
            labelTicketState.Text = ticket.State.ToString();
            labelTicketPrice.Text = ticket.Price.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("en-US")); ;
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

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Ticket.Id);
        }
    }
}
