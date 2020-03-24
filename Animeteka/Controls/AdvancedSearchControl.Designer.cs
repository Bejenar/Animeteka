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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Status_check = new System.Windows.Forms.CheckBox();
            this.Status_release = new System.Windows.Forms.RadioButton();
            this.Status_airing = new System.Windows.Forms.RadioButton();
            this.Status_announced = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Studio_check = new System.Windows.Forms.CheckBox();
            this.Studio = new System.Windows.Forms.ComboBox();
            this.genrePanel = new System.Windows.Forms.Panel();
            this.Genre_check = new System.Windows.Forms.CheckBox();
            this.Genre = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Date_check = new System.Windows.Forms.CheckBox();
            this.DateFrom = new System.Windows.Forms.DateTimePicker();
            this.DateTo = new System.Windows.Forms.DateTimePicker();
            this.checkPanel = new System.Windows.Forms.Panel();
            this.Type_check = new System.Windows.Forms.CheckBox();
            this.Type = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.genrePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.checkPanel.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 505);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.Status_check);
            this.panel4.Controls.Add(this.Status_release);
            this.panel4.Controls.Add(this.Status_airing);
            this.panel4.Controls.Add(this.Status_announced);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 779);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(214, 142);
            this.panel4.TabIndex = 17;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Status_check
            // 
            this.Status_check.AutoSize = true;
            this.Status_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Status_check.Location = new System.Drawing.Point(0, 3);
            this.Status_check.Name = "Status_check";
            this.Status_check.Size = new System.Drawing.Size(91, 28);
            this.Status_check.TabIndex = 9;
            this.Status_check.Text = "Статус";
            this.Status_check.UseVisualStyleBackColor = true;
            this.Status_check.CheckedChanged += new System.EventHandler(this.Type_check_CheckedChanged);
            // 
            // Status_release
            // 
            this.Status_release.AutoSize = true;
            this.Status_release.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Status_release.Location = new System.Drawing.Point(0, 39);
            this.Status_release.Name = "Status_release";
            this.Status_release.Size = new System.Drawing.Size(88, 28);
            this.Status_release.TabIndex = 10;
            this.Status_release.Text = "Вышло";
            this.Status_release.UseVisualStyleBackColor = true;
            this.Status_release.Visible = false;
            // 
            // Status_airing
            // 
            this.Status_airing.AutoSize = true;
            this.Status_airing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Status_airing.Location = new System.Drawing.Point(0, 75);
            this.Status_airing.Name = "Status_airing";
            this.Status_airing.Size = new System.Drawing.Size(107, 28);
            this.Status_airing.TabIndex = 11;
            this.Status_airing.Text = "Выходит";
            this.Status_airing.UseVisualStyleBackColor = true;
            this.Status_airing.Visible = false;
            // 
            // Status_announced
            // 
            this.Status_announced.AutoSize = true;
            this.Status_announced.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Status_announced.Location = new System.Drawing.Point(0, 111);
            this.Status_announced.Name = "Status_announced";
            this.Status_announced.Size = new System.Drawing.Size(160, 28);
            this.Status_announced.TabIndex = 12;
            this.Status_announced.Text = "Анонсировано";
            this.Status_announced.UseVisualStyleBackColor = true;
            this.Status_announced.Visible = false;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.Studio_check);
            this.panel3.Controls.Add(this.Studio);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 707);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 72);
            this.panel3.TabIndex = 16;
            // 
            // Studio_check
            // 
            this.Studio_check.AutoSize = true;
            this.Studio_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Studio_check.Location = new System.Drawing.Point(0, 3);
            this.Studio_check.Name = "Studio_check";
            this.Studio_check.Size = new System.Drawing.Size(94, 28);
            this.Studio_check.TabIndex = 7;
            this.Studio_check.Text = "Студия";
            this.Studio_check.UseVisualStyleBackColor = true;
            this.Studio_check.CheckedChanged += new System.EventHandler(this.Type_check_CheckedChanged);
            // 
            // Studio
            // 
            this.Studio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Studio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Studio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Studio.FormattingEnabled = true;
            this.Studio.Location = new System.Drawing.Point(0, 37);
            this.Studio.Name = "Studio";
            this.Studio.Size = new System.Drawing.Size(211, 32);
            this.Studio.TabIndex = 8;
            this.Studio.Visible = false;
            // 
            // genrePanel
            // 
            this.genrePanel.AutoSize = true;
            this.genrePanel.Controls.Add(this.Genre_check);
            this.genrePanel.Controls.Add(this.Genre);
            this.genrePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.genrePanel.Location = new System.Drawing.Point(0, 183);
            this.genrePanel.Name = "genrePanel";
            this.genrePanel.Size = new System.Drawing.Size(214, 524);
            this.genrePanel.TabIndex = 15;
            // 
            // Genre_check
            // 
            this.Genre_check.AutoSize = true;
            this.Genre_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Genre_check.Location = new System.Drawing.Point(0, 3);
            this.Genre_check.Name = "Genre_check";
            this.Genre_check.Size = new System.Drawing.Size(77, 28);
            this.Genre_check.TabIndex = 6;
            this.Genre_check.Text = "Жанр";
            this.Genre_check.UseVisualStyleBackColor = true;
            this.Genre_check.CheckedChanged += new System.EventHandler(this.Type_check_CheckedChanged);
            // 
            // Genre
            // 
            this.Genre.BackColor = System.Drawing.SystemColors.Control;
            this.Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Genre.FormattingEnabled = true;
            this.Genre.IntegralHeight = false;
            this.Genre.Location = new System.Drawing.Point(0, 35);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(211, 486);
            this.Genre.TabIndex = 5;
            this.Genre.Visible = false;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.Date_check);
            this.panel2.Controls.Add(this.DateFrom);
            this.panel2.Controls.Add(this.DateTo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 111);
            this.panel2.TabIndex = 14;
            // 
            // Date_check
            // 
            this.Date_check.AutoSize = true;
            this.Date_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Date_check.Location = new System.Drawing.Point(0, 6);
            this.Date_check.Name = "Date_check";
            this.Date_check.Size = new System.Drawing.Size(145, 28);
            this.Date_check.TabIndex = 2;
            this.Date_check.Text = "Дата выхода";
            this.Date_check.UseVisualStyleBackColor = true;
            this.Date_check.CheckedChanged += new System.EventHandler(this.Type_check_CheckedChanged);
            // 
            // DateFrom
            // 
            this.DateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.DateFrom.Location = new System.Drawing.Point(0, 42);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Size = new System.Drawing.Size(211, 29);
            this.DateFrom.TabIndex = 3;
            this.DateFrom.Value = new System.DateTime(2000, 3, 21, 18, 14, 0, 0);
            this.DateFrom.Visible = false;
            // 
            // DateTo
            // 
            this.DateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.DateTo.Location = new System.Drawing.Point(3, 79);
            this.DateTo.Name = "DateTo";
            this.DateTo.Size = new System.Drawing.Size(208, 29);
            this.DateTo.TabIndex = 4;
            this.DateTo.Visible = false;
            // 
            // checkPanel
            // 
            this.checkPanel.AutoSize = true;
            this.checkPanel.Controls.Add(this.Type_check);
            this.checkPanel.Controls.Add(this.Type);
            this.checkPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkPanel.Location = new System.Drawing.Point(0, 0);
            this.checkPanel.Name = "checkPanel";
            this.checkPanel.Size = new System.Drawing.Size(214, 72);
            this.checkPanel.TabIndex = 13;
            // 
            // Type_check
            // 
            this.Type_check.AutoSize = true;
            this.Type_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Type_check.Location = new System.Drawing.Point(0, 3);
            this.Type_check.Name = "Type_check";
            this.Type_check.Size = new System.Drawing.Size(63, 28);
            this.Type_check.TabIndex = 0;
            this.Type_check.Text = "Тип";
            this.Type_check.UseVisualStyleBackColor = true;
            this.Type_check.CheckedChanged += new System.EventHandler(this.Type_check_CheckedChanged);
            // 
            // Type
            // 
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Type.FormattingEnabled = true;
            this.Type.Location = new System.Drawing.Point(0, 37);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(211, 32);
            this.Type.TabIndex = 1;
            this.Type.Visible = false;
            // 
            // AdvancedSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AdvancedSearchControl";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Size = new System.Drawing.Size(236, 505);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.genrePanel.ResumeLayout(false);
            this.genrePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.checkPanel.ResumeLayout(false);
            this.checkPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.RadioButton Status_announced;
        public System.Windows.Forms.RadioButton Status_airing;
        public System.Windows.Forms.RadioButton Status_release;
        public System.Windows.Forms.CheckBox Status_check;
        public System.Windows.Forms.ComboBox Studio;
        public System.Windows.Forms.CheckBox Studio_check;
        public System.Windows.Forms.CheckedListBox Genre;
        public System.Windows.Forms.CheckBox Genre_check;
        public System.Windows.Forms.DateTimePicker DateTo;
        public System.Windows.Forms.DateTimePicker DateFrom;
        public System.Windows.Forms.CheckBox Date_check;
        public System.Windows.Forms.ComboBox Type;
        public System.Windows.Forms.CheckBox Type_check;
        public System.Windows.Forms.Panel checkPanel;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel genrePanel;
    }
}
