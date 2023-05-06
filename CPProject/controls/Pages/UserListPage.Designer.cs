namespace CPProject.controls.Pages
{
    partial class UserListPage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            roundedPanel3 = new components.ui.RoundedPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            roundedButtonBlock = new components.ui.RoundedButton();
            roundedPanelContent = new components.ui.RoundedPanel();
            roundedPanelDGVContent = new components.ui.RoundedPanel();
            dataGridViewUsers = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            tableLayoutPanel3 = new TableLayoutPanel();
            roundedButtonBlocked = new components.ui.RoundedButton();
            roundedButtonAll = new components.ui.RoundedButton();
            roundedSearchFieldLogin = new components.ui.RoundedSearchField();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            roundedPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            roundedPanelContent.SuspendLayout();
            roundedPanelDGVContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.9999962F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 650F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 686F));
            tableLayoutPanel1.Size = new Size(965, 686);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(roundedPanel3, 0, 2);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(156, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(650, 618);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // roundedPanel3
            // 
            roundedPanel3.Autofocus = false;
            roundedPanel3.BackColor = Color.White;
            roundedPanel3.BackgroundColor = Color.White;
            roundedPanel3.BorderColor = Color.Transparent;
            roundedPanel3.BorderRadius = 13;
            roundedPanel3.BorderSize = 0;
            roundedPanel3.Controls.Add(tableLayoutPanel2);
            roundedPanel3.Dock = DockStyle.Top;
            roundedPanel3.FocusBorderColor = Color.Gray;
            roundedPanel3.FocusBorderSize = 2;
            roundedPanel3.ForeColor = Color.White;
            roundedPanel3.Location = new Point(0, 55);
            roundedPanel3.Margin = new Padding(0);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Padding = new Padding(15);
            roundedPanel3.Size = new Size(650, 500);
            roundedPanel3.TabIndex = 3;
            roundedPanel3.TextColor = Color.White;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 4);
            tableLayoutPanel2.Controls.Add(roundedPanelContent, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(15, 15);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.Size = new Size(620, 470);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 6;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel5.Controls.Add(roundedButtonBlock, 5, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 430);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(620, 40);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // roundedButtonBlock
            // 
            roundedButtonBlock.Autofocus = false;
            roundedButtonBlock.BackColor = Color.White;
            roundedButtonBlock.BackgroundColor = Color.White;
            roundedButtonBlock.BorderColor = Color.FromArgb(224, 224, 224);
            roundedButtonBlock.BorderRadius = 7;
            roundedButtonBlock.BorderSize = 1;
            roundedButtonBlock.Dock = DockStyle.Fill;
            roundedButtonBlock.FlatAppearance.BorderSize = 0;
            roundedButtonBlock.FlatStyle = FlatStyle.Flat;
            roundedButtonBlock.FocusBorderColor = Color.Gray;
            roundedButtonBlock.FocusBorderSize = 2;
            roundedButtonBlock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roundedButtonBlock.ForeColor = Color.Black;
            roundedButtonBlock.Location = new Point(470, 0);
            roundedButtonBlock.Margin = new Padding(0);
            roundedButtonBlock.Name = "roundedButtonBlock";
            roundedButtonBlock.Size = new Size(150, 40);
            roundedButtonBlock.TabIndex = 13;
            roundedButtonBlock.Text = "Block";
            roundedButtonBlock.TextColor = Color.Black;
            roundedButtonBlock.UseVisualStyleBackColor = false;
            // 
            // roundedPanelContent
            // 
            roundedPanelContent.Autofocus = false;
            roundedPanelContent.BackColor = Color.White;
            roundedPanelContent.BackgroundColor = Color.White;
            roundedPanelContent.BorderColor = Color.FromArgb(224, 224, 224);
            roundedPanelContent.BorderRadius = 10;
            roundedPanelContent.BorderSize = 1;
            roundedPanelContent.Controls.Add(roundedPanelDGVContent);
            roundedPanelContent.Dock = DockStyle.Fill;
            roundedPanelContent.FocusBorderColor = Color.Gray;
            roundedPanelContent.FocusBorderSize = 2;
            roundedPanelContent.ForeColor = Color.White;
            roundedPanelContent.Location = new Point(0, 47);
            roundedPanelContent.Margin = new Padding(0);
            roundedPanelContent.Name = "roundedPanelContent";
            roundedPanelContent.Padding = new Padding(2, 2, 1, 2);
            roundedPanelContent.Size = new Size(620, 376);
            roundedPanelContent.TabIndex = 3;
            roundedPanelContent.TextColor = Color.White;
            // 
            // roundedPanelDGVContent
            // 
            roundedPanelDGVContent.Autofocus = false;
            roundedPanelDGVContent.BackColor = Color.White;
            roundedPanelDGVContent.BackgroundColor = Color.White;
            roundedPanelDGVContent.BorderColor = Color.FromArgb(224, 224, 224);
            roundedPanelDGVContent.BorderRadius = 10;
            roundedPanelDGVContent.BorderSize = 1;
            roundedPanelDGVContent.Controls.Add(dataGridViewUsers);
            roundedPanelDGVContent.Dock = DockStyle.Fill;
            roundedPanelDGVContent.FocusBorderColor = Color.Gray;
            roundedPanelDGVContent.FocusBorderSize = 2;
            roundedPanelDGVContent.ForeColor = Color.White;
            roundedPanelDGVContent.Location = new Point(2, 2);
            roundedPanelDGVContent.Margin = new Padding(0);
            roundedPanelDGVContent.Name = "roundedPanelDGVContent";
            roundedPanelDGVContent.Size = new Size(617, 372);
            roundedPanelDGVContent.TabIndex = 4;
            roundedPanelDGVContent.TextColor = Color.White;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.AllowUserToResizeColumns = false;
            dataGridViewUsers.AllowUserToResizeRows = false;
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.BackgroundColor = Color.White;
            dataGridViewUsers.BorderStyle = BorderStyle.None;
            dataGridViewUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewUsers.Dock = DockStyle.Fill;
            dataGridViewUsers.GridColor = Color.FromArgb(224, 224, 224);
            dataGridViewUsers.Location = new Point(0, 0);
            dataGridViewUsers.Margin = new Padding(2);
            dataGridViewUsers.MultiSelect = false;
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.RowHeadersVisible = false;
            dataGridViewUsers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewUsers.RowTemplate.Height = 25;
            dataGridViewUsers.Size = new Size(617, 372);
            dataGridViewUsers.TabIndex = 1;
            dataGridViewUsers.VirtualMode = true;
            dataGridViewUsers.CellClick += dataGridViewUsers_CellClick;
            dataGridViewUsers.CellValueNeeded += dataGridViewTickets_CellValueNeeded;
            // 
            // Column1
            // 
            Column1.FillWeight = 31.60125F;
            Column1.HeaderText = "Login";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column2.DefaultCellStyle = dataGridViewCellStyle2;
            Column2.FillWeight = 56.7441559F;
            Column2.HeaderText = "Date of Birth";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 130;
            // 
            // Column3
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column3.DefaultCellStyle = dataGridViewCellStyle3;
            Column3.FillWeight = 17.2675648F;
            Column3.HeaderText = "Tickets";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column4.DefaultCellStyle = dataGridViewCellStyle4;
            Column4.FillWeight = 18.9386F;
            Column4.HeaderText = "Reviews";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column5.DefaultCellStyle = dataGridViewCellStyle5;
            Column5.FillWeight = 16.78499F;
            Column5.HeaderText = "Status";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column6.DefaultCellStyle = dataGridViewCellStyle6;
            Column6.FillWeight = 18.4565239F;
            Column6.HeaderText = "Money";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 280F));
            tableLayoutPanel3.Controls.Add(roundedButtonBlocked, 1, 0);
            tableLayoutPanel3.Controls.Add(roundedButtonAll, 0, 0);
            tableLayoutPanel3.Controls.Add(roundedSearchFieldLogin, 3, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(620, 40);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // roundedButtonBlocked
            // 
            roundedButtonBlocked.Autofocus = false;
            roundedButtonBlocked.BackColor = Color.White;
            roundedButtonBlocked.BackgroundColor = Color.White;
            roundedButtonBlocked.BorderColor = Color.FromArgb(224, 224, 224);
            roundedButtonBlocked.BorderRadius = 5;
            roundedButtonBlocked.BorderSize = 0;
            roundedButtonBlocked.Dock = DockStyle.Fill;
            roundedButtonBlocked.FlatAppearance.BorderSize = 0;
            roundedButtonBlocked.FlatStyle = FlatStyle.Flat;
            roundedButtonBlocked.FocusBorderColor = Color.Gray;
            roundedButtonBlocked.FocusBorderSize = 2;
            roundedButtonBlocked.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roundedButtonBlocked.ForeColor = Color.Black;
            roundedButtonBlocked.Location = new Point(80, 0);
            roundedButtonBlocked.Margin = new Padding(0);
            roundedButtonBlocked.Name = "roundedButtonBlocked";
            roundedButtonBlocked.Size = new Size(80, 40);
            roundedButtonBlocked.TabIndex = 14;
            roundedButtonBlocked.Text = "Baned";
            roundedButtonBlocked.TextColor = Color.Black;
            roundedButtonBlocked.UseVisualStyleBackColor = false;
            roundedButtonBlocked.Click += roundedButtonBlocked_Click;
            // 
            // roundedButtonAll
            // 
            roundedButtonAll.Autofocus = false;
            roundedButtonAll.BackColor = Color.White;
            roundedButtonAll.BackgroundColor = Color.White;
            roundedButtonAll.BorderColor = Color.FromArgb(224, 224, 224);
            roundedButtonAll.BorderRadius = 5;
            roundedButtonAll.BorderSize = 0;
            roundedButtonAll.Dock = DockStyle.Fill;
            roundedButtonAll.FlatAppearance.BorderSize = 0;
            roundedButtonAll.FlatStyle = FlatStyle.Flat;
            roundedButtonAll.FocusBorderColor = Color.Gray;
            roundedButtonAll.FocusBorderSize = 2;
            roundedButtonAll.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roundedButtonAll.ForeColor = Color.Black;
            roundedButtonAll.Location = new Point(0, 0);
            roundedButtonAll.Margin = new Padding(0);
            roundedButtonAll.Name = "roundedButtonAll";
            roundedButtonAll.Size = new Size(80, 40);
            roundedButtonAll.TabIndex = 13;
            roundedButtonAll.Text = "All";
            roundedButtonAll.TextColor = Color.Black;
            roundedButtonAll.UseVisualStyleBackColor = false;
            roundedButtonAll.Click += roundedButtonAll_Click;
            // 
            // roundedSearchFieldLogin
            // 
            roundedSearchFieldLogin.BackColor = SystemColors.Window;
            roundedSearchFieldLogin.BorderColor = Color.Silver;
            roundedSearchFieldLogin.BorderFocusColor = Color.Silver;
            roundedSearchFieldLogin.BorderRadius = 7;
            roundedSearchFieldLogin.BorderSize = 1;
            roundedSearchFieldLogin.Dock = DockStyle.Fill;
            roundedSearchFieldLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roundedSearchFieldLogin.ForeColor = Color.FromArgb(64, 64, 64);
            roundedSearchFieldLogin.Location = new Point(165, 0);
            roundedSearchFieldLogin.Margin = new Padding(0);
            roundedSearchFieldLogin.Multiline = false;
            roundedSearchFieldLogin.Name = "roundedSearchFieldLogin";
            roundedSearchFieldLogin.Padding = new Padding(10, 10, 10, 7);
            roundedSearchFieldLogin.PasswordChar = false;
            roundedSearchFieldLogin.PlaceholderColor = Color.DarkGray;
            roundedSearchFieldLogin.PlaceholderText = "user_name";
            roundedSearchFieldLogin.Size = new Size(175, 39);
            roundedSearchFieldLogin.TabIndex = 15;
            roundedSearchFieldLogin.Texts = "";
            roundedSearchFieldLogin.UnderlinedStyle = false;
            roundedSearchFieldLogin._TextChanged += roundedSearchFieldLogin__TextChanged;
            // 
            // UserListPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(tableLayoutPanel1);
            Name = "UserListPage";
            Size = new Size(965, 839);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            roundedPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            roundedPanelContent.ResumeLayout(false);
            roundedPanelDGVContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private components.ui.RoundedPanel roundedPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel5;
        private components.ui.RoundedButton roundedButtonBlock;
        private components.ui.RoundedPanel roundedPanelContent;
        private components.ui.RoundedPanel roundedPanelDGVContent;
        private DataGridView dataGridViewUsers;
        private TableLayoutPanel tableLayoutPanel3;
        private components.ui.RoundedButton roundedButtonSearch;
        private components.ui.RoundedButton roundedButtonBlocked;
        private components.ui.RoundedButton roundedButtonAll;
        private components.ui.RoundedSearchField roundedSearchFieldLogin;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}
