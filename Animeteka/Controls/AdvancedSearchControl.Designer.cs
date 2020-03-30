namespace Animeteka.Controls
{
    partial class AdvancedSearchControl
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
            this.panel1 = new Animeteka.Controls.CustomPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.Status_check = new Animeteka.Controls.CustomCheckBox();
            this.Status_release = new System.Windows.Forms.RadioButton();
            this.Status_airing = new System.Windows.Forms.RadioButton();
            this.Status_announced = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.Studio_check = new Animeteka.Controls.CustomCheckBox();
            this.Studio = new System.Windows.Forms.ComboBox();
            this.genrePanel = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.Genre_check = new Animeteka.Controls.CustomCheckBox();
            this.Genre = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Date_check = new Animeteka.Controls.CustomCheckBox();
            this.DateFrom = new System.Windows.Forms.DateTimePicker();
            this.DateTo = new System.Windows.Forms.DateTimePicker();
            this.checkPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Type_check = new Animeteka.Controls.CustomCheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Type = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel11.SuspendLayout();
            this.genrePanel.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.checkPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.genrePanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.checkPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 505);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.panel13);
            this.panel4.Controls.Add(this.Status_release);
            this.panel4.Controls.Add(this.Status_airing);
            this.panel4.Controls.Add(this.Status_announced);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 1175);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(214, 135);
            this.panel4.TabIndex = 17;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Controls.Add(this.Status_check);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(214, 31);
            this.panel13.TabIndex = 13;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Gray;
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(10, 31);
            this.panel14.TabIndex = 0;
            // 
            // Status_check
            // 
            this.Status_check.Appearance = System.Windows.Forms.Appearance.Button;
            this.Status_check.AutoSize = true;
            this.Status_check.BackColor = System.Drawing.Color.Transparent;
            this.Status_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Status_check.FlatAppearance.BorderSize = 0;
            this.Status_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Status_check.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Status_check.ImageIndex = 0;
            this.Status_check.Location = new System.Drawing.Point(20, 1);
            this.Status_check.Name = "Status_check";
            this.Status_check.Size = new System.Drawing.Size(80, 28);
            this.Status_check.TabIndex = 9;
            this.Status_check.Text = "Статус";
            this.Status_check.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Status_check.UseVisualStyleBackColor = true;
            this.Status_check.CheckedChanged += new System.EventHandler(this.Type_check_CheckedChanged);
            // 
            // Status_release
            // 
            this.Status_release.AutoSize = true;
            this.Status_release.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Status_release.Location = new System.Drawing.Point(20, 39);
            this.Status_release.Name = "Status_release";
            this.Status_release.Size = new System.Drawing.Size(74, 21);
            this.Status_release.TabIndex = 10;
            this.Status_release.Text = "Вышло";
            this.Status_release.UseVisualStyleBackColor = true;
            this.Status_release.Visible = false;
            // 
            // Status_airing
            // 
            this.Status_airing.AutoSize = true;
            this.Status_airing.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Status_airing.Location = new System.Drawing.Point(20, 75);
            this.Status_airing.Name = "Status_airing";
            this.Status_airing.Size = new System.Drawing.Size(86, 21);
            this.Status_airing.TabIndex = 11;
            this.Status_airing.Text = "Выходит";
            this.Status_airing.UseVisualStyleBackColor = true;
            this.Status_airing.Visible = false;
            // 
            // Status_announced
            // 
            this.Status_announced.AutoSize = true;
            this.Status_announced.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Status_announced.Location = new System.Drawing.Point(20, 111);
            this.Status_announced.Name = "Status_announced";
            this.Status_announced.Size = new System.Drawing.Size(123, 21);
            this.Status_announced.TabIndex = 12;
            this.Status_announced.Text = "Анонсировано";
            this.Status_announced.UseVisualStyleBackColor = true;
            this.Status_announced.Visible = false;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.panel11);
            this.panel3.Controls.Add(this.Studio);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 1105);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel3.Size = new System.Drawing.Size(214, 70);
            this.panel3.TabIndex = 16;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.Studio_check);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(214, 31);
            this.panel11.TabIndex = 9;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Gray;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(10, 31);
            this.panel12.TabIndex = 0;
            // 
            // Studio_check
            // 
            this.Studio_check.Appearance = System.Windows.Forms.Appearance.Button;
            this.Studio_check.AutoSize = true;
            this.Studio_check.BackColor = System.Drawing.Color.Transparent;
            this.Studio_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Studio_check.FlatAppearance.BorderSize = 0;
            this.Studio_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Studio_check.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Studio_check.ImageIndex = 0;
            this.Studio_check.Location = new System.Drawing.Point(20, 1);
            this.Studio_check.Name = "Studio_check";
            this.Studio_check.Size = new System.Drawing.Size(86, 28);
            this.Studio_check.TabIndex = 7;
            this.Studio_check.Text = "Студия";
            this.Studio_check.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Studio_check.UseVisualStyleBackColor = true;
            this.Studio_check.CheckedChanged += new System.EventHandler(this.Type_check_CheckedChanged);
            // 
            // Studio
            // 
            this.Studio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Studio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Studio.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Studio.FormattingEnabled = true;
            this.Studio.Location = new System.Drawing.Point(20, 37);
            this.Studio.Name = "Studio";
            this.Studio.Size = new System.Drawing.Size(194, 25);
            this.Studio.TabIndex = 8;
            this.Studio.Visible = false;
            // 
            // genrePanel
            // 
            this.genrePanel.AutoSize = true;
            this.genrePanel.Controls.Add(this.panel9);
            this.genrePanel.Controls.Add(this.Genre);
            this.genrePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.genrePanel.Location = new System.Drawing.Point(0, 182);
            this.genrePanel.Name = "genrePanel";
            this.genrePanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.genrePanel.Size = new System.Drawing.Size(214, 923);
            this.genrePanel.TabIndex = 15;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.Genre_check);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(214, 31);
            this.panel9.TabIndex = 7;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Gray;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(10, 31);
            this.panel10.TabIndex = 0;
            // 
            // Genre_check
            // 
            this.Genre_check.Appearance = System.Windows.Forms.Appearance.Button;
            this.Genre_check.AutoSize = true;
            this.Genre_check.BackColor = System.Drawing.Color.Transparent;
            this.Genre_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Genre_check.FlatAppearance.BorderSize = 0;
            this.Genre_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Genre_check.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Genre_check.ImageIndex = 0;
            this.Genre_check.Location = new System.Drawing.Point(20, 1);
            this.Genre_check.Name = "Genre_check";
            this.Genre_check.Size = new System.Drawing.Size(74, 28);
            this.Genre_check.TabIndex = 6;
            this.Genre_check.Text = "Жанр";
            this.Genre_check.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Genre_check.UseVisualStyleBackColor = true;
            this.Genre_check.CheckedChanged += new System.EventHandler(this.Type_check_CheckedChanged);
            // 
            // Genre
            // 
            this.Genre.BackColor = System.Drawing.Color.White;
            this.Genre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Genre.CheckOnClick = true;
            this.Genre.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Genre.FormattingEnabled = true;
            this.Genre.HorizontalScrollbar = true;
            this.Genre.IntegralHeight = false;
            this.Genre.Location = new System.Drawing.Point(20, 35);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(194, 880);
            this.Genre.TabIndex = 0;
            this.Genre.TabStop = false;
            this.Genre.UseTabStops = false;
            this.Genre.Visible = false;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.DateFrom);
            this.panel2.Controls.Add(this.DateTo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel2.Size = new System.Drawing.Size(214, 112);
            this.panel2.TabIndex = 14;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.Date_check);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(214, 31);
            this.panel7.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 31);
            this.panel8.TabIndex = 0;
            // 
            // Date_check
            // 
            this.Date_check.Appearance = System.Windows.Forms.Appearance.Button;
            this.Date_check.AutoSize = true;
            this.Date_check.BackColor = System.Drawing.Color.Transparent;
            this.Date_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Date_check.FlatAppearance.BorderSize = 0;
            this.Date_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Date_check.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Date_check.ImageIndex = 0;
            this.Date_check.Location = new System.Drawing.Point(20, 1);
            this.Date_check.Name = "Date_check";
            this.Date_check.Size = new System.Drawing.Size(128, 28);
            this.Date_check.TabIndex = 2;
            this.Date_check.Text = "Дата выхода";
            this.Date_check.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Date_check.UseVisualStyleBackColor = true;
            this.Date_check.CheckedChanged += new System.EventHandler(this.Type_check_CheckedChanged);
            // 
            // DateFrom
            // 
            this.DateFrom.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DateFrom.Location = new System.Drawing.Point(20, 42);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Size = new System.Drawing.Size(194, 25);
            this.DateFrom.TabIndex = 3;
            this.DateFrom.Value = new System.DateTime(2000, 3, 21, 18, 14, 0, 0);
            this.DateFrom.Visible = false;
            // 
            // DateTo
            // 
            this.DateTo.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DateTo.Location = new System.Drawing.Point(20, 79);
            this.DateTo.Name = "DateTo";
            this.DateTo.Size = new System.Drawing.Size(194, 25);
            this.DateTo.TabIndex = 4;
            this.DateTo.Visible = false;
            // 
            // checkPanel
            // 
            this.checkPanel.AutoSize = true;
            this.checkPanel.Controls.Add(this.panel5);
            this.checkPanel.Controls.Add(this.Type);
            this.checkPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkPanel.Location = new System.Drawing.Point(0, 0);
            this.checkPanel.Name = "checkPanel";
            this.checkPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.checkPanel.Size = new System.Drawing.Size(214, 70);
            this.checkPanel.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.panel5.Controls.Add(this.Type_check);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(214, 31);
            this.panel5.TabIndex = 2;
            // 
            // Type_check
            // 
            this.Type_check.Appearance = System.Windows.Forms.Appearance.Button;
            this.Type_check.AutoSize = true;
            this.Type_check.BackColor = System.Drawing.Color.Transparent;
            this.Type_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Type_check.FlatAppearance.BorderSize = 0;
            this.Type_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Type_check.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Type_check.ImageIndex = 0;
            this.Type_check.Location = new System.Drawing.Point(20, 1);
            this.Type_check.Name = "Type_check";
            this.Type_check.Size = new System.Drawing.Size(61, 28);
            this.Type_check.TabIndex = 0;
            this.Type_check.Text = "Тип";
            this.Type_check.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Type_check.UseVisualStyleBackColor = true;
            this.Type_check.CheckedChanged += new System.EventHandler(this.Type_check_CheckedChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 31);
            this.panel6.TabIndex = 0;
            // 
            // Type
            // 
            this.Type.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Type.FormattingEnabled = true;
            this.Type.Location = new System.Drawing.Point(20, 37);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(194, 25);
            this.Type.TabIndex = 1;
            this.Type.Visible = false;
            // 
            // AdvancedSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AdvancedSearchControl";
            this.Size = new System.Drawing.Size(231, 505);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.genrePanel.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.checkPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public CustomPanel panel1;
        public System.Windows.Forms.RadioButton Status_announced;
        public System.Windows.Forms.RadioButton Status_airing;
        public System.Windows.Forms.RadioButton Status_release;
        public CustomCheckBox Status_check;
        public System.Windows.Forms.ComboBox Studio;
        public CustomCheckBox Studio_check;
        public System.Windows.Forms.CheckedListBox Genre;
        public CustomCheckBox Genre_check;
        public System.Windows.Forms.DateTimePicker DateTo;
        public System.Windows.Forms.DateTimePicker DateFrom;
        public CustomCheckBox Date_check;
        public System.Windows.Forms.ComboBox Type;
        public CustomCheckBox Type_check;
        public System.Windows.Forms.Panel checkPanel;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel genrePanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
    }
}
