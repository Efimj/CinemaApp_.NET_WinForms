﻿using CPProject.components.ui;
using CPProject.controls.Pages;
using CPProject.Controls;
using CPProject.Controls.Pages;
using CPProject.Forms;

namespace CPProject
{
    public partial class NBAuthorization : UserControl
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
        public NBAuthorization(Panel pagePanel)
        {
            InitializeComponent();
            this.pagePanel = pagePanel;
            pagePanel.Controls.Clear();
            pagePanel.Controls.Add(new SearchFilmList());
            setButtonActive(roundedButtonFilms, FilmImageActive, FilmImageDefault);
            this.Dock = DockStyle.Fill;
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

        private void AppNavBar_Load(object sender, EventArgs e)
        {
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            new AuthorizationForm().ShowDialog(this);
        }

        private void roundedButton5_Click(object sender, EventArgs e)
        {
            new RegistrationForm().ShowDialog(this);
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            setButtonActive(roundedButtonFilms, FilmImageActive, FilmImageDefault);
            pagePanel.Controls.Clear();
            pagePanel.Controls.Add(new SearchFilmList());
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            setButtonActive(roundedButtonFutureSessions, SessionImageActive, SessionImageDefault);
            pagePanel.Controls.Clear();
            pagePanel.Controls.Add(new SessionPage());
        }

        private void roundedButton1_Click_1(object sender, EventArgs e)
        {
            setButtonActive(roundedButtonFindTicket, TicketImageActive, TicketImageDefault);
            pagePanel.Controls.Clear();
            pagePanel.Controls.Add(new MyTicketPage());
        }
    }
}
