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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            roundedPanel3 = new components.ui.RoundedPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            roundedButtonBlock = new components.ui.RoundedButton();
            roundedPanelContent = new components.ui.RoundedPanel();
            roundedPanelDGVContent = new components.ui.RoundedPanel();
            dataGridViewTickets = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            tableLayoutPanel3 = new TableLayoutPanel();
            roundedButtonBlocked = new components.ui.RoundedButton();
            roundedButtonAll = new components.ui.RoundedButton();
            roundedSearchField1 = new components.ui.RoundedSearchField();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            roundedPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            roundedPanelContent.SuspendLayout();
            roundedPanelDGVContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTickets).BeginInit();
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
            roundedPanelDGVContent.Controls.Add(dataGridViewTickets);
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
            // dataGridViewTickets
            // 
            dataGridViewTickets.AllowUserToAddRows = false;
            dataGridViewTickets.AllowUserToDeleteRows = false;
            dataGridViewTickets.AllowUserToResizeColumns = false;
            dataGridViewTickets.AllowUserToResizeRows = false;
            dataGridViewTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTickets.BackgroundColor = Color.White;
            dataGridViewTickets.BorderStyle = BorderStyle.None;
            dataGridViewTickets.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewTickets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTickets.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewTickets.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTickets.Dock = DockStyle.Fill;
            dataGridViewTickets.GridColor = Color.FromArgb(224, 224, 224);
            dataGridViewTickets.Location = new Point(0, 0);
            dataGridViewTickets.Margin = new Padding(2);
            dataGridViewTickets.MultiSelect = false;
            dataGridViewTickets.Name = "dataGridViewTickets";
            dataGridViewTickets.ReadOnly = true;
            dataGridViewTickets.RowHeadersVisible = false;
            dataGridViewTickets.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewTickets.RowTemplate.Height = 25;
            dataGridViewTickets.Size = new Size(617, 372);
            dataGridViewTickets.TabIndex = 1;
            dataGridViewTickets.VirtualMode = true;
            // 
            // Column1
            // 
            Column1.FillWeight = 1.13897383F;
            Column1.HeaderText = "Login";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column2.FillWeight = 56.7441559F;
            Column2.HeaderText = "Date of Birth";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 130;
            // 
            // Column3
            // 
            Column3.FillWeight = 0.622358441F;
            Column3.HeaderText = "Tickets";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.FillWeight = 0.6825859F;
            Column4.HeaderText = "Reviews";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column5.DefaultCellStyle = dataGridViewCellStyle2;
            Column5.FillWeight = 0.6049653F;
            Column5.HeaderText = "Status";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 224F));
            tableLayoutPanel3.Controls.Add(roundedButtonBlocked, 0, 0);
            tableLayoutPanel3.Controls.Add(roundedButtonAll, 1, 0);
            tableLayoutPanel3.Controls.Add(roundedSearchField1, 3, 0);
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
            roundedButtonBlocked.Location = new Point(0, 0);
            roundedButtonBlocked.Margin = new Padding(0);
            roundedButtonBlocked.Name = "roundedButtonBlocked";
            roundedButtonBlocked.Size = new Size(80, 40);
            roundedButtonBlocked.TabIndex = 14;
            roundedButtonBlocked.Text = "Blocked";
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
            roundedButtonAll.Location = new Point(80, 0);
            roundedButtonAll.Margin = new Padding(0);
            roundedButtonAll.Name = "roundedButtonAll";
            roundedButtonAll.Size = new Size(80, 40);
            roundedButtonAll.TabIndex = 13;
            roundedButtonAll.Text = "All";
            roundedButtonAll.TextColor = Color.Black;
            roundedButtonAll.UseVisualStyleBackColor = false;
            roundedButtonAll.Click += roundedButtonAll_Click;
            // 
            // roundedSearchField1
            // 
            roundedSearchField1.BackColor = SystemColors.Window;
            roundedSearchField1.BorderColor = Color.FromArgb(224, 224, 224);
            roundedSearchField1.BorderFocusColor = Color.FromArgb(224, 224, 224);
            roundedSearchField1.BorderRadius = 7;
            roundedSearchField1.BorderSize = 1;
            roundedSearchField1.Dock = DockStyle.Fill;
            roundedSearchField1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            roundedSearchField1.ForeColor = Color.FromArgb(64, 64, 64);
            roundedSearchField1.Location = new Point(165, 0);
            roundedSearchField1.Margin = new Padding(0);
            roundedSearchField1.Multiline = false;
            roundedSearchField1.Name = "roundedSearchField1";
            roundedSearchField1.Padding = new Padding(10, 7, 10, 7);
            roundedSearchField1.PasswordChar = false;
            roundedSearchField1.PlaceholderColor = Color.DarkGray;
            roundedSearchField1.PlaceholderText = "";
            roundedSearchField1.Size = new Size(231, 40);
            roundedSearchField1.TabIndex = 15;
            roundedSearchField1.Texts = "";
            roundedSearchField1.UnderlinedStyle = false;
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewTickets).EndInit();
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
        private DataGridView dataGridViewTickets;
        private TableLayoutPanel tableLayoutPanel3;
        private components.ui.RoundedButton roundedButtonSearch;
        private components.ui.RoundedButton roundedButtonBlocked;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private components.ui.RoundedButton roundedButtonAll;
        private components.ui.RoundedSearchField roundedSearchField1;
    }
}
