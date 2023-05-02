using CPProject.types;

namespace CPProject.components
{
    public partial class CustomInput : UserControl
    {
#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public CustomInput()
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        {
            InitializeComponent();
            panelIndicator.BackColor = ColorPalette.InputColor;
        }
        private bool isInvalid = false;
        public bool IsInvalid
        {
            get => isInvalid;
            set
            {
                isInvalid = value;
                if (value)
                {
                    panelIndicator.BackColor = ColorPalette.Orange;
                }
                else
                {
                    panelIndicator.BackColor = ColorPalette.InputColor;
                }
            }
        }
        public string Placeholder
        {
            get => textBox.PlaceholderText;
            set => textBox.PlaceholderText = value;
        }
        public new string Text
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }
        public event EventHandler CustomInputChanged;
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            CustomInputChanged?.Invoke(this, e);
        }
    }
}
