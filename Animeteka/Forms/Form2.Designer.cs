namespace Animeteka.Forms
{
    partial class Form2
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
            this.animeFullEntry1 = new Animeteka.Controls.AnimeFullEntry();
            this.SuspendLayout();
            // 
            // animeFullEntry1
            // 
            this.animeFullEntry1.AutoSize = true;
            this.animeFullEntry1.BackColor = System.Drawing.Color.White;
            this.animeFullEntry1.Dock = System.Windows.Forms.DockStyle.Top;
            this.animeFullEntry1.Location = new System.Drawing.Point(0, 0);
            this.animeFullEntry1.Name = "animeFullEntry1";
            this.animeFullEntry1.Size = new System.Drawing.Size(983, 1275);
            this.animeFullEntry1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1000, 486);
            this.Controls.Add(this.animeFullEntry1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.AnimeFullEntry animeFullEntry1;
    }
}