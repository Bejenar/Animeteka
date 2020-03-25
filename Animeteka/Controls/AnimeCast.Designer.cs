namespace Animeteka.Controls
{
    partial class AnimeCast
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.personPreview3 = new Animeteka.Controls.PersonPreview();
            this.personPreview2 = new Animeteka.Controls.PersonPreview();
            this.personPreview1 = new Animeteka.Controls.PersonPreview();
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
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(21, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Создатели аниме";
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
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.personPreview3);
            this.panel3.Controls.Add(this.personPreview2);
            this.panel3.Controls.Add(this.personPreview1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 34);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(948, 581);
            this.panel3.TabIndex = 2;
            // 
            // personPreview3
            // 
            this.personPreview3.Dock = System.Windows.Forms.DockStyle.Top;
            this.personPreview3.Location = new System.Drawing.Point(10, 384);
            this.personPreview3.Name = "personPreview3";
            this.personPreview3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.personPreview3.Size = new System.Drawing.Size(928, 187);
            this.personPreview3.TabIndex = 2;
            // 
            // personPreview2
            // 
            this.personPreview2.Dock = System.Windows.Forms.DockStyle.Top;
            this.personPreview2.Location = new System.Drawing.Point(10, 197);
            this.personPreview2.Name = "personPreview2";
            this.personPreview2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.personPreview2.Size = new System.Drawing.Size(928, 187);
            this.personPreview2.TabIndex = 1;
            // 
            // personPreview1
            // 
            this.personPreview1.Dock = System.Windows.Forms.DockStyle.Top;
            this.personPreview1.Location = new System.Drawing.Point(10, 10);
            this.personPreview1.Name = "personPreview1";
            this.personPreview1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.personPreview1.Size = new System.Drawing.Size(928, 187);
            this.personPreview1.TabIndex = 0;
            // 
            // AnimeCast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "AnimeCast";
            this.Size = new System.Drawing.Size(948, 802);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private PersonPreview personPreview3;
        private PersonPreview personPreview2;
        private PersonPreview personPreview1;
    }
}
