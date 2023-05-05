using CPProject.components.ui;
using CPProject.DataBaseModel;

namespace CPProject.controls.Pages
{
    public partial class UserListPage : UserControl
    {
        private static CinemaDataBase? DBInstance = null;
        private RoundedButton? lastButtonActivated;
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
        public UserListPage()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            setButtonActive((RoundedButton)roundedButtonBlocked);
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

        private void roundedButtonBlocked_Click(object sender, EventArgs e)
        {
            setButtonActive((RoundedButton)sender);
        }

        private void roundedButtonAll_Click(object sender, EventArgs e)
        {
            setButtonActive((RoundedButton)sender);
        }
    }
}
