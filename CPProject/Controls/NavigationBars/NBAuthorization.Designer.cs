namespace CPProject
{
    partial class NBAuthorization
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            roundedPanel1 = new components.ui.RoundedPanel();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            roundedButton5 = new components.ui.RoundedButton();
            roundedButton4 = new components.ui.RoundedButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            roundedButtonFindTicket = new components.ui.RoundedButton();
            roundedButtonFutureSessions = new components.ui.RoundedButton();
            roundedButtonFilms = new components.ui.RoundedButton();
            label2 = new Label();
            roundedPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.Autofocus = false;
            roundedPanel1.AutoSize = true;
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BackgroundColor = Color.White;
            roundedPanel1.BorderColor = Color.FromArgb(224, 224, 224);
            roundedPanel1.BorderRadius = 12;
            roundedPanel1.BorderSize = 1;
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Controls.Add(tableLayoutPanel3);
            roundedPanel1.Controls.Add(tableLayoutPanel2);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Dock = DockStyle.Fill;
            roundedPanel1.FocusBorderColor = Color.Gray;
            roundedPanel1.FocusBorderSize = 2;
            roundedPanel1.ForeColor = Color.White;
            roundedPanel1.Location = new Point(2, 0);
            roundedPanel1.Margin = new Padding(0);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Padding = new Padding(2, 10, 2, 10);
            roundedPanel1.Size = new Size(197, 591);
            roundedPanel1.TabIndex = 9;
            roundedPanel1.TextColor = Color.White;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(2, 516);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(5, 0, 0, 5);
            label1.Size = new Size(193, 30);
            label1.TabIndex = 13;
            label1.Text = "Authorization";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(roundedButton5, 2, 0);
            tableLayoutPanel3.Controls.Add(roundedButton4, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Bottom;
            tableLayoutPanel3.Location = new Point(2, 546);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(5, 0, 5, 0);
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(193, 35);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // roundedButton5
            // 
            roundedButton5.Autofocus = false;
            roundedButton5.BackColor = Color.White;
            roundedButton5.BackgroundColor = Color.White;
            roundedButton5.BorderColor = Color.PaleVioletRed;
            roundedButton5.BorderRadius = 5;
            roundedButton5.BorderSize = 0;
            roundedButton5.Dock = DockStyle.Fill;
            roundedButton5.FlatAppearance.BorderSize = 0;
            roundedButton5.FlatStyle = FlatStyle.Flat;
            roundedButton5.FocusBorderColor = Color.Gray;
            roundedButton5.FocusBorderSize = 2;
            roundedButton5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roundedButton5.ForeColor = Color.Black;
            roundedButton5.ImageAlign = ContentAlignment.MiddleLeft;
            roundedButton5.Location = new Point(99, 0);
            roundedButton5.Margin = new Padding(0);
            roundedButton5.Name = "roundedButton5";
            roundedButton5.Size = new Size(89, 35);
            roundedButton5.TabIndex = 11;
            roundedButton5.Text = "Sign in";
            roundedButton5.TextColor = Color.Black;
            roundedButton5.UseVisualStyleBackColor = false;
            roundedButton5.Click += roundedButton5_Click;
            // 
            // roundedButton4
            // 
            roundedButton4.Autofocus = false;
            roundedButton4.BackColor = Color.White;
            roundedButton4.BackgroundColor = Color.White;
            roundedButton4.BorderColor = Color.PaleVioletRed;
            roundedButton4.BorderRadius = 5;
            roundedButton4.BorderSize = 0;
            roundedButton4.Dock = DockStyle.Fill;
            roundedButton4.FlatAppearance.BorderSize = 0;
            roundedButton4.FlatStyle = FlatStyle.Flat;
            roundedButton4.FocusBorderColor = Color.Gray;
            roundedButton4.FocusBorderSize = 2;
            roundedButton4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roundedButton4.ForeColor = Color.Black;
            roundedButton4.ImageAlign = ContentAlignment.MiddleLeft;
            roundedButton4.Location = new Point(5, 0);
            roundedButton4.Margin = new Padding(0);
            roundedButton4.Name = "roundedButton4";
            roundedButton4.Size = new Size(89, 35);
            roundedButton4.TabIndex = 11;
            roundedButton4.Text = "Log in";
            roundedButton4.TextColor = Color.Black;
            roundedButton4.UseVisualStyleBackColor = false;
            roundedButton4.Click += roundedButton4_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(roundedButtonFindTicket, 0, 4);
            tableLayoutPanel2.Controls.Add(roundedButtonFutureSessions, 0, 2);
            tableLayoutPanel2.Controls.Add(roundedButtonFilms, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(2, 72);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(5, 15, 5, 0);
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(193, 145);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // roundedButtonFindTicket
            // 
            roundedButtonFindTicket.Autofocus = false;
            roundedButtonFindTicket.BackColor = Color.White;
            roundedButtonFindTicket.BackgroundColor = Color.White;
            roundedButtonFindTicket.BorderColor = Color.PaleVioletRed;
            roundedButtonFindTicket.BorderRadius = 5;
            roundedButtonFindTicket.BorderSize = 0;
            roundedButtonFindTicket.Dock = DockStyle.Fill;
            roundedButtonFindTicket.FlatAppearance.BorderSize = 0;
            roundedButtonFindTicket.FlatStyle = FlatStyle.Flat;
            roundedButtonFindTicket.FocusBorderColor = Color.Gray;
            roundedButtonFindTicket.FocusBorderSize = 2;
            roundedButtonFindTicket.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roundedButtonFindTicket.ForeColor = Color.Black;
            roundedButtonFindTicket.Image = Properties.Resources.ticket_black;
            roundedButtonFindTicket.ImageAlign = ContentAlignment.MiddleLeft;
            roundedButtonFindTicket.Location = new Point(5, 105);
            roundedButtonFindTicket.Margin = new Padding(0);
            roundedButtonFindTicket.Name = "roundedButtonFindTicket";
            roundedButtonFindTicket.Padding = new Padding(20, 0, 0, 0);
            roundedButtonFindTicket.Size = new Size(183, 40);
            roundedButtonFindTicket.TabIndex = 14;
            roundedButtonFindTicket.Text = "FindTicket";
            roundedButtonFindTicket.TextAlign = ContentAlignment.MiddleLeft;
            roundedButtonFindTicket.TextColor = Color.Black;
            roundedButtonFindTicket.TextImageRelation = TextImageRelation.ImageBeforeText;
            roundedButtonFindTicket.UseVisualStyleBackColor = false;
            roundedButtonFindTicket.Click += roundedButton1_Click_1;
            // 
            // roundedButtonFutureSessions
            // 
            roundedButtonFutureSessions.Autofocus = false;
            roundedButtonFutureSessions.BackColor = Color.White;
            roundedButtonFutureSessions.BackgroundColor = Color.White;
            roundedButtonFutureSessions.BorderColor = Color.PaleVioletRed;
            roundedButtonFutureSessions.BorderRadius = 5;
            roundedButtonFutureSessions.BorderSize = 0;
            roundedButtonFutureSessions.Dock = DockStyle.Fill;
            roundedButtonFutureSessions.FlatAppearance.BorderSize = 0;
            roundedButtonFutureSessions.FlatStyle = FlatStyle.Flat;
            roundedButtonFutureSessions.FocusBorderColor = Color.Gray;
            roundedButtonFutureSessions.FocusBorderSize = 2;
            roundedButtonFutureSessions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roundedButtonFutureSessions.ForeColor = Color.Black;
            roundedButtonFutureSessions.Image = Properties.Resources.session_black;
            roundedButtonFutureSessions.ImageAlign = ContentAlignment.MiddleLeft;
            roundedButtonFutureSessions.Location = new Point(5, 60);
            roundedButtonFutureSessions.Margin = new Padding(0);
            roundedButtonFutureSessions.Name = "roundedButtonFutureSessions";
            roundedButtonFutureSessions.Padding = new Padding(20, 0, 0, 0);
            roundedButtonFutureSessions.Size = new Size(183, 40);
            roundedButtonFutureSessions.TabIndex = 11;
            roundedButtonFutureSessions.Text = "Sessions";
            roundedButtonFutureSessions.TextAlign = ContentAlignment.MiddleLeft;
            roundedButtonFutureSessions.TextColor = Color.Black;
            roundedButtonFutureSessions.TextImageRelation = TextImageRelation.ImageBeforeText;
            roundedButtonFutureSessions.UseVisualStyleBackColor = false;
            roundedButtonFutureSessions.Click += roundedButton3_Click;
            // 
            // roundedButtonFilms
            // 
            roundedButtonFilms.Autofocus = false;
            roundedButtonFilms.BackColor = Color.White;
            roundedButtonFilms.BackgroundColor = Color.White;
            roundedButtonFilms.BorderColor = Color.PaleVioletRed;
            roundedButtonFilms.BorderRadius = 5;
            roundedButtonFilms.BorderSize = 0;
            roundedButtonFilms.Dock = DockStyle.Fill;
            roundedButtonFilms.FlatAppearance.BorderSize = 0;
            roundedButtonFilms.FlatStyle = FlatStyle.Flat;
            roundedButtonFilms.FocusBorderColor = Color.Gray;
            roundedButtonFilms.FocusBorderSize = 2;
            roundedButtonFilms.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roundedButtonFilms.ForeColor = Color.Black;
            roundedButtonFilms.Image = Properties.Resources.films_icon_black;
            roundedButtonFilms.ImageAlign = ContentAlignment.MiddleLeft;
            roundedButtonFilms.Location = new Point(5, 15);
            roundedButtonFilms.Margin = new Padding(0);
            roundedButtonFilms.Name = "roundedButtonFilms";
            roundedButtonFilms.Padding = new Padding(20, 0, 0, 0);
            roundedButtonFilms.Size = new Size(183, 40);
            roundedButtonFilms.TabIndex = 0;
            roundedButtonFilms.Text = "Films";
            roundedButtonFilms.TextAlign = ContentAlignment.MiddleLeft;
            roundedButtonFilms.TextColor = Color.Black;
            roundedButtonFilms.TextImageRelation = TextImageRelation.ImageBeforeText;
            roundedButtonFilms.UseVisualStyleBackColor = false;
            roundedButtonFilms.Click += roundedButton1_Click;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(2, 10);
            label2.Name = "label2";
            label2.Size = new Size(193, 62);
            label2.TabIndex = 10;
            label2.Text = "CinemaPlanet";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NBAuthorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Transparent;
            Controls.Add(roundedPanel1);
            Margin = new Padding(0);
            Name = "NBAuthorization";
            Padding = new Padding(2, 0, 2, 0);
            Size = new Size(201, 591);
            Load += AppNavBar_Load;
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private components.ui.RoundedPanel roundedPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private components.ui.RoundedButton roundedButtonFilms;
        private components.ui.RoundedButton roundedButtonFutureSessions;
        private TableLayoutPanel tableLayoutPanel3;
        private components.ui.RoundedButton roundedButton5;
        private components.ui.RoundedButton roundedButton4;
        private Label label1;
        private components.ui.RoundedButton roundedButtonFindTicket;
    }
}
