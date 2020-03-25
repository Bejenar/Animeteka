namespace Animeteka.Controls
{
    partial class AnimeCharacters
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.characterPreview1 = new Animeteka.Controls.CharacterPreview();
            this.characterPreview2 = new Animeteka.Controls.CharacterPreview();
            this.characterPreview3 = new Animeteka.Controls.CharacterPreview();
            this.characterPreview4 = new Animeteka.Controls.CharacterPreview();
            this.characterPreview5 = new Animeteka.Controls.CharacterPreview();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 34);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 34);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(21, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Персонажи";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.characterPreview5);
            this.panel3.Controls.Add(this.characterPreview4);
            this.panel3.Controls.Add(this.characterPreview3);
            this.panel3.Controls.Add(this.characterPreview2);
            this.panel3.Controls.Add(this.characterPreview1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 34);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(948, 287);
            this.panel3.TabIndex = 1;
            // 
            // characterPreview1
            // 
            this.characterPreview1.BackColor = System.Drawing.Color.Transparent;
            this.characterPreview1.Dock = System.Windows.Forms.DockStyle.Left;
            this.characterPreview1.Location = new System.Drawing.Point(10, 10);
            this.characterPreview1.Name = "characterPreview1";
            this.characterPreview1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.characterPreview1.Size = new System.Drawing.Size(174, 267);
            this.characterPreview1.TabIndex = 0;
            // 
            // characterPreview2
            // 
            this.characterPreview2.BackColor = System.Drawing.Color.Transparent;
            this.characterPreview2.Dock = System.Windows.Forms.DockStyle.Left;
            this.characterPreview2.Location = new System.Drawing.Point(184, 10);
            this.characterPreview2.Name = "characterPreview2";
            this.characterPreview2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.characterPreview2.Size = new System.Drawing.Size(174, 267);
            this.characterPreview2.TabIndex = 1;
            // 
            // characterPreview3
            // 
            this.characterPreview3.BackColor = System.Drawing.Color.Transparent;
            this.characterPreview3.Dock = System.Windows.Forms.DockStyle.Left;
            this.characterPreview3.Location = new System.Drawing.Point(358, 10);
            this.characterPreview3.Name = "characterPreview3";
            this.characterPreview3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.characterPreview3.Size = new System.Drawing.Size(174, 267);
            this.characterPreview3.TabIndex = 2;
            // 
            // characterPreview4
            // 
            this.characterPreview4.BackColor = System.Drawing.Color.Transparent;
            this.characterPreview4.Dock = System.Windows.Forms.DockStyle.Left;
            this.characterPreview4.Location = new System.Drawing.Point(532, 10);
            this.characterPreview4.Name = "characterPreview4";
            this.characterPreview4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.characterPreview4.Size = new System.Drawing.Size(174, 267);
            this.characterPreview4.TabIndex = 3;
            // 
            // characterPreview5
            // 
            this.characterPreview5.BackColor = System.Drawing.Color.Transparent;
            this.characterPreview5.Dock = System.Windows.Forms.DockStyle.Left;
            this.characterPreview5.Location = new System.Drawing.Point(706, 10);
            this.characterPreview5.Name = "characterPreview5";
            this.characterPreview5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.characterPreview5.Size = new System.Drawing.Size(174, 267);
            this.characterPreview5.TabIndex = 4;
            // 
            // AnimeCharacters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "AnimeCharacters";
            this.Size = new System.Drawing.Size(948, 320);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private CharacterPreview characterPreview5;
        private CharacterPreview characterPreview4;
        private CharacterPreview characterPreview3;
        private CharacterPreview characterPreview2;
        private CharacterPreview characterPreview1;
    }
}
