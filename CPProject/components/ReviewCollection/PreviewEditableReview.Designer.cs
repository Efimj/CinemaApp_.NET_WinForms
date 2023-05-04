namespace CPProject.components.ReviewCollection
{
    partial class PreviewEditableReview
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
            label4 = new System.Windows.Forms.Label();
            roundedButton2 = new ui.RoundedButton();
            panel1 = new Panel();
            labelUserName = new System.Windows.Forms.Label();
            ratingControl1 = new ui.RatingControl();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            labelDescription = new System.Windows.Forms.Label();
            roundedPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            roundedPanel1.Size = new Size(628, 191);
            roundedPanel1.TabIndex = 3;
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
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 5);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(608, 176);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel2.Controls.Add(roundedButton1, 0, 0);
            tableLayoutPanel2.Controls.Add(label4, 3, 0);
            tableLayoutPanel2.Controls.Add(roundedButton2, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 79);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.Size = new Size(608, 35);
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
            roundedButton1.Text = "Edit";
            roundedButton1.TextColor = Color.Black;
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(498, 0);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(110, 35);
            label4.TabIndex = 5;
            label4.Text = "20.22.2022";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // roundedButton2
            // 
            roundedButton2.Autofocus = false;
            roundedButton2.BackColor = Color.White;
            roundedButton2.BackgroundColor = Color.White;
            roundedButton2.BorderColor = Color.FromArgb(224, 224, 224);
            roundedButton2.BorderRadius = 14;
            roundedButton2.BorderSize = 1;
            roundedButton2.FlatAppearance.BorderSize = 0;
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.FocusBorderColor = Color.Gray;
            roundedButton2.FocusBorderSize = 2;
            roundedButton2.ForeColor = Color.Black;
            roundedButton2.Image = Properties.Resources.Trash_Can___Lined;
            roundedButton2.Location = new Point(145, 0);
            roundedButton2.Margin = new Padding(0);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(35, 35);
            roundedButton2.TabIndex = 6;
            roundedButton2.TextColor = Color.Black;
            roundedButton2.UseVisualStyleBackColor = false;
            roundedButton2.Click += roundedButton2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelUserName);
            panel1.Controls.Add(ratingControl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 35);
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
            labelUserName.Size = new Size(498, 35);
            labelUserName.TabIndex = 6;
            labelUserName.Text = "User name";
            labelUserName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ratingControlFilmScore
            // 
            ratingControl1.BackColor = Color.White;
            ratingControl1.CurrentReting = null;
            ratingControl1.Dock = DockStyle.Right;
            ratingControl1.Editable = false;
            ratingControl1.Location = new Point(498, 0);
            ratingControl1.Margin = new Padding(0);
            ratingControl1.Name = "ratingControlFilmScore";
            ratingControl1.Size = new Size(110, 35);
            ratingControl1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 35);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(608, 44);
            panel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(labelDescription, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(608, 28);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.BackColor = Color.White;
            labelDescription.Dock = DockStyle.Top;
            labelDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescription.ForeColor = Color.Black;
            labelDescription.Location = new Point(3, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Padding = new Padding(0, 0, 0, 7);
            labelDescription.Size = new Size(602, 28);
            labelDescription.TabIndex = 5;
            labelDescription.Text = "Description";
            labelDescription.SizeChanged += labelDescription_SizeChanged_1;
            // 
            // PreviewEditableReview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(roundedPanel1);
            Name = "PreviewEditableReview";
            Size = new Size(628, 191);
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ui.RoundedPanel roundedPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private ui.RoundedButton roundedButton1;
        private Panel panel1;
        private System.Windows.Forms.Label labelUserName;
        private ui.RatingControl ratingControl1;
        private System.Windows.Forms.Label label4;
        private ui.RoundedButton roundedButton2;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelDescription;
    }
}
