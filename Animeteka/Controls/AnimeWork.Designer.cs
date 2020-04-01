namespace Animeteka.Controls
{
    partial class AnimeWork
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
            this.components = new System.ComponentModel.Container();
            this.role = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.kind = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.BackColor = System.Drawing.Color.LightGray;
            this.role.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.role.Location = new System.Drawing.Point(0, 212);
            this.role.MinimumSize = new System.Drawing.Size(160, 0);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(160, 13);
            this.role.TabIndex = 1;
            this.role.Text = "Ключевая анимация";
            this.role.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.role);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 225);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Animeteka.Properties.Resources.placeholder;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // title
            // 
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(96)))), ((int)(((byte)(147)))));
            this.title.Location = new System.Drawing.Point(0, 225);
            this.title.MaximumSize = new System.Drawing.Size(160, 25);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.title.Size = new System.Drawing.Size(160, 25);
            this.title.TabIndex = 3;
            this.title.Text = "Истории ран: часть 3Истории ран: часть 3";
            this.title.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.title.Click += new System.EventHandler(this.label2_Click);
            // 
            // kind
            // 
            this.kind.AutoSize = true;
            this.kind.Dock = System.Windows.Forms.DockStyle.Left;
            this.kind.Location = new System.Drawing.Point(0, 250);
            this.kind.Name = "kind";
            this.kind.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.kind.Size = new System.Drawing.Size(44, 23);
            this.kind.TabIndex = 4;
            this.kind.Text = "Фильм";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Dock = System.Windows.Forms.DockStyle.Right;
            this.year.Location = new System.Drawing.Point(129, 250);
            this.year.Name = "year";
            this.year.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.year.Size = new System.Drawing.Size(31, 23);
            this.year.TabIndex = 5;
            this.year.Text = "2008";
            // 
            // AnimeWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.year);
            this.Controls.Add(this.kind);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel1);
            this.Name = "AnimeWork";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 15, 15);
            this.Size = new System.Drawing.Size(175, 275);
            this.Load += new System.EventHandler(this.AnimeWork_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label role;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label kind;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
