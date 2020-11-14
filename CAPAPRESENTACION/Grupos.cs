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
    public partial class Grupos : FormInvocadoBase
    {
        N_Alumno NEG = new N_Alumno();
        public Grupos()
        {
            try
            {
                InitializeComponent();
                CARGARCICLOS("");
            }
            catch(Exception EX)
            {
                FormWarning.confirmacionForm("ERROR", EX.Message);
            }
            
        }
        void ACCIONESTABLA()
        {
            GRIDGrupos.Columns["ID_Grupo"].Visible = false;
            GRIDGrupos.Columns["CODIGO_Grupo"].Visible = false;
            GRIDGrupos.Columns["HORARIOS"].Width = 100;
        }
        void mostrargrupos(string CARNE, int idciclo)
        {
            GRIDGrupos.DataSource = null;
            GRIDGrupos.Update();
            GRIDGrupos.Refresh();
            GRIDGrupos.DataSource = NEG.GROUPALREADYINSCRIPTED(CARNE,idciclo);
            ACCIONESTABLA();
        }
        void CARGARCICLOS(string BUSCAR)
        {
            CBMCICLO.DataSource = NEG.LISTARTODOSLOSCICLOS(BUSCAR);
            CBMCICLO.ValueMember = "Idciclo";
            CBMCICLO.DisplayMember = "Detalle_ciclo";
        }
        void ACCIONESTABLAhorarios()
        {
            GRIDhorarios.Columns["ID_Horario"].Visible = false;
            GRIDhorarios.Columns["Informacion_Horario"].Visible = false;
        }
        void MOSTRARHORARIOS(int IDGRUPO)
        {
            GRIDhorarios.DataSource = null;
            GRIDhorarios.Update();
            GRIDhorarios.Refresh();
            GRIDhorarios.DataSource = NEG.listandoHorarios(IDGRUPO);
            ACCIONESTABLAhorarios();
        }
        private void Grupos_Load(object sender, EventArgs e)
        {

        }

        private void BTNACTUALIZARGIRD_Click(object sender, EventArgs e)
        {
            try
            {
                mostrargrupos(Login.username,Convert.ToInt32(CBMCICLO.SelectedValue.ToString()));
                GRIDhorarios.DataSource = null;
            }
            catch (Exception EX)
            {
                FormWarning.confirmacionForm("ERROR", EX.Message);
            }
        }

        private void GRIDGrupos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GRIDGrupos.Rows[e.RowIndex].Cells["HORARIOS"].Selected)
                {
                    string idgrupo = GRIDGrupos.Rows[e.RowIndex].Cells["ID_Grupo"].Value.ToString();
                    MOSTRARHORARIOS(Convert.ToInt32(idgrupo));
                }
            }
            catch (Exception EX)
            {
                FormWarning.confirmacionForm("ERROR", EX.Message);
            }
        }
           
    }
}
