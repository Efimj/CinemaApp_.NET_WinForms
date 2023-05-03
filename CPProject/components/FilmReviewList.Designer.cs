namespace CPProject.components
{
    partial class FilmReviewList
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
            tableLayoutPanel9 = new TableLayoutPanel();
            roundedPanel4 = new ui.RoundedPanel();
            roundedPanel6 = new ui.RoundedPanel();
            comboBoxFilterReview = new ui.CustomComboBox();
            label11 = new System.Windows.Forms.Label();
            labelInformation = new System.Windows.Forms.Label();
            roundedPanel1 = new ui.RoundedPanel();
            panel3 = new Panel();
            flowLayoutPanelReviews = new FlowLayoutPanel();
            customerReview = new ReviewCollection.CustomerReview();
            tableLayoutPanel9.SuspendLayout();
            roundedPanel4.SuspendLayout();
            roundedPanel6.SuspendLayout();
            roundedPanel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 3;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 246F));
            tableLayoutPanel9.Controls.Add(roundedPanel4, 1, 0);
            tableLayoutPanel9.Controls.Add(label11, 0, 0);
            tableLayoutPanel9.Controls.Add(labelInformation, 2, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(0, 0);
            tableLayoutPanel9.Margin = new Padding(0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.Padding = new Padding(0, 10, 0, 10);
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(820, 55);
            tableLayoutPanel9.TabIndex = 1;
            // 
            // roundedPanel4
            // 
            roundedPanel4.Autofocus = false;
            roundedPanel4.BackColor = Color.White;
            roundedPanel4.BackgroundColor = Color.White;
            roundedPanel4.BorderColor = Color.FromArgb(224, 224, 224);
            roundedPanel4.BorderRadius = 10;
            roundedPanel4.BorderSize = 1;
            roundedPanel4.Controls.Add(roundedPanel6);
            roundedPanel4.FocusBorderColor = Color.Gray;
            roundedPanel4.FocusBorderSize = 2;
            roundedPanel4.ForeColor = Color.White;
            roundedPanel4.Location = new Point(95, 10);
            roundedPanel4.Margin = new Padding(0);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Padding = new Padding(2);
            roundedPanel4.Size = new Size(190, 35);
            roundedPanel4.TabIndex = 3;
            roundedPanel4.TextColor = Color.White;
            // 
            // roundedPanel6
            // 
            roundedPanel6.Autofocus = false;
            roundedPanel6.BackColor = Color.FromArgb(224, 224, 224);
            roundedPanel6.BackgroundColor = Color.FromArgb(224, 224, 224);
            roundedPanel6.BorderColor = Color.White;
            roundedPanel6.BorderRadius = 10;
            roundedPanel6.BorderSize = 0;
            roundedPanel6.Controls.Add(comboBoxFilterReview);
            roundedPanel6.Dock = DockStyle.Fill;
            roundedPanel6.FocusBorderColor = Color.Gray;
            roundedPanel6.FocusBorderSize = 2;
            roundedPanel6.ForeColor = Color.White;
            roundedPanel6.Location = new Point(2, 2);
            roundedPanel6.Margin = new Padding(0);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(186, 31);
            roundedPanel6.TabIndex = 3;
            roundedPanel6.TextColor = Color.White;
            // 
            // comboBoxFilterReview
            // 
            comboBoxFilterReview.BackColor = Color.White;
            comboBoxFilterReview.BorderColor = Color.MediumSlateBlue;
            comboBoxFilterReview.BorderRadius = 15;
            comboBoxFilterReview.BorderSize = 0;
            comboBoxFilterReview.Dock = DockStyle.Fill;
            comboBoxFilterReview.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxFilterReview.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFilterReview.ForeColor = Color.FromArgb(64, 64, 64);
            comboBoxFilterReview.IconColor = Color.MediumSlateBlue;
            comboBoxFilterReview.ListBackColor = Color.White;
            comboBoxFilterReview.ListTextColor = Color.FromArgb(64, 64, 64);
            comboBoxFilterReview.Location = new Point(0, 0);
            comboBoxFilterReview.Margin = new Padding(0);
            comboBoxFilterReview.MinimumSize = new Size(130, 30);
            comboBoxFilterReview.Name = "comboBoxFilterReview";
            comboBoxFilterReview.Size = new Size(186, 31);
            comboBoxFilterReview.TabIndex = 0;
            comboBoxFilterReview.Texts = "";
            comboBoxFilterReview.OnSelectedIndexChanged += comboBoxFilterReview_OnSelectedIndexChanged;
            // 
            // label11
            // 
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(0, 10);
            label11.Margin = new Padding(0);
            label11.Name = "label11";
            label11.Padding = new Padding(10, 0, 0, 0);
            label11.Size = new Size(95, 35);
            label11.TabIndex = 1;
            label11.Text = "Reviews";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelInformation
            // 
            labelInformation.Dock = DockStyle.Fill;
            labelInformation.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelInformation.ForeColor = Color.IndianRed;
            labelInformation.Location = new Point(574, 10);
            labelInformation.Margin = new Padding(0);
            labelInformation.Name = "labelInformation";
            labelInformation.Size = new Size(246, 35);
            labelInformation.TabIndex = 4;
            labelInformation.Text = "Your comments are not visible because you are blocked.";
            // 
            // roundedPanel1
            // 
            roundedPanel1.Autofocus = false;
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BackgroundColor = Color.White;
            roundedPanel1.BorderColor = Color.White;
            roundedPanel1.BorderRadius = 10;
            roundedPanel1.BorderSize = 0;
            roundedPanel1.Controls.Add(tableLayoutPanel9);
            roundedPanel1.Dock = DockStyle.Top;
            roundedPanel1.FocusBorderColor = Color.Gray;
            roundedPanel1.FocusBorderSize = 2;
            roundedPanel1.ForeColor = Color.White;
            roundedPanel1.Location = new Point(0, 0);
            roundedPanel1.Margin = new Padding(0);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(820, 55);
            roundedPanel1.TabIndex = 2;
            roundedPanel1.TextColor = Color.White;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(flowLayoutPanelReviews);
            panel3.Controls.Add(customerReview);
            panel3.Controls.Add(roundedPanel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(820, 283);
            panel3.TabIndex = 3;
            // 
            // flowLayoutPanelReviews
            // 
            flowLayoutPanelReviews.AutoSize = true;
            flowLayoutPanelReviews.Dock = DockStyle.Top;
            flowLayoutPanelReviews.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelReviews.Location = new Point(0, 196);
            flowLayoutPanelReviews.Margin = new Padding(0);
            flowLayoutPanelReviews.MinimumSize = new Size(650, 0);
            flowLayoutPanelReviews.Name = "flowLayoutPanelReviews";
            flowLayoutPanelReviews.Padding = new Padding(0, 10, 0, 10);
            flowLayoutPanelReviews.Size = new Size(820, 20);
            flowLayoutPanelReviews.TabIndex = 11;
            flowLayoutPanelReviews.WrapContents = false;
            // 
            // customerReview
            // 
            customerReview.AutoSize = true;
            customerReview.BackColor = Color.FromArgb(224, 224, 224);
            customerReview.DeleteReview = null;
            customerReview.Dock = DockStyle.Top;
            customerReview.EditableReviewState = EditableReviewCollection.EditableReviewState.Default;
            customerReview.Location = new Point(0, 55);
            customerReview.Margin = new Padding(0);
            customerReview.Name = "customerReview";
            customerReview.Padding = new Padding(0, 10, 0, 10);
            customerReview.Review = null;
            customerReview.SaveReview = null;
            customerReview.Size = new Size(820, 141);
            customerReview.TabIndex = 9;
            customerReview.UserName = null;
            // 
            // FilmReviewList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(panel3);
            Name = "FilmReviewList";
            Size = new Size(820, 283);
            Load += FilmReviewList_Load;
            tableLayoutPanel9.ResumeLayout(false);
            roundedPanel4.ResumeLayout(false);
            roundedPanel6.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel9;
        private ui.RoundedPanel roundedPanel4;
        private ui.RoundedPanel roundedPanel6;
        private ui.CustomComboBox comboBoxFilterReview;
        private System.Windows.Forms.Label label11;
        private ui.RoundedPanel roundedPanel1;
        private Panel panel3;
        private ReviewCollection.CustomerReview customerReview;
        private FlowLayoutPanel flowLayoutPanelReviews;
        private System.Windows.Forms.Label labelInformation;
    }
}
