using CAPAENTIDADES;
using CAPANEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Threading;

namespace CAPAPRESENTACION
{
    public partial class FormPRINCIPALALUMNO : FormBasePrin
    {
        public FormPRINCIPALALUMNO()
        {
            InitializeComponent();
            AbrirForms(new FormDefault());
            //botones
            LeftBorderButtom = new Panel();
            LeftBorderButtom.Size = new Size(7, 60);
            Sidebar.Controls.Add(LeftBorderButtom);
        }
        //propiedades para boton
        private IconButton currentBotton;
        private Panel LeftBorderButtom;
        //metodos botones
        private void ActivateButtom(object senderBtn,Color color)
        {
            if(senderBtn != null)
            {
                DisableButtom();
                currentBotton = (IconButton)senderBtn;
                currentBotton.BackColor = Color.FromArgb(30,30,46);
                currentBotton.ForeColor = color;
                currentBotton.TextAlign = ContentAlignment.MiddleCenter;
                currentBotton.IconColor = color;
                currentBotton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBotton.ImageAlign = ContentAlignment.MiddleRight;
                //leftbotderbuttom
                LeftBorderButtom.BackColor = color;
                LeftBorderButtom.Location = new Point(0,currentBotton.Location.Y);
                LeftBorderButtom.Visible = true;
                LeftBorderButtom.BringToFront();
                //Icono Panel top
                IconBoxCurrent.IconChar = currentBotton.IconChar;
                IconBoxCurrent.IconColor = color;
            }
        }
        private void DisableButtom()
        {
            if(currentBotton != null)
            {
                currentBotton.BackColor = Color.FromArgb(39,41,61);
                currentBotton.ForeColor = Color.Gainsboro;
                currentBotton.TextAlign = ContentAlignment.MiddleLeft;
                currentBotton.IconColor = Color.Gainsboro; 
                currentBotton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBotton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        public Form formActivo = null;
        public void AbrirForms(Form FormHijo)
        {
            if (formActivo != null)
                formActivo.Close();
            formActivo = FormHijo;
            //le decimos que es un formulario hijo
            FormHijo.TopLevel = false;
            //le decimos que habarque todo el panel
            FormHijo.Dock = DockStyle.Fill;
            //agregando el form
            PanelChart.Controls.Add(FormHijo);
            //obtiene sus datos
            PanelChart.Tag = FormHijo;
            //poniendolo adelante
            FormHijo.BringToFront();
            FormHijo.Show();
        }



        private void FormPRINCIPALALUMNO_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LOGOpicturebox_Click(object sender, EventArgs e)
        {
            Reset();
            AbrirForms(new FormDefault());
        }
        private void Reset()
        {
            DisableButtom();
            LeftBorderButtom.Visible = false;
            IconBoxCurrent.IconChar = IconChar.Home;
            IconBoxCurrent.IconColor = Color.DimGray;
            lbtitulo.Text = "DASHBOARD";
        }

        private void BTNPERFIL_Click_1(object sender, EventArgs e)
        {
            ActivateButtom(sender, Color.FromArgb(95,77,221));
            AbrirForms(new Perfil());
        }
        DataSet verificarmateriasinscrtas(string CARNE)
        {
            DataSet ds;
            List<E_MATERIASINSCRITAS>LISTA = new List<E_MATERIASINSCRITAS>();
            LISTA = NEG.materiasINSCRITASS(CARNE);
            ds = ToDataSet<E_MATERIASINSCRITAS>(LISTA);
            return ds;
        }
        String MATINS;
        private void BTNNOTAS_Click_1(object sender, EventArgs e)
        {
            try
            {
                ActivateButtom(sender, Color.FromArgb(95, 77, 221));
                DataSet DS = verificarmateriasinscrtas(Login.username);
                MATINS = DS.Tables[0].Rows[0]["IDMateria"].ToString();
                AbrirForms(new Notas());
            }
            catch(Exception)
            {
                FormWarning.confirmacionForm("ERROR", "NO HA INSCRITO NINGUNA MATERIA, POR LO TANTO NO PUEDE VER NOTAS");
            }
            
        }

        private void BTNMISGRUPOS_Click_1(object sender, EventArgs e)
        {
            ActivateButtom(sender, Color.FromArgb(95, 77, 221));
            AbrirForms(new Grupos());
        }

        private void BTNPAGOS_Click_1(object sender, EventArgs e)
        {
            ActivateButtom(sender, Color.FromArgb(95, 77, 221));
            AbrirForms(new Pagos());
        }
        DataSet ciclosegunfechaInscripcion(string buscar)
        {

            DateTime fecha = Convert.ToDateTime(buscar);
            List<E_Ciclo> ciclos = new List<E_Ciclo>();
            ciclos = NEG.listandociclos(fecha);
            DataSet dsciclos = ToDataSet<E_Ciclo>(ciclos);
            return dsciclos;
        }
        string idciclofechains;
        private void btnInscripcion_Click_1(object sender, EventArgs e)
        {
            try
            {
                ActivateButtom(sender, Color.FromArgb(95, 77, 221));
                string HOY = DateTime.Now.ToString("yyyy-MM-dd");
                DataSet ds = ciclosegunfechaInscripcion(HOY);
                idciclofechains = ds.Tables[0].Rows[0]["Idciclo"].ToString();
                
                string mensaje = "Al momento de darle a ACEPTAR tendra 24h para cancelar (Inicie el proceso solo si esta seguro)";
                FormInformacion frm = new FormInformacion("ESTA SEGURO DE REALIZAR LA INSCRIPCION ?", mensaje);
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    CONFIRMACION_INSCRIPCION FR = new CONFIRMACION_INSCRIPCION();
                    CONFIRMACION_INSCRIPCION.IDCICLO = idciclofechains;
                    DialogResult RESUL = FR.ShowDialog();
                    if (RESUL == DialogResult.OK)
                    {
                        Inscripcion form = new Inscripcion();
                        Inscripcion.CICLO = idciclofechains;
                        form.ShowDialog();
                    }
                }
            }
            catch (Exception)
            {
                FormWarning.confirmacionForm("ERROR", "NO ES FECHA DE INSCRIPCION");
            }
            
        }

        private void BTNMATERIAS_Click_1(object sender, EventArgs e)
        {
            ActivateButtom(sender, Color.FromArgb(95, 77, 221));
            AbrirForms(new materias());
        }

        private void btncerrarsesion_Click_1(object sender, EventArgs e)
        {
            try
            {
                ActivateButtom(sender, Color.FromArgb(95, 77, 221));
                FormInformacion FRM = new FormInformacion("DESEA SALIR DEL SISTEMA", "REGRESARA AL LOGIN");
                DialogResult RESULT = FRM.ShowDialog();
                if (RESULT == DialogResult.OK)
                {
                    Login frm = new Login();
                    this.Hide();
                    frm.Show();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("PASO ALGO XD... " + EX.Message);
            }
        }
        N_Alumno NEG = new N_Alumno();
        DataSet ciclosegunfechaRETIRO(string buscar)
        {
            DataSet dsciclos;
            DateTime fecha = Convert.ToDateTime(buscar);
            List<E_Ciclo> ciclos = new List<E_Ciclo>();
            ciclos = NEG.CICLOPEFCHARETIRO(fecha);
            dsciclos = ToDataSet<E_Ciclo>(ciclos);
            return dsciclos;
        }
        string idciclofecharetiro;
        private void BTNRETIROS_Click(object sender, EventArgs e)
        {
            try
            {
                ActivateButtom(sender, Color.FromArgb(95, 77, 221));
                string HOY = DateTime.Now.ToString("yyyy-MM-dd");
                DataSet DS = ciclosegunfechaRETIRO(HOY);
                idciclofecharetiro = DS.Tables[0].Rows[0]["Idciclo"].ToString();
                Retiros.IDCICLO = Convert.ToInt32(idciclofecharetiro);
                Retiros.DETALLECICLO = DS.Tables[0].Rows[0]["Detalle_ciclo"].ToString();
                AbrirForms(new Retiros());
            }
            catch (Exception)
            {
                FormWarning.confirmacionForm("ERROR", "NO ES FECHA DE RETIRAR MATERIAS");
            }

        }
    }
}
