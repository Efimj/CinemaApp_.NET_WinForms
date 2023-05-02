using CPProject.handlers;
using CPProject.User;

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
            AccountHandler.Instance.OnUserChange += (DataBaseModel.entities.User? s) =>
            {
                MainFormLayoutHandlers.OnAuthorization(panelNavigation, panelPage);
            };
            AccountHandler.Instance.loadSavedUser();
        }
    }
}
