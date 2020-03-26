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
            this.panelAnime = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelAnime.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panelAnime.Size = new System.Drawing.Size(931, 320);
            this.panelAnime.TabIndex = 4;
            // 
            // panel2
            // 
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
            this.panel2.Size = new System.Drawing.Size(626, 320);
            this.panel2.TabIndex = 2;
            // 
            // studioLabel
            // 
            this.studioLabel.AutoSize = true;
            this.studioLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.studioLabel.Location = new System.Drawing.Point(21, 246);
            this.studioLabel.Name = "studioLabel";
            this.studioLabel.Size = new System.Drawing.Size(70, 17);
            this.studioLabel.TabIndex = 5;
            this.studioLabel.Text = "Студия: ";
            // 
            // genresLabel
            // 
            this.genresLabel.AutoSize = true;
            this.genresLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.genresLabel.Location = new System.Drawing.Point(21, 205);
            this.genresLabel.Name = "genresLabel";
            this.genresLabel.Size = new System.Drawing.Size(71, 17);
            this.genresLabel.TabIndex = 4;
            this.genresLabel.Text = "Жанры: ";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.statusLabel.Location = new System.Drawing.Point(21, 164);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(67, 17);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "Статус: ";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.durationLabel.Location = new System.Drawing.Point(21, 123);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(184, 17);
            this.durationLabel.TabIndex = 2;
            this.durationLabel.Text = "Длительность эпизода: ";
            // 
            // episodesLabel
            // 
            this.episodesLabel.AutoSize = true;
            this.episodesLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.episodesLabel.Location = new System.Drawing.Point(21, 82);
            this.episodesLabel.Name = "episodesLabel";
            this.episodesLabel.Size = new System.Drawing.Size(83, 17);
            this.episodesLabel.TabIndex = 1;
            this.episodesLabel.Text = "Эпизоды: ";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.typeLabel.Location = new System.Drawing.Point(21, 41);
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
            this.panel1.TabIndex = 1;
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
            this.panelCharacters.Size = new System.Drawing.Size(931, 20);
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
            this.panelCast.Size = new System.Drawing.Size(931, 300);
            this.panelCast.TabIndex = 6;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.SystemColors.Highlight;
            this.title.Location = new System.Drawing.Point(21, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(266, 18);
            this.title.TabIndex = 6;
            this.title.Text = "Стальной Алхимик: Братство";
            // 
            // AnimeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 505);
            this.Controls.Add(this.panelCast);
            this.Controls.Add(this.panelCharacters);
            this.Controls.Add(this.panelAnime);
            this.Name = "AnimeInfo";
            this.Text = "AnimeInfo";
            this.panelAnime.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    }
}