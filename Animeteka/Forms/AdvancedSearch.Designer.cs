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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancedSearch));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelEntry = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.backgroundEntryWorker = new System.ComponentModel.BackgroundWorker();
            this.adsControl = new Animeteka.Controls.AdvancedSearchControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.adsControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(708, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 405);
            this.panel1.TabIndex = 10;
            // 
            // panelEntry
            // 
            this.panelEntry.AutoScroll = true;
            this.panelEntry.BackColor = System.Drawing.Color.White;
            this.panelEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEntry.Location = new System.Drawing.Point(0, 100);
            this.panelEntry.Name = "panelEntry";
            this.panelEntry.Size = new System.Drawing.Size(708, 405);
            this.panelEntry.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.BackgroundImage = global::Animeteka.Properties.Resources.login_bg;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(948, 100);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.panel);
            this.panel4.Controls.Add(this.button_search);
            this.panel4.Location = new System.Drawing.Point(38, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(670, 40);
            this.panel4.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.SystemColors.Window;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.searchBox);
            this.panel.Location = new System.Drawing.Point(17, 3);
            this.panel.Name = "panel";
            this.panel.Padding = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.panel.Size = new System.Drawing.Size(603, 36);
            this.panel.TabIndex = 9;
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBox.Location = new System.Drawing.Point(10, 10);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(579, 15);
            this.searchBox.TabIndex = 0;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.Transparent;
            this.button_search.BackgroundImage = global::Animeteka.Properties.Resources.search;
            this.button_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_search.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_search.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_search.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_search.Location = new System.Drawing.Point(630, 0);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(40, 40);
            this.button_search.TabIndex = 8;
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // backgroundEntryWorker
            // 
            this.backgroundEntryWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundEntryWorker_DoWork);
            this.backgroundEntryWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundEntryWorker_RunWorkerCompleted);
            // 
            // adsControl
            // 
            this.adsControl.BackColor = System.Drawing.Color.Transparent;
            this.adsControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.adsControl.Location = new System.Drawing.Point(0, 0);
            this.adsControl.Name = "adsControl";
            this.adsControl.Size = new System.Drawing.Size(240, 405);
            this.adsControl.TabIndex = 9;
            // 
            // AdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(948, 505);
            this.Controls.Add(this.panelEntry);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdvancedSearch";
            this.Text = "AnimeOnly";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controls.AdvancedSearchControl advancedSearchControl;
        private Controls.AdvancedSearchControl adsControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelEntry;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Panel panel4;
        private System.ComponentModel.BackgroundWorker backgroundEntryWorker;
    }
}