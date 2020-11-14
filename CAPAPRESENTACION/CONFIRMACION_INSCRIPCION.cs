using CAPAENTIDADES;
using CAPANEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPAPRESENTACION
{
    public partial class CONFIRMACION_INSCRIPCION : FormInvocadoBase
    {
        public CONFIRMACION_INSCRIPCION()
        {
            InitializeComponent();
            cargandodatos(Login.username);
        }
        public static string IDCICLO;
        List<E_CARRERACUOTA> lista;
        N_Alumno neg = new N_Alumno();
        E_Inscripcion entities = new E_Inscripcion();
        void cargandodatos(string carne)
        {
            DataSet ds;
            lista = neg.cuotaynombrecarrera(carne);
            ds = ToDataSet<E_CARRERACUOTA>(lista);
            txtcuota.Text = ds.Tables[0].Rows[0]["Cuota"].ToString().Trim();
            Decimal TOTAL = Convert.ToDecimal(ds.Tables[0].Rows[0]["Cuota"].ToString().Trim());
            txttotalpagar.Text = (3 * TOTAL).ToString();
            txtcuota.Enabled = false;
            txttotalpagar.Enabled = false;
        }
        private void CONFIRMACION_INSCRIPCION_Load(object sender, EventArgs e)
        {
            try
            {
                Esclarecer.ShowAsyc(this);
            }
            catch(Exception )
            {
                FormWarning.confirmacionForm("ERROR", "NO ES FECHA DE INSCRIPCION");
                this.Close();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BTNguardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.OK;                              
                string TODAY = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                string TOMORROW = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd hh:mm:ss");
                string HOY = DateTime.Now.ToString("yyyy-MM-dd");
                entities.Carnet = Login.username;
                entities.Fecha_inscripcion = Convert.ToDateTime(TODAY);
                entities.Cuota = Convert.ToDecimal(txtcuota.Text);
                entities.Total = Convert.ToDecimal(txttotalpagar.Text);
                entities.Fecha_vencimiento = Convert.ToDateTime(TOMORROW);
                entities.Id_ciclo = Convert.ToInt32(IDCICLO);
                neg.CREARINSCRIPCION(entities);
                FormSucces.confirmacionForm("Inscripcion Exitosa, Tiene 24H para realizar el pago");
                Close();
                HORARIOSGRUPOS.FECHADEINSCRIPCION = Convert.ToDateTime(TODAY);
                Inscripcion.FECHAINSCRIP = Convert.ToDateTime(TODAY);
            }
            catch (SqlException EX)
            {
                FormWarning.confirmacionForm("ERROR", EX.Message);
            }
            catch (Exception EX)
            {
                FormWarning.confirmacionForm("ERROR", EX.Message);
            }

        }
    }
}
