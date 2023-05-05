namespace CPProject.components
{
    partial class SearchTicketInput
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
            tableLayoutPanel1 = new TableLayoutPanel();
            roundedPanel1 = new ui.RoundedPanel();
            roundedPanel2 = new ui.RoundedPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            maskedTextBoxTicketID = new MaskedTextBox();
            roundedButtonFind = new ui.RoundedButton();
            panel1 = new Panel();
            labelInformation = new System.Windows.Forms.Label();
            tableLayoutPanel1.SuspendLayout();
            roundedPanel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(roundedPanel1, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(579, 333);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // roundedPanel1
            // 
            roundedPanel1.Autofocus = false;
            roundedPanel1.AutoSize = true;
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BackgroundColor = Color.White;
            roundedPanel1.BorderColor = Color.Silver;
            roundedPanel1.BorderRadius = 7;
            roundedPanel1.BorderSize = 1;
            roundedPanel1.Controls.Add(roundedPanel2);
            roundedPanel1.Dock = DockStyle.Fill;
            roundedPanel1.FocusBorderColor = Color.Gray;
            roundedPanel1.FocusBorderSize = 2;
            roundedPanel1.ForeColor = Color.White;
            roundedPanel1.Location = new Point(144, 122);
            roundedPanel1.Margin = new Padding(0);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Padding = new Padding(7, 9, 7, 7);
            roundedPanel1.Size = new Size(290, 43);
            roundedPanel1.TabIndex = 0;
            roundedPanel1.TextColor = Color.White;
            // 
            // roundedPanel2
            // 
            roundedPanel2.Autofocus = false;
            roundedPanel2.AutoSize = true;
            roundedPanel2.BackColor = Color.White;
            roundedPanel2.BackgroundColor = Color.White;
            roundedPanel2.BorderColor = Color.PaleVioletRed;
            roundedPanel2.BorderRadius = 15;
            roundedPanel2.BorderSize = 0;
            roundedPanel2.Controls.Add(tableLayoutPanel2);
            roundedPanel2.Dock = DockStyle.Fill;
            roundedPanel2.FocusBorderColor = Color.Gray;
            roundedPanel2.FocusBorderSize = 2;
            roundedPanel2.ForeColor = Color.White;
            roundedPanel2.Location = new Point(7, 9);
            roundedPanel2.Margin = new Padding(0);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(276, 27);
            roundedPanel2.TabIndex = 1;
            roundedPanel2.TextColor = Color.White;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 2F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 2F));
            tableLayoutPanel2.Controls.Add(maskedTextBoxTicketID, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 2F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 2F));
            tableLayoutPanel2.Size = new Size(276, 27);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // maskedTextBoxTicketID
            // 
            maskedTextBoxTicketID.BorderStyle = BorderStyle.None;
            maskedTextBoxTicketID.Dock = DockStyle.Fill;
            maskedTextBoxTicketID.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxTicketID.Location = new Point(2, 2);
            maskedTextBoxTicketID.Margin = new Padding(0);
            maskedTextBoxTicketID.Mask = "000000-000000-000000-000000";
            maskedTextBoxTicketID.Name = "maskedTextBoxTicketID";
            maskedTextBoxTicketID.Size = new Size(272, 23);
            maskedTextBoxTicketID.TabIndex = 0;
            maskedTextBoxTicketID.TextChanged += maskedTextBox1_TextChanged;
            // 
            // roundedButtonFind
            // 
            roundedButtonFind.Autofocus = false;
            roundedButtonFind.BackColor = Color.White;
            roundedButtonFind.BackgroundColor = Color.White;
            roundedButtonFind.BorderColor = Color.Silver;
            roundedButtonFind.BorderRadius = 7;
            roundedButtonFind.BorderSize = 1;
            roundedButtonFind.Dock = DockStyle.Right;
            roundedButtonFind.FlatAppearance.BorderSize = 0;
            roundedButtonFind.FlatStyle = FlatStyle.Flat;
            roundedButtonFind.FocusBorderColor = Color.Gray;
            roundedButtonFind.FocusBorderSize = 2;
            roundedButtonFind.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roundedButtonFind.ForeColor = Color.Black;
            roundedButtonFind.Location = new Point(164, 0);
            roundedButtonFind.Margin = new Padding(0);
            roundedButtonFind.Name = "roundedButtonFind";
            roundedButtonFind.Size = new Size(120, 34);
            roundedButtonFind.TabIndex = 1;
            roundedButtonFind.Text = "Find";
            roundedButtonFind.TextColor = Color.Black;
            roundedButtonFind.UseVisualStyleBackColor = false;
            roundedButtonFind.Click += roundedButtonFind_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelInformation);
            panel1.Controls.Add(roundedButtonFind);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(147, 173);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 34);
            panel1.TabIndex = 2;
            // 
            // labelInformation
            // 
            labelInformation.Dock = DockStyle.Fill;
            labelInformation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelInformation.ForeColor = Color.IndianRed;
            labelInformation.Location = new Point(0, 0);
            labelInformation.Margin = new Padding(0);
            labelInformation.Name = "labelInformation";
            labelInformation.Size = new Size(164, 34);
            labelInformation.TabIndex = 2;
            labelInformation.Text = "Ticket not found";
            labelInformation.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SearchTicketInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "SearchTicketInput";
            Size = new Size(579, 333);
            Load += SearchTicketInput_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ui.RoundedPanel roundedPanel1;
        private ui.RoundedPanel roundedPanel2;
        private TableLayoutPanel tableLayoutPanel2;
        private MaskedTextBox maskedTextBoxTicketID;
        private ui.RoundedButton roundedButtonFind;
        private Panel panel1;
        private System.Windows.Forms.Label labelInformation;
    }
}
