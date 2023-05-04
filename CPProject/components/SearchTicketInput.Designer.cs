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
            maskedTextBox1 = new MaskedTextBox();
            tableLayoutPanel1.SuspendLayout();
            roundedPanel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(roundedPanel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(579, 333);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // roundedPanel1
            // 
            roundedPanel1.Autofocus = false;
            roundedPanel1.BackColor = Color.FromArgb(224, 224, 224);
            roundedPanel1.BackgroundColor = Color.FromArgb(224, 224, 224);
            roundedPanel1.BorderColor = Color.PaleVioletRed;
            roundedPanel1.BorderRadius = 15;
            roundedPanel1.BorderSize = 0;
            roundedPanel1.Controls.Add(roundedPanel2);
            roundedPanel1.Dock = DockStyle.Fill;
            roundedPanel1.FocusBorderColor = Color.Gray;
            roundedPanel1.FocusBorderSize = 2;
            roundedPanel1.ForeColor = Color.White;
            roundedPanel1.Location = new Point(142, 137);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(294, 59);
            roundedPanel1.TabIndex = 0;
            roundedPanel1.TextColor = Color.White;
            // 
            // roundedPanel2
            // 
            roundedPanel2.Autofocus = false;
            roundedPanel2.BackColor = Color.FromArgb(224, 224, 224);
            roundedPanel2.BackgroundColor = Color.FromArgb(224, 224, 224);
            roundedPanel2.BorderColor = Color.PaleVioletRed;
            roundedPanel2.BorderRadius = 15;
            roundedPanel2.BorderSize = 0;
            roundedPanel2.Controls.Add(tableLayoutPanel2);
            roundedPanel2.Dock = DockStyle.Fill;
            roundedPanel2.FocusBorderColor = Color.Gray;
            roundedPanel2.FocusBorderSize = 2;
            roundedPanel2.ForeColor = Color.White;
            roundedPanel2.Location = new Point(0, 0);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(294, 59);
            roundedPanel2.TabIndex = 1;
            roundedPanel2.TextColor = Color.White;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(maskedTextBox1, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(294, 59);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BorderStyle = BorderStyle.None;
            maskedTextBox1.Dock = DockStyle.Fill;
            maskedTextBox1.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(11, 18);
            maskedTextBox1.Mask = "000000-000000-000000-000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(272, 23);
            maskedTextBox1.TabIndex = 0;
            // 
            // SearchTicketInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "SearchTicketInput";
            Size = new Size(579, 333);
            tableLayoutPanel1.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ui.RoundedPanel roundedPanel1;
        private ui.RoundedPanel roundedPanel2;
        private TableLayoutPanel tableLayoutPanel2;
        private MaskedTextBox maskedTextBox1;
    }
}
