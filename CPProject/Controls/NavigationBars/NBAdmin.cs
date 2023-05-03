using CPProject.components.ui;
using CPProject.controls.Pages;
using CPProject.Controls.Pages;
using CPProject.User;

namespace CPProject.Controls.NavigationBars
{
    public partial class NBAdmin : UserControl
    {
        // default images
        private static Image FilmImageDefault = Properties.Resources.films_icon_black;
        private static Image TicketImageDefault = Properties.Resources.ticket_black;
        private static Image SessionImageDefault = Properties.Resources.session_black;
        private static Image BanImageDefault = Properties.Resources.warn_black;
        private static Image AccountImageDefault = Properties.Resources.account_black;
        // active images
        private static Image FilmImageActive = Properties.Resources.films_icon_white;
        private static Image TicketImageActive = Properties.Resources.ticket_white;
        private static Image SessionImageActive = Properties.Resources.session_white;
        private static Image BanImageActive = Properties.Resources.warn_white;
        private static Image AccountImageActive = Properties.Resources.account_white;

        public NBAdmin(Panel pagePanel)
        {
            InitializeComponent();
            pagePanel.Controls.Clear();
            pagePanel.Controls.Add(new SearchFilmList());
            this.pagePanel = pagePanel;
            setButtonActive(roundedButtonFilms, FilmImageActive, FilmImageDefault);
        }

        private Panel pagePanel;
        private Image? lastButtonImage = null;
        private RoundedButton? lastButtonActivated;
        private void setButtonActive(RoundedButton nextButton, Image activeImage, Image defaultImage)
        {
            if (lastButtonActivated != null && lastButtonImage != null)
            {
                lastButtonActivated.ForeColor = Color.Black;
                lastButtonActivated.BackColor = Color.White;
                lastButtonActivated.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                lastButtonActivated.Image = lastButtonImage;
            }
            nextButton.ForeColor = Color.White;
            nextButton.BackColor = Color.MediumSlateBlue;
            nextButton.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            nextButton.Image = activeImage;
            lastButtonActivated = nextButton;
            lastButtonImage = defaultImage;
        }

        private void NBAdmin_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            labelName.Text = AccountHandler.Instance?.User?.Login;
        }

        private void goOnTopMost()
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                Application.OpenForms[i].TopMost = true;
            }
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure to log out?",
            "Message",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                AccountHandler.Instance.logOut();
            }
            goOnTopMost();
        }

        private void roundedButtonFilms_Click_1(object sender, EventArgs e)
        {
            setButtonActive(roundedButtonFilms, FilmImageActive, FilmImageDefault);
            pagePanel.Controls.Clear();
            pagePanel.Controls.Add(new SearchFilmList());
        }

        private void roundedButtonFutureSessions_Click(object sender, EventArgs e)
        {
            setButtonActive((RoundedButton)sender, SessionImageActive, SessionImageDefault);
            pagePanel.Controls.Clear();
            pagePanel.Controls.Add(new SessionPage());
        }

        private void roundedButton5_Click(object sender, EventArgs e)
        {
            setButtonActive((RoundedButton)sender, AccountImageActive, AccountImageDefault);
            pagePanel.Controls.Clear();
            pagePanel.Controls.Add(new AccountSettingsPage());
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            setButtonActive((RoundedButton)sender, TicketImageActive, TicketImageDefault);
            pagePanel.Controls.Clear();
            pagePanel.Controls.Add(new MyTicketPage());
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            setButtonActive((RoundedButton)sender, BanImageActive, BanImageDefault);
            pagePanel.Controls.Clear();
        }
    }
}
