namespace Animeteka.Forms
{
    partial class AnimeInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimeInfo));
            this.panelAnime = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.studioLabel = new System.Windows.Forms.Label();
            this.genresLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.episodesLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCharacters = new System.Windows.Forms.Panel();
            this.panelCast = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panelAnime.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAnime
            // 
            this.panelAnime.Controls.Add(this.panel2);
            this.panelAnime.Controls.Add(this.panel1);
            this.panelAnime.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAnime.Location = new System.Drawing.Point(0, 0);
            this.panelAnime.Name = "panelAnime";
            this.panelAnime.Size = new System.Drawing.Size(948, 320);
            this.panelAnime.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.title);
            this.panel2.Controls.Add(this.studioLabel);
            this.panel2.Controls.Add(this.genresLabel);
            this.panel2.Controls.Add(this.statusLabel);
            this.panel2.Controls.Add(this.durationLabel);
            this.panel2.Controls.Add(this.episodesLabel);
            this.panel2.Controls.Add(this.typeLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(241, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 320);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(707, 34);
            this.panel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Animeteka.Properties.Resources.settings;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(659, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.button1.Size = new System.Drawing.Size(48, 34);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(20, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Информация";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(16, 34);
            this.panel4.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.SystemColors.Highlight;
            this.title.Location = new System.Drawing.Point(20, 44);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(266, 18);
            this.title.TabIndex = 0;
            this.title.Text = "Стальной Алхимик: Братство";
            // 
            // studioLabel
            // 
            this.studioLabel.AutoSize = true;
            this.studioLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.studioLabel.Location = new System.Drawing.Point(20, 278);
            this.studioLabel.Name = "studioLabel";
            this.studioLabel.Size = new System.Drawing.Size(70, 17);
            this.studioLabel.TabIndex = 0;
            this.studioLabel.Text = "Студия: ";
            // 
            // genresLabel
            // 
            this.genresLabel.AutoSize = true;
            this.genresLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.genresLabel.Location = new System.Drawing.Point(20, 237);
            this.genresLabel.Name = "genresLabel";
            this.genresLabel.Size = new System.Drawing.Size(71, 17);
            this.genresLabel.TabIndex = 0;
            this.genresLabel.Text = "Жанры: ";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.statusLabel.Location = new System.Drawing.Point(20, 196);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(67, 17);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Статус: ";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.durationLabel.Location = new System.Drawing.Point(20, 155);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(184, 17);
            this.durationLabel.TabIndex = 0;
            this.durationLabel.Text = "Длительность эпизода: ";
            // 
            // episodesLabel
            // 
            this.episodesLabel.AutoSize = true;
            this.episodesLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.episodesLabel.Location = new System.Drawing.Point(20, 114);
            this.episodesLabel.Name = "episodesLabel";
            this.episodesLabel.Size = new System.Drawing.Size(83, 17);
            this.episodesLabel.TabIndex = 0;
            this.episodesLabel.Text = "Эпизоды: ";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.typeLabel.Location = new System.Drawing.Point(20, 73);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(46, 17);
            this.typeLabel.TabIndex = 0;
            this.typeLabel.Text = "Тип: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 320);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Animeteka.Properties.Resources.placeholder;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelCharacters
            // 
            this.panelCharacters.AutoSize = true;
            this.panelCharacters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCharacters.Location = new System.Drawing.Point(0, 320);
            this.panelCharacters.Name = "panelCharacters";
            this.panelCharacters.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panelCharacters.Size = new System.Drawing.Size(948, 20);
            this.panelCharacters.TabIndex = 5;
            // 
            // panelCast
            // 
            this.panelCast.AutoSize = true;
            this.panelCast.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCast.Location = new System.Drawing.Point(0, 340);
            this.panelCast.MinimumSize = new System.Drawing.Size(0, 300);
            this.panelCast.Name = "panelCast";
            this.panelCast.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panelCast.Size = new System.Drawing.Size(948, 300);
            this.panelCast.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(0, 640);
            this.button2.MinimumSize = new System.Drawing.Size(0, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(948, 50);
            this.button2.TabIndex = 0;
            this.button2.Text = "Смотреть онлайн";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AnimeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(965, 505);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panelCast);
            this.Controls.Add(this.panelCharacters);
            this.Controls.Add(this.panelAnime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnimeInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnimeOnly";
            this.panelAnime.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAnime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label studioLabel;
        private System.Windows.Forms.Label genresLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label episodesLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelCharacters;
        private System.Windows.Forms.Panel panelCast;
        public Bunifu.Framework.UI.BunifuCustomLabel title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
    }
}