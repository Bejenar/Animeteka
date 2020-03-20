namespace Animeteka.Forms
{
    partial class AdvancedSearch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Type_check = new System.Windows.Forms.CheckBox();
            this.Type = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.Date_check = new System.Windows.Forms.CheckBox();
            this.DateFrom = new System.Windows.Forms.DateTimePicker();
            this.DateTo = new System.Windows.Forms.DateTimePicker();
            this.Genre = new System.Windows.Forms.CheckedListBox();
            this.Genre_check = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Genre);
            this.panel1.Controls.Add(this.Genre_check);
            this.panel1.Controls.Add(this.DateTo);
            this.panel1.Controls.Add(this.DateFrom);
            this.panel1.Controls.Add(this.Date_check);
            this.panel1.Controls.Add(this.Type);
            this.panel1.Controls.Add(this.Type_check);
            this.panel1.Location = new System.Drawing.Point(731, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1000);
            this.panel1.TabIndex = 0;
            // 
            // Type_check
            // 
            this.Type_check.AutoSize = true;
            this.Type_check.Location = new System.Drawing.Point(3, 31);
            this.Type_check.Name = "Type_check";
            this.Type_check.Size = new System.Drawing.Size(45, 17);
            this.Type_check.TabIndex = 0;
            this.Type_check.Text = "Тип";
            this.Type_check.UseVisualStyleBackColor = true;
            // 
            // Type
            // 
            this.Type.FormattingEnabled = true;
            this.Type.Location = new System.Drawing.Point(3, 54);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(121, 21);
            this.Type.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(25, 12);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.panel2.Size = new System.Drawing.Size(589, 36);
            this.panel2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(10, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(565, 13);
            this.textBox1.TabIndex = 0;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_search.BackgroundImage = global::Animeteka.Properties.Resources.search;
            this.button_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_search.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_search.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_search.Location = new System.Drawing.Point(620, 12);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(35, 35);
            this.button_search.TabIndex = 6;
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // Date_check
            // 
            this.Date_check.AutoSize = true;
            this.Date_check.Location = new System.Drawing.Point(3, 95);
            this.Date_check.Name = "Date_check";
            this.Date_check.Size = new System.Drawing.Size(92, 17);
            this.Date_check.TabIndex = 2;
            this.Date_check.Text = "Дата выхода";
            this.Date_check.UseVisualStyleBackColor = true;
            // 
            // DateFrom
            // 
            this.DateFrom.Location = new System.Drawing.Point(3, 118);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Size = new System.Drawing.Size(156, 20);
            this.DateFrom.TabIndex = 3;
            // 
            // DateTo
            // 
            this.DateTo.Location = new System.Drawing.Point(3, 144);
            this.DateTo.Name = "DateTo";
            this.DateTo.Size = new System.Drawing.Size(156, 20);
            this.DateTo.TabIndex = 4;
            // 
            // Genre
            // 
            this.Genre.BackColor = System.Drawing.SystemColors.Control;
            this.Genre.FormattingEnabled = true;
            this.Genre.IntegralHeight = false;
            this.Genre.Location = new System.Drawing.Point(4, 208);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(171, 486);
            this.Genre.TabIndex = 5;
            // 
            // Genre_check
            // 
            this.Genre_check.AutoSize = true;
            this.Genre_check.Location = new System.Drawing.Point(4, 185);
            this.Genre_check.Name = "Genre_check";
            this.Genre_check.Size = new System.Drawing.Size(55, 17);
            this.Genre_check.TabIndex = 6;
            this.Genre_check.Text = "Жанр";
            this.Genre_check.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 83);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(717, 345);
            this.textBox2.TabIndex = 8;
            // 
            // AdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(948, 505);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.panel1);
            this.Name = "AdvancedSearch";
            this.Text = "AdvancedSearch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.CheckBox Type_check;
        private System.Windows.Forms.CheckedListBox Genre;
        private System.Windows.Forms.DateTimePicker DateTo;
        private System.Windows.Forms.DateTimePicker DateFrom;
        private System.Windows.Forms.CheckBox Date_check;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.CheckBox Genre_check;
        private System.Windows.Forms.TextBox textBox2;
    }
}