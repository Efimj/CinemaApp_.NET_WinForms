namespace CPProject.components
{
    partial class FilmPreviewCard
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
            ratingControl1 = new ui.RatingControl();
            labelTitle = new System.Windows.Forms.Label();
            roundedPanel2 = new ui.RoundedPanel();
            pictureBoxImage = new PictureBox();
            roundedPanel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.Autofocus = false;
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BackgroundColor = Color.White;
            roundedPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            roundedPanel1.BorderColor = Color.PaleVioletRed;
            roundedPanel1.BorderRadius = 29;
            roundedPanel1.BorderSize = 0;
            roundedPanel1.Controls.Add(ratingControl1);
            roundedPanel1.Controls.Add(labelTitle);
            roundedPanel1.Controls.Add(roundedPanel2);
            roundedPanel1.Dock = DockStyle.Fill;
            roundedPanel1.FocusBorderColor = Color.MediumSlateBlue;
            roundedPanel1.FocusBorderSize = 2;
            roundedPanel1.ForeColor = Color.White;
            roundedPanel1.Location = new Point(0, 0);
            roundedPanel1.Margin = new Padding(0);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Padding = new Padding(4);
            roundedPanel1.Size = new Size(250, 370);
            roundedPanel1.TabIndex = 0;
            roundedPanel1.TextColor = Color.White;
            // 
            // ratingControl1
            // 
            ratingControl1.BackColor = Color.White;
            ratingControl1.CurrentReting = null;
            ratingControl1.Editable = false;
            ratingControl1.Location = new Point(70, 337);
            ratingControl1.Margin = new Padding(0);
            ratingControl1.Name = "ratingControl1";
            ratingControl1.Padding = new Padding(0, 1, 0, 0);
            ratingControl1.Size = new Size(112, 25);
            ratingControl1.TabIndex = 2;
            // 
            // labelTitle
            // 
            labelTitle.Dock = DockStyle.Top;
            labelTitle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.Black;
            labelTitle.Location = new Point(4, 303);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(242, 34);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "The Hateful Eight";
            labelTitle.TextAlign = ContentAlignment.BottomCenter;
            // 
            // roundedPanel2
            // 
            roundedPanel2.Autofocus = false;
            roundedPanel2.BackColor = Color.Gainsboro;
            roundedPanel2.BackgroundColor = Color.Gainsboro;
            roundedPanel2.BorderColor = Color.PaleVioletRed;
            roundedPanel2.BorderRadius = 25;
            roundedPanel2.BorderSize = 0;
            roundedPanel2.Controls.Add(pictureBoxImage);
            roundedPanel2.Dock = DockStyle.Top;
            roundedPanel2.FocusBorderColor = Color.Gray;
            roundedPanel2.FocusBorderSize = 2;
            roundedPanel2.ForeColor = Color.White;
            roundedPanel2.Location = new Point(4, 4);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(242, 299);
            roundedPanel2.TabIndex = 0;
            roundedPanel2.TextColor = Color.White;
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Dock = DockStyle.Fill;
            pictureBoxImage.Location = new Point(0, 0);
            pictureBoxImage.Margin = new Padding(0);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(242, 299);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImage.TabIndex = 0;
            pictureBoxImage.TabStop = false;
            // 
            // FilmPreviewCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(roundedPanel1);
            Margin = new Padding(0);
            MaximumSize = new Size(250, 370);
            Name = "FilmPreviewCard";
            Size = new Size(250, 370);
            VisibleChanged += FilmPreviewCard_VisibleChanged;
            roundedPanel1.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ui.RoundedPanel roundedPanel1;
        private ui.RoundedPanel roundedPanel2;
        private PictureBox pictureBoxImage;
        private System.Windows.Forms.Label labelTitle;
        private ui.RatingControl ratingControl1;
    }
}
