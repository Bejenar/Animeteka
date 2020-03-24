namespace Animeteka.Forms
{
    partial class WelcomePage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            BunifuAnimatorNS.Animation animation7 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation8 = new BunifuAnimatorNS.Animation();
            this.pictureBoxAnime = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.языкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.русскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.английскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAnime = new System.Windows.Forms.Panel();
            this.panelButtonAnime = new System.Windows.Forms.Panel();
            this.buttonAnime = new System.Windows.Forms.Button();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelButtonCompany = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelButtonPerson = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelButtonCharacter = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnime)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panelAnime.SuspendLayout();
            this.panelButtonAnime.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelButtonCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelButtonPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panelButtonCharacter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAnime
            // 
            resources.ApplyResources(this.pictureBoxAnime, "pictureBoxAnime");
            this.bunifuTransition1.SetDecoration(this.pictureBoxAnime, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBoxAnime, BunifuAnimatorNS.DecorationType.None);
            this.pictureBoxAnime.Image = global::Animeteka.Properties.Resources.bg_welcome;
            this.pictureBoxAnime.Name = "pictureBoxAnime";
            this.pictureBoxAnime.TabStop = false;
            this.pictureBoxAnime.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            // 
            // toolStrip1
            // 
            this.bunifuTransition2.SetDecoration(this.toolStrip1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.toolStrip1, BunifuAnimatorNS.DecorationType.None);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.языкToolStripMenuItem});
            resources.ApplyResources(this.toolStripDropDownButton1, "toolStripDropDownButton1");
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            // 
            // языкToolStripMenuItem
            // 
            this.языкToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.русскийToolStripMenuItem,
            this.английскийToolStripMenuItem});
            this.языкToolStripMenuItem.Name = "языкToolStripMenuItem";
            resources.ApplyResources(this.языкToolStripMenuItem, "языкToolStripMenuItem");
            // 
            // русскийToolStripMenuItem
            // 
            this.русскийToolStripMenuItem.Name = "русскийToolStripMenuItem";
            resources.ApplyResources(this.русскийToolStripMenuItem, "русскийToolStripMenuItem");
            this.русскийToolStripMenuItem.Click += new System.EventHandler(this.русскийToolStripMenuItem_Click);
            // 
            // английскийToolStripMenuItem
            // 
            this.английскийToolStripMenuItem.Name = "английскийToolStripMenuItem";
            resources.ApplyResources(this.английскийToolStripMenuItem, "английскийToolStripMenuItem");
            this.английскийToolStripMenuItem.Click += new System.EventHandler(this.английскийToolStripMenuItem_Click);
            // 
            // panelAnime
            // 
            resources.ApplyResources(this.panelAnime, "panelAnime");
            this.panelAnime.BackColor = System.Drawing.Color.Transparent;
            this.panelAnime.Controls.Add(this.panelButtonAnime);
            this.panelAnime.Controls.Add(this.pictureBoxAnime);
            this.bunifuTransition2.SetDecoration(this.panelAnime, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panelAnime, BunifuAnimatorNS.DecorationType.None);
            this.panelAnime.Name = "panelAnime";
            // 
            // panelButtonAnime
            // 
            this.panelButtonAnime.BackColor = System.Drawing.SystemColors.Control;
            this.panelButtonAnime.Controls.Add(this.buttonAnime);
            this.bunifuTransition2.SetDecoration(this.panelButtonAnime, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panelButtonAnime, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.panelButtonAnime, "panelButtonAnime");
            this.panelButtonAnime.Name = "panelButtonAnime";
            // 
            // buttonAnime
            // 
            this.bunifuTransition1.SetDecoration(this.buttonAnime, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.buttonAnime, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.buttonAnime, "buttonAnime");
            this.buttonAnime.Name = "buttonAnime";
            this.buttonAnime.UseVisualStyleBackColor = true;
            this.buttonAnime.Click += new System.EventHandler(this.button_advanced_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation7.AnimateOnlyDifferences = true;
            animation7.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.BlindCoeff")));
            animation7.LeafCoeff = 0F;
            animation7.MaxTime = 1F;
            animation7.MinTime = 0F;
            animation7.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicCoeff")));
            animation7.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicShift")));
            animation7.MosaicSize = 0;
            animation7.Padding = new System.Windows.Forms.Padding(0);
            animation7.RotateCoeff = 0F;
            animation7.RotateLimit = 0F;
            animation7.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.ScaleCoeff")));
            animation7.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.SlideCoeff")));
            animation7.TimeCoeff = 0F;
            animation7.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation7;
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.bunifuTransition2.Cursor = null;
            animation8.AnimateOnlyDifferences = true;
            animation8.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.BlindCoeff")));
            animation8.LeafCoeff = 0F;
            animation8.MaxTime = 1F;
            animation8.MinTime = 0F;
            animation8.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicCoeff")));
            animation8.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicShift")));
            animation8.MosaicSize = 1;
            animation8.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation8.RotateCoeff = 0F;
            animation8.RotateLimit = 0F;
            animation8.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.ScaleCoeff")));
            animation8.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.SlideCoeff")));
            animation8.TimeCoeff = 2F;
            animation8.TransparencyCoeff = 0F;
            this.bunifuTransition2.DefaultAnimation = animation8;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panelButtonCompany);
            this.panel1.Controls.Add(this.pictureBox1);
            this.bunifuTransition2.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Name = "panel1";
            // 
            // panelButtonCompany
            // 
            this.panelButtonCompany.BackColor = System.Drawing.SystemColors.Control;
            this.panelButtonCompany.Controls.Add(this.button1);
            this.bunifuTransition2.SetDecoration(this.panelButtonCompany, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panelButtonCompany, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.panelButtonCompany, "panelButtonCompany");
            this.panelButtonCompany.Name = "panelButtonCompany";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::Animeteka.Properties.Resources.bg_welcome;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter_1);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panelButtonPerson);
            this.panel3.Controls.Add(this.pictureBox2);
            this.bunifuTransition2.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Name = "panel3";
            // 
            // panelButtonPerson
            // 
            this.panelButtonPerson.BackColor = System.Drawing.SystemColors.Control;
            this.panelButtonPerson.Controls.Add(this.button2);
            this.bunifuTransition2.SetDecoration(this.panelButtonPerson, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panelButtonPerson, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.panelButtonPerson, "panelButtonPerson");
            this.panelButtonPerson.Name = "panelButtonPerson";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::Animeteka.Properties.Resources.bg_welcome;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.panelButtonCharacter);
            this.panel5.Controls.Add(this.pictureBox3);
            this.bunifuTransition2.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.panel5.Name = "panel5";
            // 
            // panelButtonCharacter
            // 
            this.panelButtonCharacter.BackColor = System.Drawing.SystemColors.Control;
            this.panelButtonCharacter.Controls.Add(this.button3);
            this.bunifuTransition2.SetDecoration(this.panelButtonCharacter, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panelButtonCharacter, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.panelButtonCharacter, "panelButtonCharacter");
            this.panelButtonCharacter.Name = "panelButtonCharacter";
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.bunifuTransition1.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = global::Animeteka.Properties.Resources.bg_welcome;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            // 
            // button1
            // 
            this.bunifuTransition1.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.bunifuTransition1.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.bunifuTransition1.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // WelcomePage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Animeteka.Properties.Resources.login_bg;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAnime);
            this.Controls.Add(this.toolStrip1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "WelcomePage";
            this.MouseEnter += new System.EventHandler(this.WelcomePage_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnime)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelAnime.ResumeLayout(false);
            this.panelButtonAnime.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelButtonCompany.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panelButtonPerson.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panelButtonCharacter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAnime;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem языкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem русскийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem английскийToolStripMenuItem;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Panel panelAnime;
        private System.Windows.Forms.Panel panelButtonAnime;
        private System.Windows.Forms.Button buttonAnime;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelButtonCompany;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelButtonPerson;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelButtonCharacter;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}