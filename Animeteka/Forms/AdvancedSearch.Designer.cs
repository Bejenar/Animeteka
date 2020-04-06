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
            this.panelFilter = new System.Windows.Forms.Panel();
            this.adsControl = new Animeteka.Controls.AdvancedSearchControl();
            this.panelEntry = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelHeaderDiv = new System.Windows.Forms.Panel();
            this.progressBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.AsyncWorker = new System.ComponentModel.BackgroundWorker();
            this.LoadPage = new System.ComponentModel.BackgroundWorker();
            this.panelPage = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelFilter.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelHeaderDiv.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFilter
            // 
            this.panelFilter.AutoSize = true;
            this.panelFilter.BackColor = System.Drawing.Color.White;
            this.panelFilter.Controls.Add(this.adsControl);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFilter.Location = new System.Drawing.Point(708, 63);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(240, 442);
            this.panelFilter.TabIndex = 10;
            // 
            // adsControl
            // 
            this.adsControl.BackColor = System.Drawing.Color.Transparent;
            this.adsControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.adsControl.Location = new System.Drawing.Point(0, 0);
            this.adsControl.Name = "adsControl";
            this.adsControl.Size = new System.Drawing.Size(240, 442);
            this.adsControl.TabIndex = 9;
            // 
            // panelEntry
            // 
            this.panelEntry.AutoScroll = true;
            this.panelEntry.BackColor = System.Drawing.Color.White;
            this.panelEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEntry.Location = new System.Drawing.Point(0, 63);
            this.panelEntry.Name = "panelEntry";
            this.panelEntry.Size = new System.Drawing.Size(708, 407);
            this.panelEntry.TabIndex = 11;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DimGray;
            this.panelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHeader.Controls.Add(this.panelHeaderDiv);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(948, 63);
            this.panelHeader.TabIndex = 12;
            // 
            // panelHeaderDiv
            // 
            this.panelHeaderDiv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeaderDiv.BackColor = System.Drawing.Color.Transparent;
            this.panelHeaderDiv.Controls.Add(this.progressBar);
            this.panelHeaderDiv.Controls.Add(this.panelSearch);
            this.panelHeaderDiv.Location = new System.Drawing.Point(38, 11);
            this.panelHeaderDiv.Name = "panelHeaderDiv";
            this.panelHeaderDiv.Size = new System.Drawing.Size(690, 40);
            this.panelHeaderDiv.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.animated = true;
            this.progressBar.animationIterval = 7;
            this.progressBar.animationSpeed = 1;
            this.progressBar.BackColor = System.Drawing.Color.Transparent;
            this.progressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressBar.BackgroundImage")));
            this.progressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.progressBar.ForeColor = System.Drawing.Color.White;
            this.progressBar.LabelVisible = false;
            this.progressBar.LineProgressThickness = 5;
            this.progressBar.LineThickness = 5;
            this.progressBar.Location = new System.Drawing.Point(634, -5);
            this.progressBar.Margin = new System.Windows.Forms.Padding(6);
            this.progressBar.MaxValue = 100;
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.progressBar.ProgressColor = System.Drawing.Color.LightGreen;
            this.progressBar.Size = new System.Drawing.Size(50, 50);
            this.progressBar.TabIndex = 10;
            this.progressBar.Value = 0;
            this.progressBar.Visible = false;
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.BackColor = System.Drawing.SystemColors.Window;
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSearch.Controls.Add(this.searchBox);
            this.panelSearch.Controls.Add(this.button_search);
            this.panelSearch.Location = new System.Drawing.Point(9, 3);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Padding = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.panelSearch.Size = new System.Drawing.Size(623, 36);
            this.panelSearch.TabIndex = 9;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBox.Location = new System.Drawing.Point(10, 10);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(556, 15);
            this.searchBox.TabIndex = 0;
            // 
            // button_search
            // 
            this.button_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_search.BackColor = System.Drawing.Color.Transparent;
            this.button_search.BackgroundImage = global::Animeteka.Properties.Resources.search;
            this.button_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_search.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_search.Location = new System.Drawing.Point(586, 0);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(33, 33);
            this.button_search.TabIndex = 8;
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // AsyncWorker
            // 
            this.AsyncWorker.WorkerReportsProgress = true;
            this.AsyncWorker.WorkerSupportsCancellation = true;
            this.AsyncWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundEntryWorker_DoWork);
            this.AsyncWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundEntryWorker_ProgressChanged);
            this.AsyncWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundEntryWorker_RunWorkerCompleted);
            // 
            // LoadPage
            // 
            this.LoadPage.WorkerReportsProgress = true;
            this.LoadPage.WorkerSupportsCancellation = true;
            this.LoadPage.DoWork += new System.ComponentModel.DoWorkEventHandler(this.LoadPage_DoWork);
            this.LoadPage.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundEntryWorker_ProgressChanged);
            // 
            // panelPage
            // 
            this.panelPage.BackColor = System.Drawing.Color.White;
            this.panelPage.Controls.Add(this.label1);
            this.panelPage.Controls.Add(this.button2);
            this.panelPage.Controls.Add(this.button1);
            this.panelPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPage.Location = new System.Drawing.Point(0, 470);
            this.panelPage.Name = "panelPage";
            this.panelPage.Size = new System.Drawing.Size(708, 35);
            this.panelPage.TabIndex = 0;
            this.panelPage.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Вперёд";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(948, 505);
            this.Controls.Add(this.panelEntry);
            this.Controls.Add(this.panelPage);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdvancedSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnimeOnly";
            this.panelFilter.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeaderDiv.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelPage.ResumeLayout(false);
            this.panelPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controls.AdvancedSearchControl advancedSearchControl;
        private Controls.AdvancedSearchControl adsControl;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Panel panelEntry;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Panel panelHeaderDiv;
        private System.ComponentModel.BackgroundWorker AsyncWorker;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progressBar;
        private System.ComponentModel.BackgroundWorker LoadPage;
        private System.Windows.Forms.Panel panelPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}