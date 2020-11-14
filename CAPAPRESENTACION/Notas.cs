using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPAENTIDADES;
using CAPANEGOCIO;
namespace CAPAPRESENTACION
{
    public partial class Notas : FormInvocadoBase
    {
        public Notas()
        {
            InitializeComponent();
            CARGARCBMATERIA(Login.username);
        }
        N_Alumno NEG = new N_Alumno();
        void CARGARCBMATERIA(string CARNET)
        {
            CBMMATERIAS.DataSource = NEG.materiasINSCRITASS(CARNET);
            CBMMATERIAS.ValueMember = "IDMateria";
            CBMMATERIAS.DisplayMember = "NombreMateria";
        }
        void MOSTRARNOTAS(string CANE, int IDMATERIA)
        {
            GRIDActiva.DataSource = null;
            GRIDActiva.Update();
            GRIDActiva.Refresh();
            GRIDActiva.DataSource = NEG.VERNOTAS(CANE,IDMATERIA);
        }
        void VERPROMEDIO()
        {
            double SUMA = 0;
            foreach (DataGridViewRow fila in GRIDActiva.Rows)
            {
                SUMA += (Convert.ToDouble(fila.Cells["Porcentaje_Nota"].Value) / 10) * Convert.ToDouble(fila.Cells["Nota"].Value);
            }
            LBPROMEDIO.Text = SUMA.ToString();
        }
        private void Notas_Load(object sender, EventArgs e)
        {
            try
            {
                VERPROMEDIO();
            }
            catch (Exception EX)
            {
                FormWarning.confirmacionForm("ERROR", EX.Message);
            }
        }
        private void BTNACTUALIZARGIRD_Click(object sender, EventArgs e)
        {
            MOSTRARNOTAS(Login.username, Convert.ToInt32(CBMMATERIAS.SelectedValue.ToString()));
            VERPROMEDIO();
        }
        
    }
}   
