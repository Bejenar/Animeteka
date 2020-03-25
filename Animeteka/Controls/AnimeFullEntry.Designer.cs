namespace Animeteka.Controls
{
    partial class AnimeFullEntry
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.typeLabel = new System.Windows.Forms.Label();
            this.episodesLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.genresLabel = new System.Windows.Forms.Label();
            this.studioLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.animeCast1 = new Animeteka.Controls.AnimeCast();
            this.animeCharacters1 = new Animeteka.Controls.AnimeCharacters();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
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
            // panel2
            // 
            this.panel2.Controls.Add(this.studioLabel);
            this.panel2.Controls.Add(this.genresLabel);
            this.panel2.Controls.Add(this.statusLabel);
            this.panel2.Controls.Add(this.durationLabel);
            this.panel2.Controls.Add(this.episodesLabel);
            this.panel2.Controls.Add(this.typeLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(241, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 320);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(880, 320);
            this.panel3.TabIndex = 3;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.typeLabel.Location = new System.Drawing.Point(21, 41);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(41, 17);
            this.typeLabel.TabIndex = 0;
            this.typeLabel.Text = "Тип:";
            // 
            // episodesLabel
            // 
            this.episodesLabel.AutoSize = true;
            this.episodesLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.episodesLabel.Location = new System.Drawing.Point(21, 82);
            this.episodesLabel.Name = "episodesLabel";
            this.episodesLabel.Size = new System.Drawing.Size(78, 17);
            this.episodesLabel.TabIndex = 1;
            this.episodesLabel.Text = "Эпизоды:";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.durationLabel.Location = new System.Drawing.Point(21, 123);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(179, 17);
            this.durationLabel.TabIndex = 2;
            this.durationLabel.Text = "Длительность эпизода:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.statusLabel.Location = new System.Drawing.Point(21, 164);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(62, 17);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "Статус:";
            // 
            // genresLabel
            // 
            this.genresLabel.AutoSize = true;
            this.genresLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.genresLabel.Location = new System.Drawing.Point(21, 205);
            this.genresLabel.Name = "genresLabel";
            this.genresLabel.Size = new System.Drawing.Size(66, 17);
            this.genresLabel.TabIndex = 4;
            this.genresLabel.Text = "Жанры:";
            // 
            // studioLabel
            // 
            this.studioLabel.AutoSize = true;
            this.studioLabel.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.studioLabel.Location = new System.Drawing.Point(21, 246);
            this.studioLabel.Name = "studioLabel";
            this.studioLabel.Size = new System.Drawing.Size(59, 17);
            this.studioLabel.TabIndex = 5;
            this.studioLabel.Text = "Студия";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.animeCharacters1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 320);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panel4.Size = new System.Drawing.Size(880, 340);
            this.panel4.TabIndex = 4;
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
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.animeCast1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 660);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(880, 615);
            this.panel5.TabIndex = 5;
            // 
            // animeCast1
            // 
            this.animeCast1.AutoSize = true;
            this.animeCast1.Dock = System.Windows.Forms.DockStyle.Top;
            this.animeCast1.Location = new System.Drawing.Point(0, 0);
            this.animeCast1.Name = "animeCast1";
            this.animeCast1.Size = new System.Drawing.Size(880, 615);
            this.animeCast1.TabIndex = 0;
            // 
            // animeCharacters1
            // 
            this.animeCharacters1.BackColor = System.Drawing.Color.White;
            this.animeCharacters1.Dock = System.Windows.Forms.DockStyle.Top;
            this.animeCharacters1.Location = new System.Drawing.Point(0, 20);
            this.animeCharacters1.Name = "animeCharacters1";
            this.animeCharacters1.Size = new System.Drawing.Size(880, 320);
            this.animeCharacters1.TabIndex = 0;
            // 
            // AnimeFullEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "AnimeFullEntry";
            this.Size = new System.Drawing.Size(880, 1462);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label studioLabel;
        private System.Windows.Forms.Label genresLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label episodesLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private AnimeCharacters animeCharacters1;
        private System.Windows.Forms.Panel panel5;
        private AnimeCast animeCast1;
    }
}
