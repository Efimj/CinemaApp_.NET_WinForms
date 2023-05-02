namespace CPProject
{
    public partial class InputLableIndicated : UserControl
    {
#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public InputLableIndicated()
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        {
            InitializeComponent();
        }

        public string? LableText
        {
            get => label.Text;
            set => label.Text = value;
        }
        public string TextBoxText
        {
            get => customInput1.Text;
            set => customInput1.Text = value;
        }
        public bool IsInvalid
        {
            get => customInput1.IsInvalid;
            set => customInput1.IsInvalid = value;
        }

        public string Placeholder
        {
            get => customInput1.Placeholder;
            set => customInput1.Placeholder = value;
        }

        public event EventHandler OnChangeTex;

        private void customInput1_CustomInputChanged(object sender, EventArgs e)
        {
            OnChangeTex?.Invoke(this, e);
        }
    }
}
