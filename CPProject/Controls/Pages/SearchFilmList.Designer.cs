namespace CPProject.Controls
{
    partial class SearchFilmList
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
            panelHeader = new Panel();
            roundedPanel1 = new components.ui.RoundedPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            roundedButtonCreateFilm = new components.ui.RoundedButton();
            roundedPanel5 = new components.ui.RoundedPanel();
            roundedPanel7 = new components.ui.RoundedPanel();
            customComboBoxFilmGenre = new components.ui.CustomComboBox();
            roundedPanel2 = new components.ui.RoundedPanel();
            roundedPanel3 = new components.ui.RoundedPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            roundedSearchField2 = new components.ui.RoundedSearchField();
            flowLayoutPanelFilms = new FlowLayoutPanel();
            panelHeader.SuspendLayout();
            roundedPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            roundedPanel5.SuspendLayout();
            roundedPanel7.SuspendLayout();
            roundedPanel2.SuspendLayout();
            roundedPanel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(224, 224, 224);
            panelHeader.Controls.Add(roundedPanel1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(999, 55);
            panelHeader.TabIndex = 3;
            // 
            // roundedPanel1
            // 
            roundedPanel1.Autofocus = false;
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BackgroundColor = Color.White;
            roundedPanel1.BorderColor = Color.FromArgb(224, 224, 224);
            roundedPanel1.BorderRadius = 15;
            roundedPanel1.BorderSize = 1;
            roundedPanel1.Controls.Add(tableLayoutPanel2);
            roundedPanel1.Dock = DockStyle.Top;
            roundedPanel1.FocusBorderColor = Color.Gray;
            roundedPanel1.FocusBorderSize = 0;
            roundedPanel1.ForeColor = Color.White;
            roundedPanel1.Location = new Point(0, 0);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Padding = new Padding(18, 2, 18, 2);
            roundedPanel1.Size = new Size(999, 55);
            roundedPanel1.TabIndex = 5;
            roundedPanel1.TextColor = Color.White;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 230F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(roundedButtonCreateFilm, 4, 1);
            tableLayoutPanel2.Controls.Add(roundedPanel5, 2, 1);
            tableLayoutPanel2.Controls.Add(roundedPanel2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(18, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(963, 51);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // roundedButtonCreateFilm
            // 
            roundedButtonCreateFilm.Autofocus = false;
            roundedButtonCreateFilm.BackColor = Color.White;
            roundedButtonCreateFilm.BackgroundColor = Color.White;
            roundedButtonCreateFilm.BorderColor = Color.Silver;
            roundedButtonCreateFilm.BorderRadius = 10;
            roundedButtonCreateFilm.BorderSize = 1;
            roundedButtonCreateFilm.Dock = DockStyle.Fill;
            roundedButtonCreateFilm.FlatAppearance.BorderSize = 0;
            roundedButtonCreateFilm.FlatStyle = FlatStyle.Flat;
            roundedButtonCreateFilm.FocusBorderColor = Color.Gray;
            roundedButtonCreateFilm.FocusBorderSize = 2;
            roundedButtonCreateFilm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roundedButtonCreateFilm.ForeColor = Color.FromArgb(64, 64, 64);
            roundedButtonCreateFilm.Image = Properties.Resources.edit_icon;
            roundedButtonCreateFilm.Location = new Point(410, 5);
            roundedButtonCreateFilm.Margin = new Padding(0);
            roundedButtonCreateFilm.Name = "roundedButtonCreateFilm";
            roundedButtonCreateFilm.Padding = new Padding(10, 0, 0, 0);
            roundedButtonCreateFilm.Size = new Size(170, 40);
            roundedButtonCreateFilm.TabIndex = 0;
            roundedButtonCreateFilm.Text = "Create film";
            roundedButtonCreateFilm.TextColor = Color.FromArgb(64, 64, 64);
            roundedButtonCreateFilm.TextImageRelation = TextImageRelation.ImageBeforeText;
            roundedButtonCreateFilm.UseVisualStyleBackColor = false;
            roundedButtonCreateFilm.Click += roundedButton1_Click;
            // 
            // roundedPanel5
            // 
            roundedPanel5.Autofocus = false;
            roundedPanel5.BackColor = Color.White;
            roundedPanel5.BackgroundColor = Color.White;
            roundedPanel5.BorderColor = Color.Silver;
            roundedPanel5.BorderRadius = 10;
            roundedPanel5.BorderSize = 1;
            roundedPanel5.Controls.Add(roundedPanel7);
            roundedPanel5.Dock = DockStyle.Fill;
            roundedPanel5.FocusBorderColor = Color.Gray;
            roundedPanel5.FocusBorderSize = 2;
            roundedPanel5.ForeColor = Color.White;
            roundedPanel5.Location = new Point(235, 5);
            roundedPanel5.Margin = new Padding(0);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Padding = new Padding(2);
            roundedPanel5.Size = new Size(170, 40);
            roundedPanel5.TabIndex = 6;
            roundedPanel5.TextColor = Color.White;
            // 
            // roundedPanel7
            // 
            roundedPanel7.Autofocus = false;
            roundedPanel7.BackColor = Color.FromArgb(224, 224, 224);
            roundedPanel7.BackgroundColor = Color.FromArgb(224, 224, 224);
            roundedPanel7.BorderColor = Color.White;
            roundedPanel7.BorderRadius = 5;
            roundedPanel7.BorderSize = 0;
            roundedPanel7.Controls.Add(customComboBoxFilmGenre);
            roundedPanel7.Dock = DockStyle.Fill;
            roundedPanel7.FocusBorderColor = Color.Gray;
            roundedPanel7.FocusBorderSize = 2;
            roundedPanel7.ForeColor = Color.White;
            roundedPanel7.Location = new Point(2, 2);
            roundedPanel7.Margin = new Padding(0);
            roundedPanel7.Name = "roundedPanel7";
            roundedPanel7.Size = new Size(166, 36);
            roundedPanel7.TabIndex = 3;
            roundedPanel7.TextColor = Color.White;
            // 
            // customComboBoxFilmGenre
            // 
            customComboBoxFilmGenre.BackColor = Color.White;
            customComboBoxFilmGenre.BorderColor = Color.White;
            customComboBoxFilmGenre.BorderRadius = 5;
            customComboBoxFilmGenre.BorderSize = 0;
            customComboBoxFilmGenre.Dock = DockStyle.Fill;
            customComboBoxFilmGenre.DropDownStyle = ComboBoxStyle.DropDown;
            customComboBoxFilmGenre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customComboBoxFilmGenre.ForeColor = Color.FromArgb(64, 64, 64);
            customComboBoxFilmGenre.IconColor = Color.FromArgb(64, 64, 64);
            customComboBoxFilmGenre.ListBackColor = Color.White;
            customComboBoxFilmGenre.ListTextColor = Color.FromArgb(64, 64, 64);
            customComboBoxFilmGenre.Location = new Point(0, 0);
            customComboBoxFilmGenre.Margin = new Padding(0);
            customComboBoxFilmGenre.MinimumSize = new Size(130, 25);
            customComboBoxFilmGenre.Name = "customComboBoxFilmGenre";
            customComboBoxFilmGenre.Size = new Size(166, 36);
            customComboBoxFilmGenre.TabIndex = 0;
            customComboBoxFilmGenre.Texts = "";
            customComboBoxFilmGenre.OnSelectedIndexChanged += customComboBoxFilmGenre_OnSelectedIndexChanged;
            // 
            // roundedPanel2
            // 
            roundedPanel2.Autofocus = false;
            roundedPanel2.BackColor = Color.White;
            roundedPanel2.BackgroundColor = Color.White;
            roundedPanel2.BorderColor = Color.Gray;
            roundedPanel2.BorderRadius = 10;
            roundedPanel2.BorderSize = 1;
            roundedPanel2.Controls.Add(roundedPanel3);
            roundedPanel2.Dock = DockStyle.Fill;
            roundedPanel2.FocusBorderColor = Color.Gray;
            roundedPanel2.FocusBorderSize = 2;
            roundedPanel2.ForeColor = Color.White;
            roundedPanel2.Location = new Point(0, 5);
            roundedPanel2.Margin = new Padding(0);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Padding = new Padding(2);
            roundedPanel2.Size = new Size(230, 40);
            roundedPanel2.TabIndex = 0;
            roundedPanel2.TextColor = Color.White;
            // 
            // roundedPanel3
            // 
            roundedPanel3.Autofocus = false;
            roundedPanel3.BackColor = Color.White;
            roundedPanel3.BackgroundColor = Color.White;
            roundedPanel3.BorderColor = Color.Gray;
            roundedPanel3.BorderRadius = 10;
            roundedPanel3.BorderSize = 0;
            roundedPanel3.Controls.Add(tableLayoutPanel3);
            roundedPanel3.Dock = DockStyle.Fill;
            roundedPanel3.FocusBorderColor = Color.Gray;
            roundedPanel3.FocusBorderSize = 2;
            roundedPanel3.ForeColor = Color.White;
            roundedPanel3.Location = new Point(2, 2);
            roundedPanel3.Margin = new Padding(0);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(226, 36);
            roundedPanel3.TabIndex = 1;
            roundedPanel3.TextColor = Color.White;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel3.Controls.Add(roundedSearchField2, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(226, 36);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.SearchIcon;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // roundedSearchField2
            // 
            roundedSearchField2.BackColor = SystemColors.Window;
            roundedSearchField2.BorderColor = Color.White;
            roundedSearchField2.BorderFocusColor = Color.White;
            roundedSearchField2.BorderRadius = 10;
            roundedSearchField2.BorderSize = 1;
            roundedSearchField2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            roundedSearchField2.ForeColor = Color.FromArgb(64, 64, 64);
            roundedSearchField2.Location = new Point(40, 0);
            roundedSearchField2.Margin = new Padding(0);
            roundedSearchField2.Multiline = false;
            roundedSearchField2.Name = "roundedSearchField2";
            roundedSearchField2.Padding = new Padding(0, 8, 10, 4);
            roundedSearchField2.PasswordChar = false;
            roundedSearchField2.PlaceholderColor = Color.DimGray;
            roundedSearchField2.PlaceholderText = "The Hateful Eight";
            roundedSearchField2.Size = new Size(186, 38);
            roundedSearchField2.TabIndex = 1;
            roundedSearchField2.Texts = "";
            roundedSearchField2.UnderlinedStyle = false;
            roundedSearchField2._TextChanged += roundedSearchField2__TextChanged;
            // 
            // flowLayoutPanelFilms
            // 
            flowLayoutPanelFilms.AutoScroll = true;
            flowLayoutPanelFilms.Dock = DockStyle.Fill;
            flowLayoutPanelFilms.Location = new Point(0, 55);
            flowLayoutPanelFilms.Margin = new Padding(0);
            flowLayoutPanelFilms.Name = "flowLayoutPanelFilms";
            flowLayoutPanelFilms.Padding = new Padding(0, 5, 0, 0);
            flowLayoutPanelFilms.Size = new Size(999, 540);
            flowLayoutPanelFilms.TabIndex = 4;
            // 
            // SearchFilmList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(flowLayoutPanelFilms);
            Controls.Add(panelHeader);
            Margin = new Padding(0);
            Name = "SearchFilmList";
            Size = new Size(999, 595);
            Load += SearchFilmList_Load;
            panelHeader.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            roundedPanel5.ResumeLayout(false);
            roundedPanel7.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            roundedPanel3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private FlowLayoutPanel flowLayoutPanelFilms;
#pragma warning disable CS0169 // Поле "SearchFilmList.buttonCreateNewFilm" никогда не используется.
        private components.CustomButton buttonCreateNewFilm;
        private components.ui.RoundedPanel roundedPanel1;
        private components.ui.RoundedSearchField roundedSearchField2;
        private components.ui.RoundedButton roundedButtonCreateFilm;
        private TableLayoutPanel tableLayoutPanel2;
        private components.ui.RoundedPanel roundedPanel2;
        private components.ui.RoundedPanel roundedPanel3;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBox1;
        private components.ui.RoundedPanel roundedPanel5;
        private components.ui.RoundedPanel roundedPanel7;
        private components.ui.CustomComboBox customComboBoxFilmGenre;
    }
}
