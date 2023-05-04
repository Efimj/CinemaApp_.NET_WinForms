namespace CPProject.controls.Pages
{
    partial class MyTicketPage
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
            roundedButtonTicketDetails = new components.ui.RoundedButton();
            roundedButtonReturnTicket = new components.ui.RoundedButton();
            roundedPanelContent = new components.ui.RoundedPanel();
            roundedPanelDGVContent = new components.ui.RoundedPanel();
            dataGridViewTickets = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            tableLayoutPanel3 = new TableLayoutPanel();
            roundedButtonSearch = new components.ui.RoundedButton();
            roundedButtonActive = new components.ui.RoundedButton();
            roundedButtonArchive = new components.ui.RoundedButton();
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
            tableLayoutPanel1.Size = new Size(910, 686);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(roundedPanel3, 0, 2);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(128, 0);
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
            tableLayoutPanel5.Controls.Add(roundedButtonTicketDetails, 5, 0);
            tableLayoutPanel5.Controls.Add(roundedButtonReturnTicket, 3, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 430);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(620, 40);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // roundedButtonTicketDetails
            // 
            roundedButtonTicketDetails.Autofocus = false;
            roundedButtonTicketDetails.BackColor = Color.White;
            roundedButtonTicketDetails.BackgroundColor = Color.White;
            roundedButtonTicketDetails.BorderColor = Color.FromArgb(224, 224, 224);
            roundedButtonTicketDetails.BorderRadius = 7;
            roundedButtonTicketDetails.BorderSize = 1;
            roundedButtonTicketDetails.Dock = DockStyle.Fill;
            roundedButtonTicketDetails.FlatAppearance.BorderSize = 0;
            roundedButtonTicketDetails.FlatStyle = FlatStyle.Flat;
            roundedButtonTicketDetails.FocusBorderColor = Color.Gray;
            roundedButtonTicketDetails.FocusBorderSize = 2;
            roundedButtonTicketDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roundedButtonTicketDetails.ForeColor = Color.Black;
            roundedButtonTicketDetails.Location = new Point(470, 0);
            roundedButtonTicketDetails.Margin = new Padding(0);
            roundedButtonTicketDetails.Name = "roundedButtonTicketDetails";
            roundedButtonTicketDetails.Size = new Size(150, 40);
            roundedButtonTicketDetails.TabIndex = 13;
            roundedButtonTicketDetails.Text = "Details";
            roundedButtonTicketDetails.TextColor = Color.Black;
            roundedButtonTicketDetails.UseVisualStyleBackColor = false;
            roundedButtonTicketDetails.Click += roundedButtonTicketDetails_Click;
            // 
            // roundedButtonReturnTicket
            // 
            roundedButtonReturnTicket.Autofocus = false;
            roundedButtonReturnTicket.BackColor = Color.White;
            roundedButtonReturnTicket.BackgroundColor = Color.White;
            roundedButtonReturnTicket.BorderColor = Color.FromArgb(224, 224, 224);
            roundedButtonReturnTicket.BorderRadius = 7;
            roundedButtonReturnTicket.BorderSize = 1;
            roundedButtonReturnTicket.Dock = DockStyle.Fill;
            roundedButtonReturnTicket.FlatAppearance.BorderSize = 0;
            roundedButtonReturnTicket.FlatStyle = FlatStyle.Flat;
            roundedButtonReturnTicket.FocusBorderColor = Color.Gray;
            roundedButtonReturnTicket.FocusBorderSize = 2;
            roundedButtonReturnTicket.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roundedButtonReturnTicket.ForeColor = Color.Black;
            roundedButtonReturnTicket.Location = new Point(315, 0);
            roundedButtonReturnTicket.Margin = new Padding(0);
            roundedButtonReturnTicket.Name = "roundedButtonReturnTicket";
            roundedButtonReturnTicket.Size = new Size(150, 40);
            roundedButtonReturnTicket.TabIndex = 12;
            roundedButtonReturnTicket.Text = "Return ticket";
            roundedButtonReturnTicket.TextColor = Color.Black;
            roundedButtonReturnTicket.UseVisualStyleBackColor = false;
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
            dataGridViewTickets.CellClick += dataGridViewTickets_CellClick;
            dataGridViewTickets.CellValueNeeded += dataGridViewTickets_CellValueNeeded;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 56.9098129F;
            Column1.HeaderText = "Film title";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.FillWeight = 56.9098129F;
            Column2.HeaderText = "Address";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 56.9098129F;
            Column3.HeaderText = "Date";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column4.FillWeight = 35.9045334F;
            Column4.HeaderText = "Seat";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 75;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column5.DefaultCellStyle = dataGridViewCellStyle2;
            Column5.FillWeight = 29.1391678F;
            Column5.HeaderText = "Price";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 75;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel3.Controls.Add(roundedButtonSearch, 2, 0);
            tableLayoutPanel3.Controls.Add(roundedButtonActive, 0, 0);
            tableLayoutPanel3.Controls.Add(roundedButtonArchive, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(620, 40);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // roundedButtonSearch
            // 
            roundedButtonSearch.Autofocus = false;
            roundedButtonSearch.BackColor = Color.White;
            roundedButtonSearch.BackgroundColor = Color.White;
            roundedButtonSearch.BorderColor = Color.FromArgb(224, 224, 224);
            roundedButtonSearch.BorderRadius = 5;
            roundedButtonSearch.BorderSize = 0;
            roundedButtonSearch.Dock = DockStyle.Fill;
            roundedButtonSearch.FlatAppearance.BorderSize = 0;
            roundedButtonSearch.FlatStyle = FlatStyle.Flat;
            roundedButtonSearch.FocusBorderColor = Color.Gray;
            roundedButtonSearch.FocusBorderSize = 2;
            roundedButtonSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roundedButtonSearch.ForeColor = Color.Black;
            roundedButtonSearch.Location = new Point(160, 0);
            roundedButtonSearch.Margin = new Padding(0);
            roundedButtonSearch.Name = "roundedButtonSearch";
            roundedButtonSearch.Padding = new Padding(4, 0, 0, 0);
            roundedButtonSearch.Size = new Size(80, 40);
            roundedButtonSearch.TabIndex = 15;
            roundedButtonSearch.Text = "Search";
            roundedButtonSearch.TextColor = Color.Black;
            roundedButtonSearch.UseVisualStyleBackColor = false;
            roundedButtonSearch.Click += roundedButtonSearch_Click;
            // 
            // roundedButtonActive
            // 
            roundedButtonActive.Autofocus = false;
            roundedButtonActive.BackColor = Color.White;
            roundedButtonActive.BackgroundColor = Color.White;
            roundedButtonActive.BorderColor = Color.FromArgb(224, 224, 224);
            roundedButtonActive.BorderRadius = 5;
            roundedButtonActive.BorderSize = 0;
            roundedButtonActive.Dock = DockStyle.Fill;
            roundedButtonActive.FlatAppearance.BorderSize = 0;
            roundedButtonActive.FlatStyle = FlatStyle.Flat;
            roundedButtonActive.FocusBorderColor = Color.Gray;
            roundedButtonActive.FocusBorderSize = 2;
            roundedButtonActive.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roundedButtonActive.ForeColor = Color.Black;
            roundedButtonActive.Location = new Point(0, 0);
            roundedButtonActive.Margin = new Padding(0);
            roundedButtonActive.Name = "roundedButtonActive";
            roundedButtonActive.Size = new Size(80, 40);
            roundedButtonActive.TabIndex = 14;
            roundedButtonActive.Text = "Active";
            roundedButtonActive.TextColor = Color.Black;
            roundedButtonActive.UseVisualStyleBackColor = false;
            roundedButtonActive.Click += roundedButtonActive_Click;
            // 
            // roundedButtonArchive
            // 
            roundedButtonArchive.Autofocus = false;
            roundedButtonArchive.BackColor = Color.White;
            roundedButtonArchive.BackgroundColor = Color.White;
            roundedButtonArchive.BorderColor = Color.FromArgb(224, 224, 224);
            roundedButtonArchive.BorderRadius = 5;
            roundedButtonArchive.BorderSize = 0;
            roundedButtonArchive.Dock = DockStyle.Fill;
            roundedButtonArchive.FlatAppearance.BorderSize = 0;
            roundedButtonArchive.FlatStyle = FlatStyle.Flat;
            roundedButtonArchive.FocusBorderColor = Color.Gray;
            roundedButtonArchive.FocusBorderSize = 2;
            roundedButtonArchive.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roundedButtonArchive.ForeColor = Color.Black;
            roundedButtonArchive.Location = new Point(80, 0);
            roundedButtonArchive.Margin = new Padding(0);
            roundedButtonArchive.Name = "roundedButtonArchive";
            roundedButtonArchive.Size = new Size(80, 40);
            roundedButtonArchive.TabIndex = 13;
            roundedButtonArchive.Text = "Archive";
            roundedButtonArchive.TextColor = Color.Black;
            roundedButtonArchive.UseVisualStyleBackColor = false;
            roundedButtonArchive.Click += roundedButtonArchive_Click;
            // 
            // MyTicketPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(tableLayoutPanel1);
            Name = "MyTicketPage";
            Size = new Size(910, 862);
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
        private components.ui.RoundedButton roundedButtonReturnTicket;
        private components.ui.RoundedPanel roundedPanelContent;
        private components.ui.RoundedPanel roundedPanelDGVContent;
        private DataGridView dataGridViewTickets;
        private TableLayoutPanel tableLayoutPanel3;
        private components.ui.RoundedButton roundedButtonSearch;
        private components.ui.RoundedButton roundedButtonActive;
        private components.ui.RoundedButton roundedButtonArchive;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private components.ui.RoundedButton roundedButtonTicketDetails;
    }
}
