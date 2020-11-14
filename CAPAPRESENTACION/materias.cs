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

namespace CAPAPRESENTACION
{
    public partial class materias : FormInvocadoBase
    {
        public materias()
        {
            InitializeComponent();
        }
        N_Alumno NEG = new N_Alumno();
        DataSet DS;
        int IDCARRERA(string CARNE)
        {
            List<E_CARRERACUOTA> LISTA = new List<E_CARRERACUOTA>();
            LISTA = NEG.cuotaynombrecarrera(CARNE);
            DataSet DS = ToDataSet<E_CARRERACUOTA>(LISTA);
            int carreraid = Convert.ToInt32(DS.Tables[0].Rows[0]["Idcarrera"].ToString().Trim());
            return carreraid;
        }
        void ACCIONESTABLAmaterias()
        {
            GRIDMATERIAS.Columns["Id_pensum"].Visible = false;
            GRIDMATERIAS.Columns["Idciclo"].Visible = false;
            GRIDMATERIAS.Columns["Idmateria"].Visible = false;
            GRIDMATERIAS.Columns["Nombre_materia"].Width = 400;
            GRIDMATERIAS.Columns["CODEMATERIA"].Width = 100;
            GRIDMATERIAS.Columns["U_v"].Width = 200;
            GRIDMATERIAS.Columns["Anno"].Width = 200;
            GRIDMATERIAS.Columns["Requisitos"].Width = 200;
            //  GRIDMATERIAS.Columns["Idmateria"].Width = 100;
            //GRIDMATERIAS.Columns["Idmateria"].Width = 100;

        }
        void MOSTRARMATERIAS(int IDCARRERA)
        {
            List<E_Materia> LISTA = new List<E_Materia>();
            LISTA = NEG.LISTANDOMATERIAS(IDCARRERA);
            DS = ToDataSet<E_Materia>(LISTA);
            GRIDMATERIAS.DataSource = null;
            GRIDMATERIAS.Update();
            GRIDMATERIAS.Refresh();
            GRIDMATERIAS.DataSource = DS.Tables[0];
            ACCIONESTABLAmaterias();
        }

        void mostrarRegistrosMaterias(string carnet)
        {
            GRIDActiva.DataSource = null;
            GRIDActiva.Update();
            GRIDActiva.Refresh();
            GRIDActiva.DataSource = NEG.REGISTROSDEMATERIAS(carnet);
        }
        private void materias_Load(object sender, EventArgs e)
        {
            int CAREERID = IDCARRERA(Login.username);
            MOSTRARMATERIAS(CAREERID);
            mostrarRegistrosMaterias(Login.username);
        }

    }
}
