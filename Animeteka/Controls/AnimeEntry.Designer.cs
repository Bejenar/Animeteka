namespace Animeteka.Controls
{
    partial class AnimeEntry
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.studio = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.year = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.type = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 145);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Animeteka.Properties.Resources.placeholder;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.studio);
            this.panel2.Controls.Add(this.year);
            this.panel2.Controls.Add(this.type);
            this.panel2.Controls.Add(this.title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(100, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 145);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // studio
            // 
            this.studio.AutoSize = true;
            this.studio.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studio.ForeColor = System.Drawing.Color.Black;
            this.studio.Location = new System.Drawing.Point(6, 53);
            this.studio.Name = "studio";
            this.studio.Size = new System.Drawing.Size(47, 16);
            this.studio.TabIndex = 3;
            this.studio.Text = "Bones";
            // 
            // year
            // 
            this.year.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.year.AutoSize = true;
            this.year.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year.ForeColor = System.Drawing.Color.Black;
            this.year.Location = new System.Drawing.Point(6, 116);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(90, 18);
            this.year.TabIndex = 2;
            this.year.Text = "Год: 2009";
            this.year.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type.ForeColor = System.Drawing.Color.Black;
            this.type.Location = new System.Drawing.Point(6, 5);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(96, 18);
            this.type.TabIndex = 1;
            this.type.Text = "TV Сериал";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.SystemColors.Highlight;
            this.title.Location = new System.Drawing.Point(6, 35);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(266, 18);
            this.title.TabIndex = 0;
            this.title.Text = "Стальной Алхимик: Братство";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(100, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(695, 145);
            this.panel3.TabIndex = 2;
            // 
            // AnimeEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "AnimeEntry";
            this.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.Size = new System.Drawing.Size(795, 155);
            this.Load += new System.EventHandler(this.AnimeEntry_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AnimeEntry_Paint);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel studio;
        private Bunifu.Framework.UI.BunifuCustomLabel year;
        private Bunifu.Framework.UI.BunifuCustomLabel type;
        public Bunifu.Framework.UI.BunifuCustomLabel title;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}
