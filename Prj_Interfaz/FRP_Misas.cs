using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Prj_Trabajo;

namespace Prj_Interfaz
{
    public partial class FRP_Misas : Form
    {
        public FRP_Misas()
        {
            InitializeComponent();
        }
        public List<Reportes_Misas> Datos = new List<Reportes_Misas>(); // Lista que se va a encargar de guardar los datos de los eventos
        private void FRP_Misas_Load(object sender, EventArgs e)
        {
            rv_MIS.LocalReport.DataSources.Clear(); // Limpia el datasource del reporte
            rv_MIS.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", Datos)); // Selecciona el datasource creado anteriormente
            this.rv_MIS.RefreshReport(); // Refresca el reporte
        }
    }
}
