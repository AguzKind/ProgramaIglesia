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
    public partial class FRP_Comuniones : Form
    {
        public FRP_Comuniones()
        {
            InitializeComponent();
        }
        public List<Reportes_Comuniones> Datos = new List<Reportes_Comuniones>(); // Lista que se va a encargar de guardar los datos de los eventos
        private void FRP_Comuniones_Load(object sender, EventArgs e)
        {
            rv_COM.LocalReport.DataSources.Clear(); // Limpia el datasource del reporte
            rv_COM.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", Datos)); // Selecciona el datasource creado anteriormente
            this.rv_COM.RefreshReport(); // Refresca el reporte
        }
    }
}
