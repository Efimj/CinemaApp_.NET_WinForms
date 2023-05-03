using CPProject.DataBaseModel;
using CPProject.DataBaseModel.entities;
using CPProject.DataBaseModel.types;
using CPProject.handlers;
using CPProject.helpers;
using CPProject.User;
using System.Diagnostics;

namespace CPProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            panelNavigation.Controls.Add(new NBAuthorization(panelPage));
            initApp();
        }
        private void initApp()
        {
            DataBaseModel.CinemaDataBase.Instance.LoadDBData();
            AccountHandler.Instance.OnUserChange += OnUserChange;
            AccountHandler.Instance.loadSavedUser();

        }

        private void OnUserChange(DataBaseModel.entities.User? user)
        {
            MainFormLayoutHandlers.OnAuthorization(panelNavigation, panelPage);
            CheckUserBlock(user);
        }

        private static void CheckUserBlock(DataBaseModel.entities.User? user)
        {
            if (user == null)
                return;
            AccountHelpers dBhelpers = new AccountHelpers();
            bool isUserBlocked = dBhelpers.CheckIsUserBlocked(user.Id);
            int countUnblockedUser = dBhelpers.UnblockUserByTime();
            bool isUserBlockedNow = dBhelpers.CheckIsUserBlocked(user.Id);
            if (isUserBlocked && !isUserBlockedNow)
                MessageBox.Show("You have been unblocked!", "Account information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                BlockedUser? blockedUser = CinemaDataBase.Instance.BlockedUserCollection.Find(item => item.UserId == user.Id);
                if (blockedUser == null)
                    return;
                int blockedMinutes = (int)(BlockDurationType)Enum.GetValues(typeof(BlockDurationType)).GetValue((int)blockedUser.BlockDuration);
                Debug.WriteLine(blockedMinutes);
                DateTime endingBlockDate = blockedUser.AppointmentDate.AddMinutes(blockedMinutes);
                MessageBox.Show($"You are blocked!\n\nReason: {blockedUser.BlockReason}\nEnding: {endingBlockDate}\n\n Your reviews will be hidden for the duration of the ban/", "Account information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
