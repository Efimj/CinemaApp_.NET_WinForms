namespace CPProject.Forms
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            inputRepeatePassword = new components.ui.RoundedSearchField();
            tableLayoutPanel4 = new TableLayoutPanel();
            roundedPanel10 = new components.ui.RoundedPanel();
            roundedPanel11 = new components.ui.RoundedPanel();
            dateTimePickerAge = new DateTimePicker();
            label4 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            label8 = new Label();
            inputPassword = new components.ui.RoundedSearchField();
            labelError = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            inputLogin = new components.ui.RoundedSearchField();
            buttonRegistration = new components.ui.RoundedButton();
            label6 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label7 = new Label();
            roundedSearchField2 = new components.ui.RoundedSearchField();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            roundedPanel10.SuspendLayout();
            roundedPanel11.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 461);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tableLayoutPanel2.Controls.Add(inputRepeatePassword, 1, 6);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 8);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 1, 4);
            tableLayoutPanel2.Controls.Add(labelError, 1, 12);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 1, 2);
            tableLayoutPanel2.Controls.Add(buttonRegistration, 1, 10);
            tableLayoutPanel2.Controls.Add(label6, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 14;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 31.4106F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 68.5894F));
            tableLayoutPanel2.Size = new Size(220, 461);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // inputRepeatePassword
            // 
            inputRepeatePassword.BackColor = SystemColors.Window;
            inputRepeatePassword.BorderColor = Color.Silver;
            inputRepeatePassword.BorderFocusColor = Color.Silver;
            inputRepeatePassword.BorderRadius = 7;
            inputRepeatePassword.BorderSize = 1;
            inputRepeatePassword.Dock = DockStyle.Fill;
            inputRepeatePassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inputRepeatePassword.ForeColor = Color.FromArgb(64, 64, 64);
            inputRepeatePassword.Location = new Point(15, 224);
            inputRepeatePassword.Margin = new Padding(0);
            inputRepeatePassword.Multiline = false;
            inputRepeatePassword.Name = "inputRepeatePassword";
            inputRepeatePassword.Padding = new Padding(10, 10, 10, 7);
            inputRepeatePassword.PasswordChar = false;
            inputRepeatePassword.PlaceholderColor = Color.DarkGray;
            inputRepeatePassword.PlaceholderText = "repeat";
            inputRepeatePassword.Size = new Size(190, 39);
            inputRepeatePassword.TabIndex = 6;
            inputRepeatePassword.Texts = "";
            inputRepeatePassword.UnderlinedStyle = false;
            inputRepeatePassword._TextChanged += inputRepeatePassword_CustomInputChanged;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(roundedPanel10, 0, 1);
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(15, 270);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.Size = new Size(190, 71);
            tableLayoutPanel4.TabIndex = 10;
            // 
            // roundedPanel10
            // 
            roundedPanel10.Autofocus = false;
            roundedPanel10.BackColor = Color.White;
            roundedPanel10.BackgroundColor = Color.White;
            roundedPanel10.BorderColor = Color.Silver;
            roundedPanel10.BorderRadius = 7;
            roundedPanel10.BorderSize = 1;
            roundedPanel10.Controls.Add(roundedPanel11);
            roundedPanel10.FocusBorderColor = Color.Gray;
            roundedPanel10.FocusBorderSize = 2;
            roundedPanel10.ForeColor = Color.White;
            roundedPanel10.Location = new Point(0, 30);
            roundedPanel10.Margin = new Padding(0);
            roundedPanel10.Name = "roundedPanel10";
            roundedPanel10.Padding = new Padding(12, 5, 5, 5);
            roundedPanel10.Size = new Size(190, 39);
            roundedPanel10.TabIndex = 12;
            roundedPanel10.TextColor = Color.White;
            // 
            // roundedPanel11
            // 
            roundedPanel11.Autofocus = false;
            roundedPanel11.BackColor = Color.White;
            roundedPanel11.BackgroundColor = Color.White;
            roundedPanel11.BorderColor = Color.PaleVioletRed;
            roundedPanel11.BorderRadius = 7;
            roundedPanel11.BorderSize = 0;
            roundedPanel11.Controls.Add(dateTimePickerAge);
            roundedPanel11.FocusBorderColor = Color.Gray;
            roundedPanel11.FocusBorderSize = 2;
            roundedPanel11.ForeColor = Color.White;
            roundedPanel11.Location = new Point(12, 6);
            roundedPanel11.Margin = new Padding(0);
            roundedPanel11.Name = "roundedPanel11";
            roundedPanel11.Size = new Size(177, 27);
            roundedPanel11.TabIndex = 2;
            roundedPanel11.TextColor = Color.White;
            // 
            // dateTimePickerAge
            // 
            dateTimePickerAge.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerAge.CalendarForeColor = Color.Black;
            dateTimePickerAge.CalendarTitleForeColor = Color.Black;
            dateTimePickerAge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerAge.Format = DateTimePickerFormat.Short;
            dateTimePickerAge.Location = new Point(-3, -1);
            dateTimePickerAge.Name = "dateTimePickerAge";
            dateTimePickerAge.Size = new Size(182, 29);
            dateTimePickerAge.TabIndex = 2;
            dateTimePickerAge.ValueChanged += dateTimePickerAge_ValueChanged;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(190, 30);
            label4.TabIndex = 11;
            label4.Text = "Birthday";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.AutoSize = true;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel5.Controls.Add(label8, 0, 0);
            tableLayoutPanel5.Controls.Add(inputPassword, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(15, 148);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(190, 69);
            tableLayoutPanel5.TabIndex = 9;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(0, 0);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Size = new Size(190, 30);
            label8.TabIndex = 0;
            label8.Text = "Password";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inputPassword
            // 
            inputPassword.BackColor = SystemColors.Window;
            inputPassword.BorderColor = Color.Silver;
            inputPassword.BorderFocusColor = Color.Silver;
            inputPassword.BorderRadius = 7;
            inputPassword.BorderSize = 1;
            inputPassword.Dock = DockStyle.Top;
            inputPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inputPassword.ForeColor = Color.FromArgb(64, 64, 64);
            inputPassword.Location = new Point(0, 30);
            inputPassword.Margin = new Padding(0);
            inputPassword.Multiline = false;
            inputPassword.Name = "inputPassword";
            inputPassword.Padding = new Padding(10, 10, 10, 7);
            inputPassword.PasswordChar = false;
            inputPassword.PlaceholderColor = Color.DarkGray;
            inputPassword.PlaceholderText = "pass_12345";
            inputPassword.Size = new Size(190, 39);
            inputPassword.TabIndex = 1;
            inputPassword.Texts = "";
            inputPassword.UnderlinedStyle = false;
            inputPassword._TextChanged += inputPassword_OnChangeTex;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Dock = DockStyle.Top;
            labelError.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelError.ForeColor = Color.Tomato;
            labelError.Location = new Point(18, 401);
            labelError.Name = "labelError";
            labelError.Size = new Size(184, 17);
            labelError.TabIndex = 5;
            labelError.Text = "Error";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.Controls.Add(label5, 0, 0);
            tableLayoutPanel1.Controls.Add(inputLogin, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(15, 72);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(190, 69);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(0, 0);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(190, 30);
            label5.TabIndex = 0;
            label5.Text = "Login";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inputLogin
            // 
            inputLogin.BackColor = SystemColors.Window;
            inputLogin.BorderColor = Color.Silver;
            inputLogin.BorderFocusColor = Color.Silver;
            inputLogin.BorderRadius = 7;
            inputLogin.BorderSize = 1;
            inputLogin.Dock = DockStyle.Top;
            inputLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inputLogin.ForeColor = Color.FromArgb(64, 64, 64);
            inputLogin.Location = new Point(0, 30);
            inputLogin.Margin = new Padding(0);
            inputLogin.Multiline = false;
            inputLogin.Name = "inputLogin";
            inputLogin.Padding = new Padding(10, 10, 10, 7);
            inputLogin.PasswordChar = false;
            inputLogin.PlaceholderColor = Color.DarkGray;
            inputLogin.PlaceholderText = "example_login";
            inputLogin.Size = new Size(190, 39);
            inputLogin.TabIndex = 1;
            inputLogin.Texts = "";
            inputLogin.UnderlinedStyle = false;
            inputLogin._TextChanged += inputLogin_OnChangeTex;
            // 
            // buttonRegistration
            // 
            buttonRegistration.Autofocus = false;
            buttonRegistration.BackColor = Color.MediumSlateBlue;
            buttonRegistration.BackgroundColor = Color.MediumSlateBlue;
            buttonRegistration.BorderColor = Color.Silver;
            buttonRegistration.BorderRadius = 7;
            buttonRegistration.BorderSize = 1;
            buttonRegistration.Dock = DockStyle.Fill;
            buttonRegistration.FlatAppearance.BorderSize = 0;
            buttonRegistration.FlatStyle = FlatStyle.Flat;
            buttonRegistration.FocusBorderColor = Color.Gray;
            buttonRegistration.FocusBorderSize = 2;
            buttonRegistration.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegistration.ForeColor = Color.White;
            buttonRegistration.Location = new Point(15, 356);
            buttonRegistration.Margin = new Padding(0);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(190, 40);
            buttonRegistration.TabIndex = 8;
            buttonRegistration.Text = "Signin";
            buttonRegistration.TextColor = Color.White;
            buttonRegistration.UseVisualStyleBackColor = false;
            buttonRegistration.Click += buttonRegistration_Click_1;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(15, 19);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(190, 53);
            label6.TabIndex = 2;
            label6.Text = "Registration";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel3.Controls.Add(label7, 0, 0);
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(0, 0);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(200, 20);
            label7.TabIndex = 10;
            label7.Text = "Login";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // roundedSearchField2
            // 
            roundedSearchField2.BackColor = SystemColors.Window;
            roundedSearchField2.BorderColor = Color.Silver;
            roundedSearchField2.BorderFocusColor = Color.Silver;
            roundedSearchField2.BorderRadius = 7;
            roundedSearchField2.BorderSize = 1;
            roundedSearchField2.Dock = DockStyle.Top;
            roundedSearchField2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roundedSearchField2.ForeColor = Color.FromArgb(64, 64, 64);
            roundedSearchField2.Location = new Point(0, 30);
            roundedSearchField2.Margin = new Padding(0);
            roundedSearchField2.Multiline = false;
            roundedSearchField2.Name = "roundedSearchField2";
            roundedSearchField2.Padding = new Padding(10, 10, 10, 7);
            roundedSearchField2.PasswordChar = false;
            roundedSearchField2.PlaceholderColor = Color.DarkGray;
            roundedSearchField2.PlaceholderText = "example_login";
            roundedSearchField2.Size = new Size(200, 39);
            roundedSearchField2.TabIndex = 1;
            roundedSearchField2.Texts = "";
            roundedSearchField2.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.PanelBackground;
            pictureBox1.Location = new Point(220, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(564, 461);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(784, 461);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RegistrationForm";
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            roundedPanel10.ResumeLayout(false);
            roundedPanel11.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label7;
        private components.ui.RoundedSearchField roundedSearchField2;
        private Label label6;
        private components.ui.RoundedButton buttonRegistration;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private components.ui.RoundedSearchField inputLogin;
        private Label labelError;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label8;
        private components.ui.RoundedSearchField inputPassword;
        private TableLayoutPanel tableLayoutPanel4;
        private components.ui.RoundedPanel roundedPanel10;
        private components.ui.RoundedPanel roundedPanel11;
        private DateTimePicker dateTimePickerAge;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private components.ui.RoundedSearchField inputRepeatePassword;
        private PictureBox pictureBox1;
    }
}