namespace Prj_Interfaz
{
    partial class FRP_Misas
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
            this.Reportes_MisasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rv_MIS = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.Reportes_MisasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Reportes_MisasBindingSource
            // 
            this.Reportes_MisasBindingSource.DataSource = typeof(Prj_Trabajo.Reportes_Misas);
            // 
            // rv_MIS
            // 
            this.rv_MIS.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Reportes_MisasBindingSource;
            this.rv_MIS.LocalReport.DataSources.Add(reportDataSource1);
            this.rv_MIS.LocalReport.ReportEmbeddedResource = "Programa_Iglesia.Report_Misa.rdlc";
            this.rv_MIS.Location = new System.Drawing.Point(0, 0);
            this.rv_MIS.Name = "rv_MIS";
            this.rv_MIS.Size = new System.Drawing.Size(916, 489);
            this.rv_MIS.TabIndex = 0;
            // 
            // FRP_Misas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 489);
            this.Controls.Add(this.rv_MIS);
            this.Name = "FRP_Misas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.FRP_Misas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reportes_MisasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_MIS;
        private System.Windows.Forms.BindingSource Reportes_MisasBindingSource;
    }
}