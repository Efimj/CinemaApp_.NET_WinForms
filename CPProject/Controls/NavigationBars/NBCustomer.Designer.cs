namespace CPProject.Controls
{
    partial class NBCustomer
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
            tableLayoutPanel2 = new TableLayoutPanel();
            roundedButton2 = new components.ui.RoundedButton();
            roundedButton1 = new components.ui.RoundedButton();
            roundedButtonFutureSessions = new components.ui.RoundedButton();
            roundedButtonFilms = new components.ui.RoundedButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelName = new Label();
            label4 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            roundedButton4 = new components.ui.RoundedButton();
            roundedPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
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
            roundedPanel1.Controls.Add(tableLayoutPanel2);
            roundedPanel1.Controls.Add(tableLayoutPanel1);
            roundedPanel1.Controls.Add(tableLayoutPanel3);
            roundedPanel1.Dock = DockStyle.Fill;
            roundedPanel1.FocusBorderColor = Color.Gray;
            roundedPanel1.FocusBorderSize = 2;
            roundedPanel1.ForeColor = Color.White;
            roundedPanel1.Location = new Point(0, 0);
            roundedPanel1.Margin = new Padding(0);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Padding = new Padding(2, 10, 2, 10);
            roundedPanel1.Size = new Size(370, 723);
            roundedPanel1.TabIndex = 11;
            roundedPanel1.TextColor = Color.White;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(roundedButton2, 0, 6);
            tableLayoutPanel2.Controls.Add(roundedButton1, 0, 4);
            tableLayoutPanel2.Controls.Add(roundedButtonFutureSessions, 0, 2);
            tableLayoutPanel2.Controls.Add(roundedButtonFilms, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(2, 56);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(5, 15, 5, 0);
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(366, 190);
            tableLayoutPanel2.TabIndex = 16;
            // 
            // roundedButton2
            // 
            roundedButton2.Autofocus = false;
            roundedButton2.BackColor = Color.White;
            roundedButton2.BackgroundColor = Color.White;
            roundedButton2.BorderColor = Color.PaleVioletRed;
            roundedButton2.BorderRadius = 5;
            roundedButton2.BorderSize = 0;
            roundedButton2.Dock = DockStyle.Fill;
            roundedButton2.FlatAppearance.BorderSize = 0;
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.FocusBorderColor = Color.Gray;
            roundedButton2.FocusBorderSize = 2;
            roundedButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roundedButton2.ForeColor = Color.Black;
            roundedButton2.Image = Properties.Resources.account_black;
            roundedButton2.ImageAlign = ContentAlignment.MiddleLeft;
            roundedButton2.Location = new Point(5, 150);
            roundedButton2.Margin = new Padding(0);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Padding = new Padding(20, 0, 0, 0);
            roundedButton2.Size = new Size(356, 40);
            roundedButton2.TabIndex = 18;
            roundedButton2.Text = "Account";
            roundedButton2.TextAlign = ContentAlignment.MiddleLeft;
            roundedButton2.TextColor = Color.Black;
            roundedButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            roundedButton2.UseVisualStyleBackColor = false;
            roundedButton2.Click += roundedButton2_Click;
            // 
            // roundedButton1
            // 
            roundedButton1.Autofocus = false;
            roundedButton1.BackColor = Color.White;
            roundedButton1.BackgroundColor = Color.White;
            roundedButton1.BorderColor = Color.PaleVioletRed;
            roundedButton1.BorderRadius = 5;
            roundedButton1.BorderSize = 0;
            roundedButton1.Dock = DockStyle.Fill;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.FocusBorderColor = Color.Gray;
            roundedButton1.FocusBorderSize = 2;
            roundedButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roundedButton1.ForeColor = Color.Black;
            roundedButton1.Image = Properties.Resources.session_black;
            roundedButton1.ImageAlign = ContentAlignment.MiddleLeft;
            roundedButton1.Location = new Point(5, 105);
            roundedButton1.Margin = new Padding(0);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Padding = new Padding(20, 0, 0, 0);
            roundedButton1.Size = new Size(356, 40);
            roundedButton1.TabIndex = 17;
            roundedButton1.Text = "Sessions";
            roundedButton1.TextAlign = ContentAlignment.MiddleLeft;
            roundedButton1.TextColor = Color.Black;
            roundedButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click;
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
            roundedButtonFutureSessions.Image = Properties.Resources.ticket_black;
            roundedButtonFutureSessions.ImageAlign = ContentAlignment.MiddleLeft;
            roundedButtonFutureSessions.Location = new Point(5, 60);
            roundedButtonFutureSessions.Margin = new Padding(0);
            roundedButtonFutureSessions.Name = "roundedButtonFutureSessions";
            roundedButtonFutureSessions.Padding = new Padding(20, 0, 0, 0);
            roundedButtonFutureSessions.Size = new Size(356, 40);
            roundedButtonFutureSessions.TabIndex = 11;
            roundedButtonFutureSessions.Text = "Tickets";
            roundedButtonFutureSessions.TextAlign = ContentAlignment.MiddleLeft;
            roundedButtonFutureSessions.TextColor = Color.Black;
            roundedButtonFutureSessions.TextImageRelation = TextImageRelation.ImageBeforeText;
            roundedButtonFutureSessions.UseVisualStyleBackColor = false;
            roundedButtonFutureSessions.Click += roundedButtonFutureSessions_Click;
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
            roundedButtonFilms.Size = new Size(356, 40);
            roundedButtonFilms.TabIndex = 0;
            roundedButtonFilms.Text = "Films";
            roundedButtonFilms.TextAlign = ContentAlignment.MiddleLeft;
            roundedButtonFilms.TextColor = Color.Black;
            roundedButtonFilms.TextImageRelation = TextImageRelation.ImageBeforeText;
            roundedButtonFilms.UseVisualStyleBackColor = false;
            roundedButtonFilms.Click += roundedButtonFilms_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(labelName, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(2, 10);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(366, 46);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Dock = DockStyle.Right;
            labelName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.Black;
            labelName.Location = new Point(182, 0);
            labelName.Margin = new Padding(0, 0, 3, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(59, 46);
            labelName.TabIndex = 11;
            labelName.Text = "Hello";
            labelName.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(125, 0);
            label4.Margin = new Padding(3, 0, 0, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 46);
            label4.TabIndex = 10;
            label4.Text = "Hello";
            label4.TextAlign = ContentAlignment.BottomRight;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(roundedButton4, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Bottom;
            tableLayoutPanel3.Location = new Point(2, 678);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(5, 0, 5, 0);
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(366, 35);
            tableLayoutPanel3.TabIndex = 12;
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
            roundedButton4.Image = Properties.Resources.logout_black;
            roundedButton4.ImageAlign = ContentAlignment.MiddleLeft;
            roundedButton4.Location = new Point(5, 0);
            roundedButton4.Margin = new Padding(0);
            roundedButton4.Name = "roundedButton4";
            roundedButton4.Padding = new Padding(20, 0, 0, 0);
            roundedButton4.Size = new Size(356, 35);
            roundedButton4.TabIndex = 11;
            roundedButton4.Text = "Log out";
            roundedButton4.TextAlign = ContentAlignment.MiddleLeft;
            roundedButton4.TextColor = Color.Black;
            roundedButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            roundedButton4.UseVisualStyleBackColor = false;
            roundedButton4.Click += roundedButton4_Click;
            // 
            // NBCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(roundedPanel1);
            Name = "NBCustomer";
            Size = new Size(370, 723);
            Load += NBCustomer_Load;
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private components.ui.RoundedPanel roundedPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private components.ui.RoundedButton roundedButtonFutureSessions;
        private components.ui.RoundedButton roundedButtonFilms;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelName;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel3;
        private components.ui.RoundedButton roundedButton4;
        private components.ui.RoundedButton roundedButton2;
        private components.ui.RoundedButton roundedButton1;
    }
}
