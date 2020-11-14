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
    public partial class HORARIOSGRUPOS : FormInvocadoBase
    {
        public HORARIOSGRUPOS()
        {
            InitializeComponent();
            TXTMAESTRO.Enabled = false;
            TXTNOMGRUPO.Enabled = false;
        }
        N_Alumno neg = new N_Alumno();
        E_DETALLE_GRUPO_ALUMNO ENTITIES = new E_DETALLE_GRUPO_ALUMNO();
        DataSet ds = new DataSet();
        public static DateTime FECHADEINSCRIPCION;
        public string IDMATERIA;
        public string IDGRUPO;
        string INSCRIPCIONCREADA(string CARNE,DateTime FECHAINSCR)
        {
            List<E_verINSCRIPCION> lista = new List<E_verINSCRIPCION>();
            lista = neg.VERINSCRIPCION(CARNE, FECHAINSCR);
            ds = ToDataSet<E_verINSCRIPCION>(lista);
            string CODEINSCRIPCION = ds.Tables[0].Rows[0]["ID_Inscripcion"].ToString().Trim();
            return CODEINSCRIPCION;
        }
        void ACCIONESTABLA()
        {
            GRIDhorarios.Columns[0].Visible = false;
        }
        void MOSTRARHORARIOS(int IDGRUPO)
        {
            GRIDhorarios.DataSource = null;
            GRIDhorarios.Update();
            GRIDhorarios.Refresh();
            GRIDhorarios.DataSource = neg.listandoHorarios(IDGRUPO);
            ACCIONESTABLA();
        }
        void MOSTRARACTUALESINSCRITOS(int IDGRUPO)
        {
            GridCupos.DataSource = null;
            GridCupos.Update();
            GridCupos.Refresh();
            GridCupos.DataSource = neg.ESTUDIANTESACTUALMENTEINSCRITOSAUNGRUPO(IDGRUPO);
        }
        Boolean ERROR = false;
        private void HORARIOSGRUPOS_Load(object sender, EventArgs e)
        {
            FADE.ShowAsyc(this);
            try
            {
                MOSTRARHORARIOS(Convert.ToInt32(IDGRUPO));
                MOSTRARACTUALESINSCRITOS(Convert.ToInt32(IDGRUPO));
                DataSet DS = OBTENIENDOALUMNINSCRITOS(Convert.ToInt32(IDGRUPO));
                string ALGO = DS.Tables[0].Rows[0]["Actuales Inscritos"].ToString().Trim();
                GridCupos.Visible = true;
                LBPRIMERO.Visible = false;
                ERROR = false;

            }
            catch(Exception)
            {
                MOSTRARHORARIOS(Convert.ToInt32(IDGRUPO));
                LBPRIMERO.Visible = true;
                GridCupos.Visible = false;
                ERROR = true;
            }
        }

        private void BTNCALCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataTable OBTENERIDGRUPO_NOTAS(int IDGRUPO)
        {
            DataTable DT = neg.IDGRUPO_NOTAS(IDGRUPO);
            DataSet DS = DatatabletoDataset(DT);
            return DT;
        }
        DataSet OBTENERIDALUMNOGRUPO(string CARNE, int IDGRUPO)
        {
            DataSet DS = new DataSet();
            DataTable DT = new DataTable();
            DT = neg.IDALUMNO_GRUPOID(CARNE, IDGRUPO);
            DS = DatatabletoDataset(DT);
            return DS;
        }
        DataSet OBTENIENDOALUMNINSCRITOS(int IDGRUPO)
        {
            DataTable DT = neg.ESTUDIANTESACTUALMENTEINSCRITOSAUNGRUPO(IDGRUPO);
            DataSet DS = DatatabletoDataset(DT);
            return DS;
        }
        private void BTNTINSCRIBIR_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ALUMNO = OBTENIENDOALUMNINSCRITOS(Convert.ToInt32(IDGRUPO));
                FormInformacion frm = new FormInformacion("ESTA SEGURO DE INSCRIBIR ESTA MATERIA ?","UNA VEZ INSCRITA PODRA REVISAR POSTERIORMENTE SI LE PARECE O NO.");
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (ERROR == true)
                    {
                        string IDINSCRIPCION = INSCRIPCIONCREADA(Login.username, FECHADEINSCRIPCION);
                        ENTITIES.Carnet = Login.username;
                        ENTITIES.Id_Grupo = Convert.ToInt32(IDGRUPO);
                        ENTITIES.Detalle = "INSCRITA";
                        ENTITIES.ID_Inscripcion = Convert.ToInt32(IDINSCRIPCION);
                        ENTITIES.IDMateria = Convert.ToInt32(IDMATERIA);
                        ENTITIES.ESTADO = "REPROBADO";
                        neg.GRUPOINSCRITO(ENTITIES);
                        //CODIGO MATERIA NOTAS
                        DataSet DS = OBTENERIDALUMNOGRUPO(Login.username, Convert.ToInt32(IDGRUPO));
                        DataTable dt = OBTENERIDGRUPO_NOTAS(Convert.ToInt32(IDGRUPO));
                        int ID_Alumno_Grupo = Convert.ToInt32(DS.Tables[0].Rows[0]["ID_Alumno_Grupo"].ToString().Trim());
                        // int ID_Notas = Convert.ToInt32(DSS.Tables[0].Rows[0]["ID_Notas"].ToString().Trim());
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            int ID_Notas = Convert.ToInt32(dt.Rows[i]["ID_Notas"].ToString());
                            neg.crearnuevasnotasporgrupo(ID_Alumno_Grupo, ID_Notas, 0);
                        }
                        //CODIGO MATERIA NOTAS
                        FormSucces.confirmacionForm("GRUPO INSCRITO");
                        Close();
                    }
                    else if (ERROR == false)
                    {
                        if (Convert.ToInt32(ALUMNO.Tables[0].Rows[0]["Actuales Inscritos"].ToString().Trim()) <= Convert.ToInt32(ALUMNO.Tables[0].Rows[0]["Maximo_Cupo"].ToString().Trim()))
                        {
                            string IDINSCRIPCION = INSCRIPCIONCREADA(Login.username, FECHADEINSCRIPCION);
                            ENTITIES.Carnet = Login.username;
                            ENTITIES.Id_Grupo = Convert.ToInt32(IDGRUPO);
                            ENTITIES.Detalle = "INSCRITA";
                            ENTITIES.ID_Inscripcion = Convert.ToInt32(IDINSCRIPCION);
                            ENTITIES.IDMateria = Convert.ToInt32(IDMATERIA);
                            ENTITIES.ESTADO = "REPROBADO";
                            neg.GRUPOINSCRITO(ENTITIES);
                            //CODIGO MATERIA NOTAS
                            DataSet DS = OBTENERIDALUMNOGRUPO(Login.username, Convert.ToInt32(IDGRUPO));
                            DataTable dt = OBTENERIDGRUPO_NOTAS(Convert.ToInt32(IDGRUPO));
                            int ID_Alumno_Grupo = Convert.ToInt32(DS.Tables[0].Rows[0]["ID_Alumno_Grupo"].ToString().Trim());
                            // int ID_Notas = Convert.ToInt32(DSS.Tables[0].Rows[0]["ID_Notas"].ToString().Trim());
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                int ID_Notas = Convert.ToInt32(dt.Rows[i]["ID_Notas"].ToString());
                                neg.crearnuevasnotasporgrupo(ID_Alumno_Grupo, ID_Notas, 0);
                            }
                            //CODIGO MATERIA NOTAS
                            FormSucces.confirmacionForm("GRUPO INSCRITO");
                            Close();
                            ERROR = false;
                        }
                        else
                        {
                            FormWarning.confirmacionForm("UPS...", "SE HA COMPLETADO EL CUPO PARA ESTE GRUPO POR LO TANTO NO SE PUDO INSCRIBIR");
                            this.Close();
                            ERROR = false;
                        }
                    }
                }
            }
            catch (SqlException EX)
            {
                FormWarning.confirmacionForm("ERROR", EX.Message);
                this.Close();
            }
            catch (Exception EX)
            {
                FormWarning.confirmacionForm("ERROR", EX.Message);
                this.Close();
            }
        }

        private void BTNUPDATE_Click(object sender, EventArgs e)
        {
            MOSTRARHORARIOS(Convert.ToInt32(IDGRUPO));
            MOSTRARACTUALESINSCRITOS(Convert.ToInt32(IDGRUPO));
        }
    }
}
