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
    public partial class Perfil : FormInvocadoBase
    {
        N_Alumno neg = new N_Alumno();
        E_Alumno entities = new E_Alumno();
        List<E_Alumno> lista = new List<E_Alumno>();
        DataSet ds = new DataSet();
       
        public Perfil()
        {
            InitializeComponent();
            lbUSER.Text += Login.username;
        }
        void cargardatos(string carne)
        {
            lista = neg.obtenerAlumno(carne);
            ds = ToDataSet<E_Alumno>(lista);
            txtnombre.Text = ds.Tables[0].Rows[0]["Nombres"].ToString().Trim();
            txtapellidos.Text = ds.Tables[0].Rows[0]["Apellidos"].ToString().Trim();
            txttelefono.Text = ds.Tables[0].Rows[0]["Telefono"].ToString().Trim();
            txtdireccion.Text = ds.Tables[0].Rows[0]["Direccion"].ToString().Trim();
            txtcorreo.Text = ds.Tables[0].Rows[0]["Correo"].ToString().Trim();
            txtcorreosec.Text = ds.Tables[0].Rows[0]["Correo_Alternativo"].ToString().Trim();
            txtsede.Text = ds.Tables[0].Rows[0]["Sede"].ToString().Trim(); 
            LBCARRERA.Text = "Carrera: " + ds.Tables[0].Rows[0]["NombreCarrera"].ToString().Trim();
            txtnombre.Enabled = false;
            txtapellidos.Enabled = false;
            txttelefono.Enabled = false;
            txtdireccion.Enabled = false;
            txtcorreo.Enabled = false;
            txtcorreosec.Enabled = false;
            txtsede.Enabled = false;
            BTNGUARDAR.Visible = false;
        }
        private void Perfil_Load(object sender, EventArgs e)
        {
            try
            {
                cargardatos(Login.username);//Login.username);
            }
            catch(Exception EX)
            {
                FormWarning.confirmacionForm("ERROR", EX.Message);
            }
        }

        private void BTNEDITAR_Click(object sender, EventArgs e)
        {
            try
            {
                txttelefono.Enabled = true;
                txtdireccion.Enabled = true;
                txtcorreo.Enabled = true;
                txtcorreosec.Enabled = true;
                BTNGUARDAR.Visible = true;
            }
            catch (Exception EX)
            {
                FormWarning.confirmacionForm("ERROR", EX.Message);
            }
        }

        private void BTNGUARDAR_Click_1(object sender, EventArgs e)
        {
            try
            {
                FormInformacion FRM = new FormInformacion("DE VERDAD QUIERE GUARDAR CAMBIOS ?", "PREGUNTA SERIA .__.");
                DialogResult RESULT = FRM.ShowDialog();
                if (RESULT == DialogResult.OK)
                {
                    entities.Carnet = Login.username;
                    entities.Telefono = Convert.ToInt32(txttelefono.Text);
                    entities.Direccion = txtdireccion.Text;
                    entities.Correo = txtcorreo.Text;
                    entities.Correo_Alternativo = txtcorreosec.Text;

                    neg.ACTUALIZARDATOSALUM(entities);
                    MessageBox.Show("Editado Correctamente..");
                    cargardatos(Login.username);
                    BTNGUARDAR.Visible = false;
                }
                else
                {
                    cargardatos(Login.username);
                    BTNGUARDAR.Visible = false;
                }
            }
            catch (Exception EX)
            {
                FormWarning.confirmacionForm("ERROR", EX.Message);
            }
        }
    }

}
