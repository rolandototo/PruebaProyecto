using CAPANEGOCIO;
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

namespace CAPAPRESENTACION
{
    public partial class Retiros : FormInvocadoBase
    {
        public Retiros()
        {
            InitializeComponent();
        }
        N_Alumno NEG = new N_Alumno();
        public static int IDCICLO;
        public static string DETALLECICLO;
        void ACCIONESTABLA() 
        {
            
            GRIDgruposinscritos.Columns["ID_Grupo"].Visible = false;
            GRIDgruposinscritos.Columns["ID_Materia"].Visible = false;
            GRIDgruposinscritos.Columns["ID_Inscripcion"].Visible = false;
            GRIDgruposinscritos.Columns["ID_Alumno_Grupo"].Visible = false;
            GRIDgruposinscritos.Columns["Requisitos"].Visible = false;
            GRIDgruposinscritos.Columns["Nombre_Materia"].Width = 400;
            GRIDgruposinscritos.Columns["U_V"].Width = 100;
            GRIDgruposinscritos.Columns["DELETE"].Width = 100;
            GRIDgruposinscritos.Columns["ESTADO"].Width = 200;
            GRIDgruposinscritos.Columns["CODIGO_Materia"].Width = 200;
        }
        void MOSTRARMATERIAS(string CARNE,int IDCICLO)
        {
            GRIDgruposinscritos.DataSource = null;
            GRIDgruposinscritos.Update();
            GRIDgruposinscritos.Refresh();
            GRIDgruposinscritos.DataSource = NEG.VERMATERIASARETIRAR(CARNE,IDCICLO);
            ACCIONESTABLA();
        }
        private void Retiros_Load(object sender, EventArgs e)
        {
            try
            {
                TXTCICLO.Enabled = false;
                MOSTRARMATERIAS(Login.username, IDCICLO);
                TXTCICLO.Text = DETALLECICLO;
            }
            catch(Exception EX)
            {
                FormWarning.confirmacionForm("ERROR", EX.Message);
            }
        }
        DataSet OBTENERIDALUMNOGRUPO(string CARNE, int IDGRUPO)
        {
            DataTable DT = NEG.IDALUMNO_GRUPOID(CARNE, IDGRUPO);
            DataSet DS = DatatabletoDataset(DT);
            return DS;
        }
        private void GRIDgruposinscritos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GRIDgruposinscritos.Rows[e.RowIndex].Cells["DELETE"].Selected)
                {
                    FormInformacion FRM = new FormInformacion("ESTA SEGURO DE RETIRAR ESTA MATERIA?", "SE RESETEARA SU PROCESO EN EN ESTA MATERIA DESEA CONTINUAR ?");
                    DialogResult RESULT = FRM.ShowDialog();
                    if (RESULT == DialogResult.OK)
                    {
                        int IDINSCRIPCION = Convert.ToInt32(GRIDgruposinscritos.Rows[e.RowIndex].Cells["ID_Inscripcion"].Value.ToString());
                        int idgrupo = Convert.ToInt32(GRIDgruposinscritos.Rows[e.RowIndex].Cells["ID_Grupo"].Value.ToString());
                        DataSet ds = OBTENERIDALUMNOGRUPO(Login.username, Convert.ToInt32(GRIDgruposinscritos.Rows[e.RowIndex].Cells["ID_Grupo"].Value.ToString()));
                        int IDAlumnoGrupo = Convert.ToInt32(ds.Tables[0].Rows[0]["ID_Alumno_Grupo"].ToString().Trim());
                        NEG.RETIRARMATERIAYGRUPO(IDINSCRIPCION, idgrupo,IDAlumnoGrupo);
                        FormSucces.confirmacionForm("SE RETIRO LA MATERIA, ACTUALICE PARA VER CAMBIOS");
                        MOSTRARMATERIAS(Login.username, IDCICLO);
                    }
                }
            }
            catch (Exception EX)
            {
                FormWarning.confirmacionForm("ERROR", EX.Message);
            }
        }
    }
}
