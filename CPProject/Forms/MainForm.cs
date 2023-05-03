using CPProject.DataBaseModel;
using CPProject.DataBaseModel.entities;
using CPProject.handlers;
using CPProject.helpers;
using CPProject.User;
using System.ComponentModel;

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
            DBhelpers dBhelpers = new DBhelpers();
            bool isUserBlocked = dBhelpers.CheckIsUserBlocked(user.Id);
            int countUnblockedUser = dBhelpers.UnblockUserByTime();
            bool isUserBlockedNow = dBhelpers.CheckIsUserBlocked(user.Id);
            if (isUserBlocked && !isUserBlockedNow)
                MessageBox.Show("You have been unblicked!", "Account information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                BlockedUser? blockedUser = CinemaDataBase.Instance.BlockedUserCollection.Find(item => item.UserId == user.Id);
                if (blockedUser == null)
                    return;
                DateTime endingBlockDate = blockedUser.AppointmentDate.AddMinutes((int)blockedUser.BlockDuration);
                MessageBox.Show($"You are blocked!\nReason: {blockedUser.BlockReason}\nEnding: {endingBlockDate}", "Account information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
