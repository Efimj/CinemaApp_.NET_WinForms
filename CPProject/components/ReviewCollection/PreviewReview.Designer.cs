namespace CPProject.components
{
    partial class PreviewReview
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
            labelUserName = new System.Windows.Forms.Label();
            ratingControlScore = new ui.RatingControl();
            labelDate = new System.Windows.Forms.Label();
            tableLayoutPanelContent = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelDescription = new System.Windows.Forms.Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            roundedButtonBanUser = new ui.RoundedButton();
            roundedButtonDeleteReview = new ui.RoundedButton();
            roundedPanelContent = new ui.RoundedPanel();
            tableLayoutPanelContent.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            roundedPanelContent.SuspendLayout();
            SuspendLayout();
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Dock = DockStyle.Fill;
            labelUserName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUserName.ForeColor = Color.Black;
            labelUserName.Location = new Point(0, 0);
            labelUserName.Margin = new Padding(0);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(358, 40);
            labelUserName.TabIndex = 0;
            labelUserName.Text = "User name";
            labelUserName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ratingControlScore
            // 
            ratingControlScore.BackColor = Color.White;
            ratingControlScore.CurrentReting = null;
            ratingControlScore.Dock = DockStyle.Fill;
            ratingControlScore.Editable = false;
            ratingControlScore.Location = new Point(501, 0);
            ratingControlScore.Margin = new Padding(0);
            ratingControlScore.Name = "ratingControlScore";
            ratingControlScore.Size = new Size(106, 40);
            ratingControlScore.TabIndex = 2;
            // 
            // labelDate
            // 
            labelDate.Dock = DockStyle.Top;
            labelDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.ForeColor = Color.Black;
            labelDate.Location = new Point(0, 61);
            labelDate.Margin = new Padding(0);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(607, 31);
            labelDate.TabIndex = 4;
            labelDate.Text = "20.22.2022";
            labelDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanelContent
            // 
            tableLayoutPanelContent.AutoSize = true;
            tableLayoutPanelContent.ColumnCount = 1;
            tableLayoutPanelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelContent.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanelContent.Controls.Add(labelDate, 0, 2);
            tableLayoutPanelContent.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanelContent.Dock = DockStyle.Top;
            tableLayoutPanelContent.Location = new Point(10, 0);
            tableLayoutPanelContent.Margin = new Padding(0);
            tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            tableLayoutPanelContent.RowCount = 3;
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelContent.RowStyles.Add(new RowStyle());
            tableLayoutPanelContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanelContent.Size = new Size(607, 96);
            tableLayoutPanelContent.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(labelDescription, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 40);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(607, 21);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Dock = DockStyle.Top;
            labelDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescription.ForeColor = Color.Black;
            labelDescription.Location = new Point(0, 0);
            labelDescription.Margin = new Padding(0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(607, 21);
            labelDescription.TabIndex = 0;
            labelDescription.Text = "Description";
            labelDescription.Resize += labelDescription_Resize;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.AutoSize = true;
            tableLayoutPanel5.ColumnCount = 6;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.29792F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.7020788F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 76F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel2, 3, 0);
            tableLayoutPanel5.Controls.Add(labelUserName, 0, 0);
            tableLayoutPanel5.Controls.Add(ratingControlScore, 5, 0);
            tableLayoutPanel5.Dock = DockStyle.Top;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.Size = new Size(607, 40);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 0F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(roundedButtonBanUser, 2, 0);
            tableLayoutPanel2.Controls.Add(roundedButtonDeleteReview, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(417, 2);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(72, 36);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // roundedButtonBanUser
            // 
            roundedButtonBanUser.Autofocus = false;
            roundedButtonBanUser.BackColor = Color.White;
            roundedButtonBanUser.BackgroundColor = Color.White;
            roundedButtonBanUser.BorderColor = Color.FromArgb(224, 224, 224);
            roundedButtonBanUser.BorderRadius = 10;
            roundedButtonBanUser.BorderSize = 0;
            roundedButtonBanUser.Dock = DockStyle.Fill;
            roundedButtonBanUser.FlatAppearance.BorderSize = 0;
            roundedButtonBanUser.FlatStyle = FlatStyle.Flat;
            roundedButtonBanUser.FocusBorderColor = Color.Gray;
            roundedButtonBanUser.FocusBorderSize = 2;
            roundedButtonBanUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roundedButtonBanUser.ForeColor = Color.FromArgb(64, 64, 64);
            roundedButtonBanUser.Image = Properties.Resources.warn_black;
            roundedButtonBanUser.Location = new Point(36, 0);
            roundedButtonBanUser.Margin = new Padding(0);
            roundedButtonBanUser.Name = "roundedButtonBanUser";
            roundedButtonBanUser.Size = new Size(36, 36);
            roundedButtonBanUser.TabIndex = 6;
            roundedButtonBanUser.TextColor = Color.FromArgb(64, 64, 64);
            roundedButtonBanUser.UseVisualStyleBackColor = false;
            roundedButtonBanUser.Click += roundedButtonBanUser_Click;
            // 
            // roundedButtonDeleteReview
            // 
            roundedButtonDeleteReview.Autofocus = false;
            roundedButtonDeleteReview.BackColor = Color.White;
            roundedButtonDeleteReview.BackgroundColor = Color.White;
            roundedButtonDeleteReview.BorderColor = Color.FromArgb(224, 224, 224);
            roundedButtonDeleteReview.BorderRadius = 10;
            roundedButtonDeleteReview.BorderSize = 0;
            roundedButtonDeleteReview.Dock = DockStyle.Fill;
            roundedButtonDeleteReview.FlatAppearance.BorderSize = 0;
            roundedButtonDeleteReview.FlatStyle = FlatStyle.Flat;
            roundedButtonDeleteReview.FocusBorderColor = Color.Gray;
            roundedButtonDeleteReview.FocusBorderSize = 2;
            roundedButtonDeleteReview.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roundedButtonDeleteReview.ForeColor = Color.FromArgb(64, 64, 64);
            roundedButtonDeleteReview.Image = Properties.Resources.TrashBasket;
            roundedButtonDeleteReview.Location = new Point(0, 0);
            roundedButtonDeleteReview.Margin = new Padding(0);
            roundedButtonDeleteReview.Name = "roundedButtonDeleteReview";
            roundedButtonDeleteReview.Size = new Size(36, 36);
            roundedButtonDeleteReview.TabIndex = 5;
            roundedButtonDeleteReview.TextColor = Color.FromArgb(64, 64, 64);
            roundedButtonDeleteReview.UseVisualStyleBackColor = false;
            roundedButtonDeleteReview.Click += roundedButtonDeleteReview_Click;
            // 
            // roundedPanelContent
            // 
            roundedPanelContent.Autofocus = false;
            roundedPanelContent.AutoSize = true;
            roundedPanelContent.BackColor = Color.White;
            roundedPanelContent.BackgroundColor = Color.White;
            roundedPanelContent.BorderColor = Color.PaleVioletRed;
            roundedPanelContent.BorderRadius = 10;
            roundedPanelContent.BorderSize = 0;
            roundedPanelContent.Controls.Add(tableLayoutPanelContent);
            roundedPanelContent.Dock = DockStyle.Top;
            roundedPanelContent.FocusBorderColor = Color.Gray;
            roundedPanelContent.FocusBorderSize = 2;
            roundedPanelContent.ForeColor = Color.White;
            roundedPanelContent.Location = new Point(0, 0);
            roundedPanelContent.Name = "roundedPanelContent";
            roundedPanelContent.Padding = new Padding(10, 0, 10, 0);
            roundedPanelContent.Size = new Size(627, 96);
            roundedPanelContent.TabIndex = 1;
            roundedPanelContent.TextColor = Color.White;
            // 
            // PreviewReview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(roundedPanelContent);
            Margin = new Padding(0);
            Name = "PreviewReview";
            Size = new Size(627, 369);
            Load += PreviewReview_Load;
            tableLayoutPanelContent.ResumeLayout(false);
            tableLayoutPanelContent.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            roundedPanelContent.ResumeLayout(false);
            roundedPanelContent.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ui.RatingControl ratingControlScore;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelDate;
        private TableLayoutPanel tableLayoutPanelContent;
        private TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label labelDescription;
        private ui.RoundedPanel roundedPanelContent;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private ui.RoundedButton roundedButtonBanUser;
        private ui.RoundedButton roundedButtonDeleteReview;
    }
}
