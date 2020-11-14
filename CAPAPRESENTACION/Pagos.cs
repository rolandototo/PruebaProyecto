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

namespace CAPAPRESENTACION
{
    public partial class Pagos : FormInvocadoBase
    {
        public Pagos()
        {
            InitializeComponent();
        }
        N_Alumno NEG = new N_Alumno();
        void MOSTRARPAGOS(string CARNE)
        {
            GRIDpagos.DataSource = null;
            GRIDpagos.Update();
            GRIDpagos.Refresh();
            GRIDpagos.DataSource = NEG.VERPAGOSRESTANTES(CARNE);
        }
        private void GRIDpagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GRIDpagos.Rows[e.RowIndex].Cells["PAGAR"].Selected)
                {
                    FormInformacion FRM = new FormInformacion("ESTA SEGURO DE REALIZAR SU PAGO ?", "EL SISTEMA NECESITA SU CONFIRMACION ?");
                    DialogResult RESULT = FRM.ShowDialog();
                    if (RESULT == DialogResult.OK)
                    {
                        Confirmacion_Pago form = new Confirmacion_Pago();
                        Confirmacion_Pago.IDPAGO = GRIDpagos.Rows[e.RowIndex].Cells["ID_Pago"].Value.ToString();
                        Confirmacion_Pago.MONTO = GRIDpagos.Rows[e.RowIndex].Cells["Monto"].Value.ToString();
                        DateTime fecha = Convert.ToDateTime(GRIDpagos.Rows[e.RowIndex].Cells["Fecha_Vencimiento"].Value.ToString());
                        Confirmacion_Pago.FECHAVENCIMIENTO = fecha.ToString("dd/MM/yyyy");
                        form.ShowDialog();
                        MOSTRARPAGOS(Login.username);
                    }
                }
                else if(GRIDpagos.Rows[e.RowIndex].Cells["Fecha_Vencimiento"].Selected)
                {
                    DateTime fecha = Convert.ToDateTime(GRIDpagos.Rows[e.RowIndex].Cells["Fecha_Vencimiento"].Value.ToString());
                    PRUEBA.Text = fecha.ToString("dd/MM/yyyy");
                }
            }
            catch (Exception EX)
            {
                FormWarning.confirmacionForm("ERROR", EX.Message);
            }
        }

        private void Pagos_Load(object sender, EventArgs e)
        {
            MOSTRARPAGOS(Login.username);
        }
    }
}
