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
            this.Studio = new System.Windows.Forms.ComboBox();
            this.Studio_check = new System.Windows.Forms.CheckBox();
            this.Genre = new System.Windows.Forms.CheckedListBox();
            this.Genre_check = new System.Windows.Forms.CheckBox();
            this.DateTo = new System.Windows.Forms.DateTimePicker();
            this.DateFrom = new System.Windows.Forms.DateTimePicker();
            this.Date_check = new System.Windows.Forms.CheckBox();
            this.Type = new System.Windows.Forms.ComboBox();
            this.Type_check = new System.Windows.Forms.CheckBox();
            this.panel = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Studio);
            this.panel1.Controls.Add(this.Studio_check);
            this.panel1.Controls.Add(this.Genre);
            this.panel1.Controls.Add(this.Genre_check);
            this.panel1.Controls.Add(this.DateTo);
            this.panel1.Controls.Add(this.DateFrom);
            this.panel1.Controls.Add(this.Date_check);
            this.panel1.Controls.Add(this.Type);
            this.panel1.Controls.Add(this.Type_check);
            this.panel1.Location = new System.Drawing.Point(713, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1000);
            this.panel1.TabIndex = 0;
            // 
            // Studio
            // 
            this.Studio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Studio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Studio.FormattingEnabled = true;
            this.Studio.Location = new System.Drawing.Point(4, 724);
            this.Studio.Name = "Studio";
            this.Studio.Size = new System.Drawing.Size(171, 21);
            this.Studio.TabIndex = 8;
            // 
            // Studio_check
            // 
            this.Studio_check.AutoSize = true;
            this.Studio_check.Location = new System.Drawing.Point(4, 701);
            this.Studio_check.Name = "Studio_check";
            this.Studio_check.Size = new System.Drawing.Size(61, 17);
            this.Studio_check.TabIndex = 7;
            this.Studio_check.Text = "Студия";
            this.Studio_check.UseVisualStyleBackColor = true;
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
            // DateTo
            // 
            this.DateTo.Location = new System.Drawing.Point(4, 144);
            this.DateTo.Name = "DateTo";
            this.DateTo.Size = new System.Drawing.Size(172, 20);
            this.DateTo.TabIndex = 4;
            // 
            // DateFrom
            // 
            this.DateFrom.Location = new System.Drawing.Point(4, 118);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Size = new System.Drawing.Size(172, 20);
            this.DateFrom.TabIndex = 3;
            // 
            // Date_check
            // 
            this.Date_check.AutoSize = true;
            this.Date_check.Location = new System.Drawing.Point(4, 95);
            this.Date_check.Name = "Date_check";
            this.Date_check.Size = new System.Drawing.Size(92, 17);
            this.Date_check.TabIndex = 2;
            this.Date_check.Text = "Дата выхода";
            this.Date_check.UseVisualStyleBackColor = true;
            // 
            // Type
            // 
            this.Type.FormattingEnabled = true;
            this.Type.Location = new System.Drawing.Point(4, 54);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(172, 21);
            this.Type.TabIndex = 1;
            // 
            // Type_check
            // 
            this.Type_check.AutoSize = true;
            this.Type_check.Location = new System.Drawing.Point(4, 30);
            this.Type_check.Name = "Type_check";
            this.Type_check.Size = new System.Drawing.Size(45, 17);
            this.Type_check.TabIndex = 0;
            this.Type_check.Text = "Тип";
            this.Type_check.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Window;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.searchBox);
            this.panel.Location = new System.Drawing.Point(25, 12);
            this.panel.Name = "panel";
            this.panel.Padding = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.panel.Size = new System.Drawing.Size(589, 36);
            this.panel.TabIndex = 7;
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBox.Location = new System.Drawing.Point(10, 10);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(565, 13);
            this.searchBox.TabIndex = 0;
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
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(12, 83);
            this.Search.Multiline = true;
            this.Search.Name = "Search";
            this.Search.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Search.Size = new System.Drawing.Size(678, 345);
            this.Search.TabIndex = 8;
            // 
            // AdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(948, 505);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.panel1);
            this.Name = "AdvancedSearch";
            this.Text = "AdvancedSearch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
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
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.CheckBox Genre_check;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.ComboBox Studio;
        private System.Windows.Forms.CheckBox Studio_check;
    }
}