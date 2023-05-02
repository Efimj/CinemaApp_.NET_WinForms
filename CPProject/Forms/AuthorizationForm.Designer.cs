namespace CPProject.Forms
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label4 = new Label();
            roundedFieldPassword = new components.ui.RoundedSearchField();
            labelError = new Label();
            checkBoxRemember = new CheckBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            roundedFieldLogin = new components.ui.RoundedSearchField();
            roundedButton1 = new components.ui.RoundedButton();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label3 = new Label();
            roundedSearchField2 = new components.ui.RoundedSearchField();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
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
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 4);
            tableLayoutPanel2.Controls.Add(labelError, 1, 10);
            tableLayoutPanel2.Controls.Add(checkBoxRemember, 1, 6);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 1, 2);
            tableLayoutPanel2.Controls.Add(roundedButton1, 1, 8);
            tableLayoutPanel2.Controls.Add(label1, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 12;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 38.26855F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 61.73144F));
            tableLayoutPanel2.Size = new Size(220, 461);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Controls.Add(roundedFieldPassword, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(15, 186);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(190, 69);
            tableLayoutPanel4.TabIndex = 7;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(190, 30);
            label4.TabIndex = 0;
            label4.Text = "Password";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // roundedFieldPassword
            // 
            roundedFieldPassword.BackColor = SystemColors.Window;
            roundedFieldPassword.BorderColor = Color.Silver;
            roundedFieldPassword.BorderFocusColor = Color.Silver;
            roundedFieldPassword.BorderRadius = 7;
            roundedFieldPassword.BorderSize = 1;
            roundedFieldPassword.Dock = DockStyle.Top;
            roundedFieldPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roundedFieldPassword.ForeColor = Color.FromArgb(64, 64, 64);
            roundedFieldPassword.Location = new Point(0, 30);
            roundedFieldPassword.Margin = new Padding(0);
            roundedFieldPassword.Multiline = false;
            roundedFieldPassword.Name = "roundedFieldPassword";
            roundedFieldPassword.Padding = new Padding(10, 10, 10, 7);
            roundedFieldPassword.PasswordChar = false;
            roundedFieldPassword.PlaceholderColor = Color.DarkGray;
            roundedFieldPassword.PlaceholderText = "pass_123";
            roundedFieldPassword.Size = new Size(190, 39);
            roundedFieldPassword.TabIndex = 1;
            roundedFieldPassword.Texts = "";
            roundedFieldPassword.UnderlinedStyle = false;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Dock = DockStyle.Top;
            labelError.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelError.ForeColor = Color.Tomato;
            labelError.Location = new Point(18, 350);
            labelError.Name = "labelError";
            labelError.Size = new Size(184, 17);
            labelError.TabIndex = 5;
            labelError.Text = "Error";
            // 
            // checkBoxRemember
            // 
            checkBoxRemember.AutoSize = true;
            checkBoxRemember.Dock = DockStyle.Fill;
            checkBoxRemember.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxRemember.ForeColor = Color.FromArgb(64, 64, 64);
            checkBoxRemember.Location = new Point(15, 262);
            checkBoxRemember.Margin = new Padding(0);
            checkBoxRemember.Name = "checkBoxRemember";
            checkBoxRemember.Padding = new Padding(2, 7, 0, 0);
            checkBoxRemember.Size = new Size(190, 28);
            checkBoxRemember.TabIndex = 5;
            checkBoxRemember.Text = "Remember me";
            checkBoxRemember.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(roundedFieldLogin, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(15, 110);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(190, 69);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(190, 30);
            label2.TabIndex = 0;
            label2.Text = "Login";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // roundedFieldLogin
            // 
            roundedFieldLogin.BackColor = SystemColors.Window;
            roundedFieldLogin.BorderColor = Color.Silver;
            roundedFieldLogin.BorderFocusColor = Color.Silver;
            roundedFieldLogin.BorderRadius = 7;
            roundedFieldLogin.BorderSize = 1;
            roundedFieldLogin.Dock = DockStyle.Top;
            roundedFieldLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roundedFieldLogin.ForeColor = Color.FromArgb(64, 64, 64);
            roundedFieldLogin.Location = new Point(0, 30);
            roundedFieldLogin.Margin = new Padding(0);
            roundedFieldLogin.Multiline = false;
            roundedFieldLogin.Name = "roundedFieldLogin";
            roundedFieldLogin.Padding = new Padding(10, 10, 10, 7);
            roundedFieldLogin.PasswordChar = false;
            roundedFieldLogin.PlaceholderColor = Color.DarkGray;
            roundedFieldLogin.PlaceholderText = "example_login";
            roundedFieldLogin.Size = new Size(190, 39);
            roundedFieldLogin.TabIndex = 1;
            roundedFieldLogin.Texts = "";
            roundedFieldLogin.UnderlinedStyle = false;
            roundedFieldLogin._TextChanged += roundedSearchField1__TextChanged;
            // 
            // roundedButton1
            // 
            roundedButton1.Autofocus = false;
            roundedButton1.BackColor = Color.MediumSlateBlue;
            roundedButton1.BackgroundColor = Color.MediumSlateBlue;
            roundedButton1.BorderColor = Color.White;
            roundedButton1.BorderRadius = 7;
            roundedButton1.BorderSize = 0;
            roundedButton1.Dock = DockStyle.Fill;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.FocusBorderColor = Color.Gray;
            roundedButton1.FocusBorderSize = 2;
            roundedButton1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(15, 305);
            roundedButton1.Margin = new Padding(0);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(190, 40);
            roundedButton1.TabIndex = 8;
            roundedButton1.Text = "login";
            roundedButton1.TextColor = Color.White;
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 57);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(190, 53);
            label1.TabIndex = 2;
            label1.Text = "Authorization";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(220, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(564, 461);
            panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.PanelBackground;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.ErrorImage = null;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(564, 461);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(200, 20);
            label3.TabIndex = 0;
            label3.Text = "Login";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // roundedSearchField2
            // 
            roundedSearchField2.BackColor = SystemColors.Window;
            roundedSearchField2.BorderColor = Color.FromArgb(224, 224, 224);
            roundedSearchField2.BorderFocusColor = Color.FromArgb(224, 224, 224);
            roundedSearchField2.BorderRadius = 5;
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
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(784, 461);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "AuthorizationForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AuthorizationForm";
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label1;
        private CheckBox checkBoxRemember;
        private Label labelError;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private components.ui.RoundedSearchField roundedFieldLogin;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private components.ui.RoundedSearchField roundedSearchField2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label4;
        private components.ui.RoundedSearchField roundedFieldPassword;
        private components.ui.RoundedButton roundedButton1;
    }
}