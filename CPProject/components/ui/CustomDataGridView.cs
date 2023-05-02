namespace CPProject.components.ui
{
    public partial class CustomDataGridView : DataGridView
    {
        public CustomDataGridView()
        {
            InitializeComponent();
            BackgroundColor = Color.White;
            RowHeadersVisible = false;
            RowTemplate.Height = 30;
        }
    }
}
