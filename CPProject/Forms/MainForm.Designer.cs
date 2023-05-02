namespace CPProject
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            panelNavigation = new Panel();
            panelPage = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1284, 1);
            panel1.TabIndex = 3;
            // 
            // panelNavigation
            // 
            panelNavigation.Dock = DockStyle.Left;
            panelNavigation.Location = new Point(0, 1);
            panelNavigation.Name = "panelNavigation";
            panelNavigation.Padding = new Padding(8);
            panelNavigation.Size = new Size(220, 740);
            panelNavigation.TabIndex = 4;
            // 
            // panelPage
            // 
            panelPage.Dock = DockStyle.Fill;
            panelPage.Location = new Point(220, 1);
            panelPage.Name = "panelPage";
            panelPage.Padding = new Padding(0, 8, 0, 0);
            panelPage.Size = new Size(1064, 740);
            panelPage.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1284, 741);
            Controls.Add(panelPage);
            Controls.Add(panelNavigation);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1300, 760);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CinemaPlanet";
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
#pragma warning disable CS0169 // Поле "MainForm.nbAuthorization1" никогда не используется.
        private NBAuthorization nbAuthorization1;
        private Panel panelNavigation;
        private Panel panelPage;
#pragma warning restore CS0169 // Поле "MainForm.nbAuthorization1" никогда не используется.
    }
}