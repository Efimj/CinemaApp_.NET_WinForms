namespace CPProject.components
{
    public partial class SearchTicketInput : UserControl
    {
        public SearchTicketInput()
        {
            InitializeComponent();
            maskedTextBox1.PromptChar = 'X';
            maskedTextBox1.Mask = "AAAAAA-AAAAAA-AAAAAA-AAAAAA";
        }
    }
}
