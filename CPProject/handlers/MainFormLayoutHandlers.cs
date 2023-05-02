using CPProject.Controls;
using CPProject.Controls.NavigationBars;
using CPProject.DataBaseModel.types;
using CPProject.User;

namespace CPProject.handlers
{
    public static class MainFormLayoutHandlers
    {
        static Panel? NavBarPanel { get; set; }
        static Panel? PagePanel { get; set; }
        public static void OnAuthorization(Panel navBarPanel, Panel pagePanel)
        {
            NavBarPanel = navBarPanel;
            PagePanel = pagePanel;
            if (AccountHandler.Instance.User == null)
            {
                navBarPanel.Controls.Clear();
                navBarPanel.Controls.Add(new NBAuthorization(pagePanel));
                return;
            }
            if (AccountHandler.Instance.User.UserType == UserType.Customer)
            {
                navBarPanel.Controls.Clear();
                navBarPanel.Controls.Add(new NBCustomer(pagePanel));
                return;
            }
            if (AccountHandler.Instance.User.UserType == UserType.Admin)
            {
                navBarPanel.Controls.Clear();
                navBarPanel.Controls.Add(new NBAdmin(pagePanel));
                return;
            }
        }
    }
}
