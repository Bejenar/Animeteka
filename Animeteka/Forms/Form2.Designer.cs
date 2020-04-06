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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.animetekaDataSet3 = new Animeteka.AnimetekaDataSet3();
            this.animeGenreViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anime_Genre_ViewTableAdapter = new Animeteka.AnimetekaDataSet3TableAdapters.Anime_Genre_ViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.animetekaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animeGenreViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.animeGenreViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Animeteka.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(949, 486);
            this.reportViewer1.TabIndex = 0;
            // 
            // animetekaDataSet3
            // 
            this.animetekaDataSet3.DataSetName = "AnimetekaDataSet3";
            this.animetekaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animeGenreViewBindingSource
            // 
            this.animeGenreViewBindingSource.DataMember = "Anime_Genre_View";
            this.animeGenreViewBindingSource.DataSource = this.animetekaDataSet3;
            // 
            // anime_Genre_ViewTableAdapter
            // 
            this.anime_Genre_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(949, 486);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animetekaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animeGenreViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private AnimetekaDataSet3 animetekaDataSet3;
        private System.Windows.Forms.BindingSource animeGenreViewBindingSource;
        private AnimetekaDataSet3TableAdapters.Anime_Genre_ViewTableAdapter anime_Genre_ViewTableAdapter;
    }
}