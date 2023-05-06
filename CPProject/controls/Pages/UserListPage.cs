using CPProject.components.ui;
using CPProject.DataBaseModel;
using System.Diagnostics;

namespace CPProject.controls.Pages
{
    public partial class UserListPage : UserControl
    {
        private enum UserListPageMode
        {
            All,
            Blocked,
        }

        private static CinemaDataBase? DBInstance = null;
        private RoundedButton? lastButtonActivated;
        private UserListPageMode currentUserListPageMode;
        private int? selectedRowIndex = null;
        private string searchUserLogin;

        private int? SelectedRowIndex
        {
            get => selectedRowIndex;
            set
            {
                selectedRowIndex = value;
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

        private UserListPageMode CurrentUserListPageMode { get => currentUserListPageMode; set { currentUserListPageMode = value; OnPageModeChanged(); } }
        private string SearchUserLogin { get => searchUserLogin; set { searchUserLogin = value; ClearDGV(); } }

        public UserListPage()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            DGVInitialize();
            setButtonActive((RoundedButton)roundedButtonAll);
            CurrentUserListPageMode = UserListPageMode.All;
        }

        private void DGVInitialize()
        {
            dataGridViewUsers.ForeColor = Color.Black;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void OnPageModeChanged()
        {
            ClearDGV();
        }

        private void ClearDGV()
        {
            dataGridViewUsers.Rows.Clear();
            dataGridViewUsers.RowCount = GetRowCount();
        }

        private int GetRowCount()
        {
            int? count = 0;
            switch (CurrentUserListPageMode)
            {
                case UserListPageMode.All:
                    count = GetAllUsersCount();
                    break;
                case UserListPageMode.Blocked:
                    count = GetBlockedUsersCount();
                    break;
            }
            return count == null ? 0 : (int)count;
        }

        private int GetAllUsersCount()
        {
            return GetUsers().Count();
        }

        private int GetBlockedUsersCount()
        {
            return GetBlockedUsers().Count();
        }

        private IEnumerable<DataBaseModel.entities.User> GetUsers()
        {
            if (string.IsNullOrEmpty(SearchUserLogin))
                return DataBase.UserCollection;
            else
                return DataBase.UserCollection.Where(item => item.Login.Contains(SearchUserLogin, StringComparison.OrdinalIgnoreCase));
        }

        private IEnumerable<DataBaseModel.entities.User> GetBlockedUsers()
        {
            if (string.IsNullOrEmpty(SearchUserLogin))
                return DataBase.UserCollection.Where(user => DataBase.BlockedUserCollection.Any(blockeduser => blockeduser.UserId == user.Id));
            else
                return DataBase.UserCollection.Where(user => user.Login.Contains(SearchUserLogin, StringComparison.OrdinalIgnoreCase) && DataBase.BlockedUserCollection.Any(blockeduser => blockeduser.UserId == user.Id));
        }

        private DataBaseModel.entities.User? GetUser(int index)
        {
            switch (CurrentUserListPageMode)
            {
                case UserListPageMode.All:
                    return GetUsers().ElementAt(index);
                case UserListPageMode.Blocked:
                    return GetBlockedUsers().ElementAt(index);
            }
            return null;
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
            CurrentUserListPageMode = UserListPageMode.Blocked;
        }

        private void roundedButtonAll_Click(object sender, EventArgs e)
        {
            setButtonActive((RoundedButton)sender);
            CurrentUserListPageMode = UserListPageMode.All;
        }

        private string GetUserLogin(int rowIndex)
        {
            DataBaseModel.entities.User? user = GetUser(rowIndex);
            if (user == null)
                return "";
            return user.Login;
        }

        private DateTime GetUserBirthday(int rowIndex)
        {
            DataBaseModel.entities.User? user = GetUser(rowIndex);
            if (user == null)
                return DateTime.Now;
            return user.BirthdayDate;
        }

        private int GetUserTicketCount(int rowIndex)
        {
            DataBaseModel.entities.User? user = GetUser(rowIndex);
            if (user == null)
                return 0;
            return DataBase.TicketCollection.Count(item => item.UserId == user.Id);
        }

        private int GetUserReviewCount(int rowIndex)
        {
            DataBaseModel.entities.User? user = GetUser(rowIndex);
            if (user == null)
                return 0;
            return DataBase.ReviewCollection.Count(item => item.UserId == user.Id);
        }

        private string GetUserStatus(int rowIndex)
        {
            DataBaseModel.entities.User? user = GetUser(rowIndex);
            if (user == null)
                return "";
            bool isblockedUser = DataBase.BlockedUserCollection.Any(item => item.UserId == user.Id);
            return isblockedUser ? "blocked" : "active";
        }

        private double GetUserMoney(int rowIndex)
        {
            DataBaseModel.entities.User? user = GetUser(rowIndex);
            if (user == null)
                return 0;
            return DataBase.TicketCollection.Where(item => item.UserId == user.Id).Sum(item => (double)item.Price);
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
                        e.Value = GetUserLogin(rowIndex);
                        break;
                    case 1:
                        e.Value = GetUserBirthday(rowIndex).ToString("dd.MM.yyyy");
                        break;
                    case 2:
                        e.Value = GetUserTicketCount(rowIndex);
                        break;
                    case 3:
                        e.Value = GetUserReviewCount(rowIndex);
                        break;
                    case 4:
                        e.Value = GetUserStatus(rowIndex);
                        break;
                    case 5:
                        e.Value = GetUserMoney(rowIndex).ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
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

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedRowIndex = e.RowIndex;
            }
        }

        private void roundedSearchFieldLogin__TextChanged(object sender, EventArgs e)
        {
            SearchUserLogin = roundedSearchFieldLogin.Texts.Trim();
        }
    }
}
