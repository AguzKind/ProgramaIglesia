namespace Prj_Interfaz
{
    partial class FRP_Comuniones
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
            this.rv_COM = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rv_COM
            // 
            this.rv_COM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv_COM.LocalReport.ReportEmbeddedResource = "Programa_Iglesia.Report_Comunion.rdlc";
            this.rv_COM.Location = new System.Drawing.Point(0, 0);
            this.rv_COM.Name = "rv_COM";
            this.rv_COM.Size = new System.Drawing.Size(916, 489);
            this.rv_COM.TabIndex = 0;
            // 
            // FRP_Comuniones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 489);
            this.Controls.Add(this.rv_COM);
            this.Name = "FRP_Comuniones";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.FRP_Comuniones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_COM;
    }
}