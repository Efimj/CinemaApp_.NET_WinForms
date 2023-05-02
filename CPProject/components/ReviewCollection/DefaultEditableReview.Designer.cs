namespace CPProject.components.EditableReview
{
    partial class DefaultEditableReview
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
            roundedPanel1 = new ui.RoundedPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            roundedButton1 = new ui.RoundedButton();
            labelErrorText = new System.Windows.Forms.Label();
            panel1 = new Panel();
            labelUserName = new System.Windows.Forms.Label();
            ratingControl1 = new ui.RatingControl();
            textBox1 = new TextBox();
            roundedPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.Autofocus = false;
            roundedPanel1.AutoSize = true;
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BackgroundColor = Color.White;
            roundedPanel1.BorderColor = Color.FromArgb(224, 224, 224);
            roundedPanel1.BorderRadius = 13;
            roundedPanel1.BorderSize = 1;
            roundedPanel1.Controls.Add(tableLayoutPanel1);
            roundedPanel1.Dock = DockStyle.Fill;
            roundedPanel1.FocusBorderColor = Color.Gray;
            roundedPanel1.FocusBorderSize = 2;
            roundedPanel1.ForeColor = Color.White;
            roundedPanel1.Location = new Point(0, 0);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Padding = new Padding(10, 5, 10, 10);
            roundedPanel1.Size = new Size(591, 124);
            roundedPanel1.TabIndex = 2;
            roundedPanel1.TextColor = Color.White;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 5, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 5);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(571, 109);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(roundedButton1, 0, 0);
            tableLayoutPanel2.Controls.Add(labelErrorText, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 71);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.Size = new Size(571, 35);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // roundedButton1
            // 
            roundedButton1.Autofocus = false;
            roundedButton1.BackColor = Color.White;
            roundedButton1.BackgroundColor = Color.White;
            roundedButton1.BorderColor = Color.FromArgb(224, 224, 224);
            roundedButton1.BorderRadius = 10;
            roundedButton1.BorderSize = 1;
            roundedButton1.Dock = DockStyle.Fill;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.FocusBorderColor = Color.Gray;
            roundedButton1.FocusBorderSize = 2;
            roundedButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roundedButton1.ForeColor = Color.Black;
            roundedButton1.Location = new Point(0, 0);
            roundedButton1.Margin = new Padding(0);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(140, 35);
            roundedButton1.TabIndex = 0;
            roundedButton1.Text = "Save";
            roundedButton1.TextColor = Color.Black;
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // labelErrorText
            // 
            labelErrorText.Dock = DockStyle.Fill;
            labelErrorText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelErrorText.ForeColor = Color.IndianRed;
            labelErrorText.Location = new Point(143, 0);
            labelErrorText.Name = "labelErrorText";
            labelErrorText.Padding = new Padding(5, 0, 0, 0);
            labelErrorText.Size = new Size(425, 35);
            labelErrorText.TabIndex = 1;
            labelErrorText.Text = "Error";
            labelErrorText.TextAlign = ContentAlignment.MiddleLeft;
            labelErrorText.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelUserName);
            panel1.Controls.Add(ratingControl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(571, 35);
            panel1.TabIndex = 2;
            // 
            // labelUserName
            // 
            labelUserName.Dock = DockStyle.Fill;
            labelUserName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUserName.ForeColor = Color.Black;
            labelUserName.Location = new Point(0, 0);
            labelUserName.Margin = new Padding(0, 0, 3, 0);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(461, 35);
            labelUserName.TabIndex = 6;
            labelUserName.Text = "User name";
            labelUserName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ratingControl1
            // 
            ratingControl1.BackColor = Color.White;
            ratingControl1.CurrentReting = null;
            ratingControl1.Dock = DockStyle.Right;
            ratingControl1.Editable = true;
            ratingControl1.Location = new Point(461, 0);
            ratingControl1.Margin = new Padding(0);
            ratingControl1.Name = "ratingControl1";
            ratingControl1.Size = new Size(110, 35);
            ratingControl1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Top;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(3, 38);
            textBox1.MinimumSize = new Size(0, 30);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Description";
            textBox1.Size = new Size(565, 30);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // DefaultEditableReview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(roundedPanel1);
            Name = "DefaultEditableReview";
            Size = new Size(591, 124);
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ui.RoundedPanel roundedPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private ui.RoundedButton roundedButton1;
        private System.Windows.Forms.Label labelErrorText;
        private System.Windows.Forms.Label labelUserName;
        private ui.RatingControl ratingControl1;
    }
}
