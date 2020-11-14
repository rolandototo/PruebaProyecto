using CAPAENTIDADES;
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

namespace CAPAPRESENTACION
{
    public partial class Inscripcion : FormInvocadoBase
    {     
        public Inscripcion()
        {
            try
            {
                InitializeComponent();
                int idcarreir = IDCARRERA(Login.username);
                CARGARCBMATERIA(idcarreir);
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }
        N_Alumno NEG = new N_Alumno();
        public static string CICLO;
        public static DateTime FECHAINSCRIP;
        string INSCRIPCIONCREADA(string CARNE, DateTime FECHAINSCR)
        {
            DataSet ds = new DataSet();
            List<E_verINSCRIPCION> lista = new List<E_verINSCRIPCION>();
            lista = NEG.VERINSCRIPCION(CARNE, FECHAINSCR);
            ds = ToDataSet<E_verINSCRIPCION>(lista);
            string CODEINSCRIPCION = ds.Tables[0].Rows[0]["ID_Inscripcion"].ToString().Trim();
            return CODEINSCRIPCION;
        }
        void ACCIONESTABLA()
        {
            GRIDGrupos.Columns["ID_Grupo"].Visible = false;
            GRIDGrupos.Columns["HORARIOS"].Width = 100;
            GRIDGrupos.Columns["CODIGO_Grupo"].Width = 100;

        }
        void accionesgridhorariosins()
        {
            GRIDgruposinscritos.Columns["DELETE"].Width = 100;
            GRIDgruposinscritos.Columns["ID_Materia"].Visible = false;
            GRIDgruposinscritos.Columns["ID_Grupo"].Visible = false;
        }
        int IDCARRERA(string CARNE)
        {
            List<E_CARRERACUOTA> LISTA = new List<E_CARRERACUOTA>();
            LISTA = NEG.cuotaynombrecarrera(CARNE);
            DataSet DS = ToDataSet<E_CARRERACUOTA>(LISTA);
            int carreraid = Convert.ToInt32(DS.Tables[0].Rows[0]["Idcarrera"].ToString().Trim());
            return carreraid;
        }
        void CARGARCBMATERIA(int IDCARRERA)
        {
            CBMATERIAS.DataSource = NEG.LISTANDOMATERIAS(IDCARRERA);
            CBMATERIAS.ValueMember = "Idmateria";
            CBMATERIAS.DisplayMember = "Nombre_materia";
        }
        void mostrargruposinscritos(int idinscripcion)
        {
            GRIDgruposinscritos.DataSource = null;
            GRIDgruposinscritos.Update();
            GRIDgruposinscritos.Refresh();
            GRIDgruposinscritos.DataSource = NEG.VERGRUPOSINSCRIPTOS(idinscripcion);
            accionesgridhorariosins();
        }
        void mostrargrupos(int iDmateria, int idciclo)
        {
            GRIDGrupos.DataSource = null;
            GRIDGrupos.Update();
            GRIDGrupos.Refresh();
            GRIDGrupos.DataSource = NEG.listandogrupos(iDmateria, idciclo);
            ACCIONESTABLA();
        }
        decimal Matricula(string carne)
        {
            DataSet ds;
            List<E_CARRERACUOTA> LISTA;
            LISTA = NEG.cuotaynombrecarrera(carne);
            ds = ToDataSet<E_CARRERACUOTA>(LISTA);
            Decimal CUOTA = Convert.ToDecimal(ds.Tables[0].Rows[0]["Cuota"].ToString().Trim());
            decimal TOTAL = (3 * CUOTA);
            return TOTAL;
        }
        decimal Cuotas(string carne)
        {
            DataSet ds;
            List<E_CARRERACUOTA> LISTA;
            LISTA = NEG.cuotaynombrecarrera(carne);
            ds = ToDataSet<E_CARRERACUOTA>(LISTA);
            Decimal CUOTA = Convert.ToDecimal(ds.Tables[0].Rows[0]["Cuota"].ToString().Trim());
            return CUOTA;
        }
        DataSet IDMENSUALIDAD(string MES)
        {
            DataTable DT = NEG.OBTENERMESID(MES);
            DataSet DS = DatatabletoDataset(DT);
            return DS;
        }
        private void BTNTERMINAR_Click(object sender, EventArgs e)
        {
            try
            {
                int INSCRIPCIONDT = Convert.ToInt32(INSCRIPCIONCREADA(Login.username, FECHAINSCRIP));
                DataTable DT = NEG.VERGRUPOSINSCRIPTOS(INSCRIPCIONDT);
                if (DT.Rows.Count == 0)
                {
                    FormWarning.confirmacionForm("ERROR", "NO PUEDE FINALIZAR LA INSCRIPCION SIN HABER INSCRITO POR LO MENOS UN GRUPO!");
                }
                else
                {
                    FormInformacion frm = new FormInformacion("ESTA SEGURO DE TERMINAR EL PROCESO ?", "UNA VEZ QUE TERMINE NO PODRA VOLVER A INSCRIBIR (ASEGURESE DE TODO ANTES DE FINALIZAR)");
                    DialogResult RESUL = frm.ShowDialog();
                    if (RESUL == DialogResult.OK)
                    {
                        // 5 MESES DE MENSUALIDADES
                        for (int i = 0; i < 5; i++)
                        {
                            string month = DateTime.Now.AddMonths(i).ToString("MMMM").ToUpper();
                            DataSet DS1 = IDMENSUALIDAD(month);
                            E_PAGO ENTITES = new E_PAGO();
                            ENTITES.DetallePago = "PENDIENTE";
                            if (i == 0)
                            {
                                ENTITES.Monto = Matricula(Login.username);
                            }
                            else if (i == 1)
                            {
                                ENTITES.Monto = Cuotas(Login.username);
                            }
                            else if (i == 2)
                            {
                                ENTITES.Monto = Cuotas(Login.username);
                            }
                            else if (i == 3)
                            {
                                ENTITES.Monto = Cuotas(Login.username);
                            }
                            else if (i == 4)
                            {
                                ENTITES.Monto = Cuotas(Login.username);
                            }
                            ENTITES.IDInscripcion = Convert.ToInt32(INSCRIPCIONCREADA(Login.username, FECHAINSCRIP));
                            ENTITES.IDMensualidad = Convert.ToInt32(DS1.Tables[0].Rows[0]["ID_Mensualidad"].ToString().Trim());
                            ENTITES.Carnet = Login.username;
                            ENTITES.PagoStatus = 0;
                            NEG.CREARPAGOSS(ENTITES);
                        }
                        FormSucces.confirmacionForm("PROCESO FINALIZADO, PUEDE PASAR A CANCELARLO.");
                        Close();
                        this.Hide();
                    }
                }
            }
            catch (Exception EX)
            {
                FormWarning.confirmacionForm("ERROR", EX.Message);
            }
        }

        private void BTNACTUALIZARGIRD_Click(object sender, EventArgs e)
        {
            String IDINSCRIPTION = INSCRIPCIONCREADA(Login.username, FECHAINSCRIP);
            mostrargruposinscritos(Convert.ToInt32(IDINSCRIPTION));
            mostrargrupos(Convert.ToInt32(CBMATERIAS.SelectedValue.ToString()),Convert.ToInt32(CICLO));
        }

        private void GRIDGrupos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GRIDGrupos.Rows[e.RowIndex].Cells["HORARIOS"].Selected)
            {
                String IDINSCRIPTION = INSCRIPCIONCREADA(Login.username, FECHAINSCRIP);
                HORARIOSGRUPOS FRM = new HORARIOSGRUPOS();
                FRM.TXTNOMGRUPO.Text = GRIDGrupos.Rows[e.RowIndex].Cells["Nombre_Grupo"].Value.ToString();
                FRM.TXTMAESTRO.Text = GRIDGrupos.Rows[e.RowIndex].Cells["Maestro"].Value.ToString();
                FRM.IDMATERIA = CBMATERIAS.SelectedValue.ToString();
                FRM.IDGRUPO = GRIDGrupos.Rows[e.RowIndex].Cells["ID_Grupo"].Value.ToString();
                FRM.ShowDialog();
                mostrargruposinscritos(Convert.ToInt32(IDINSCRIPTION));
                mostrargrupos(Convert.ToInt32(CBMATERIAS.SelectedValue.ToString()), Convert.ToInt32(CICLO));
            }
        }
        DataSet OBTENERIDALUMNOGRUPO(string CARNE, int IDGRUPO)
        {
            DataSet DS = new DataSet();
            DataTable DT = new DataTable();
            DT = NEG.IDALUMNO_GRUPOID(CARNE, IDGRUPO);
            DS = DatatabletoDataset(DT);
            return DS;
        }
        private void GRIDgruposinscritos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GRIDgruposinscritos.Rows[e.RowIndex].Cells["DELETE"].Selected)
                {
                    FormInformacion FRM = new FormInformacion("ESTA SEGURO DE ELIMINAR LA INSCRIPCION DE ESTE GRUPO ?","SE ELIMINARA ESTA INSCRIPCION A ESTE GRUPO ?");
                    DialogResult RESULT = FRM.ShowDialog();
                    if (RESULT == DialogResult.OK)
                    {
                        //BORRAR GRUPOS INSCRIPCION
                        string ID = INSCRIPCIONCREADA(Login.username, FECHAINSCRIP);
                        int IDINSCRIPCION = Convert.ToInt32(ID);
                        int idgrupo = Convert.ToInt32(GRIDgruposinscritos.Rows[e.RowIndex].Cells["ID_Grupo"].Value.ToString());
                        String IDMATERIA = GRIDgruposinscritos.Rows[e.RowIndex].Cells["ID_Materia"].Value.ToString();
                        DataSet DS = OBTENERIDALUMNOGRUPO(Login.username, idgrupo);
                        int ID_Alumno_Grupo = Convert.ToInt32(DS.Tables[0].Rows[0]["ID_Alumno_Grupo"].ToString().Trim());
                        NEG.DELETEGRUPOINSCRITO(IDINSCRIPCION,idgrupo,Login.username, ID_Alumno_Grupo);
                        //BORRAR GRUPOS INSCRIPCION

                        FormSucces.confirmacionForm("SE RETIRO SU INSCRIPCION A ESTE GRUPO");
                        mostrargruposinscritos(IDINSCRIPCION);
                    }
                }
            }
            catch (Exception EX)
            {
                FormWarning.confirmacionForm("ERROR", EX.Message);
            }
        }

        private void Inscripcion_Load(object sender, EventArgs e)
        {
            APARECER.ShowAsyc(this);
        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            FormInformacion FRM = new FormInformacion("ESTA SEGURO DE CERRAR ESTA VENTANA", "SI CIERRRA LA VENTANA EL PROCESO SE CANCELARA ESTA SEGURO DE HACERLO ?");
            DialogResult RESULT = FRM.ShowDialog();
            if(RESULT == DialogResult.OK)
            {
                this.Close();
            }
           
        }
    }
}



