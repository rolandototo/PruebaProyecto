using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPANEGOCIO;
using CAPAENTIDADES;
using Microsoft.Reporting.WinForms;

namespace CAPAPRESENTACION
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }
        public static String IDPAGO;
        N_Alumno NEG = new N_Alumno();
        List<E_FACTURA> DATOSFACTURA (int IDPAGO)
        {
            List<E_FACTURA> LISTA = NEG.DatosFactura(IDPAGO);
            return LISTA;   
        }
        private void Factura_Load(object sender, EventArgs e)
        {
            try
            {
                List<E_FACTURA> lista = DATOSFACTURA(Convert.ToInt32(IDPAGO));
                ReportDataSource rsd = new ReportDataSource("E_FACTURA", lista);
                //el parametro que recibe ReportEmbeddedResource es "<Nombre del Proyecto> <un punto.> <Nombre del Informe con su extencion.rdlc>"
                this.ReporteVista.LocalReport.ReportEmbeddedResource = "CAPAPRESENTACION.Informe.rdlc";
                //limpiamos el datasource 
                this.ReporteVista.LocalReport.DataSources.Clear();
                //agregamos un datasource al reporte que es lo que proviene de la lista 
                this.ReporteVista.LocalReport.DataSources.Add(rsd);
                //refrescamos el reporte
                this.ReporteVista.RefreshReport();
            }
            catch(Exception ex)
            {
                FormWarning.confirmacionForm("ERROR", ex.Message);
                this.Close();
            }
        }
        private void Factura_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
