using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPAENTIDADES;
using CAPANEGOCIO;

namespace CAPAPRESENTACION
{
    public partial class Login : FormBasePrin
    {
        E_Login ent_login = new E_Login();
        N_login neg_login = new N_login();
        public static string username;
        public Login()
        {
            InitializeComponent();
        }
        void logue()
        {
            DataTable dt = new DataTable();
            ent_login.Username = TXTUSER.Text;
            ent_login.Password = TXTPASS.Text;
            dt = neg_login.mostrandoUsuarios(ent_login);

            if (dt.Rows.Count > 0)
            {
                if (Convert.ToInt32(dt.Rows[0][2]) == 1)
                {
                    FormSucces.confirmacionForm("BIENVENIDO USUARIO : " + dt.Rows[0][0].ToString());
                    username = dt.Rows[0][0].ToString();
                }
                else if (Convert.ToInt32(dt.Rows[0][3]) == 1)
                {
                    FormSucces.confirmacionForm("BIENVENIDO USUARIO : " + dt.Rows[0][0].ToString());
                    username = dt.Rows[0][0].ToString();
                    FormPRINCIPALALUMNO FRM = new FormPRINCIPALALUMNO();
                    this.Hide();
                    FRM.Show();
                }
                else if (Convert.ToInt32(dt.Rows[0][4]) == 1)
                {
                    FormSucces.confirmacionForm("BIENVENIDO USUARIO : " + dt.Rows[0][0].ToString());
                    username = dt.Rows[0][0].ToString();
                }
            }
            else
            {
                FormWarning.confirmacionForm("ERROR", "EL USUARIO O CONTRASEÑA SON INCORECTOS, REVISE POR FAVOR!");
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Login_Load(object sender, EventArgs e) {}

        private void limpiarlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TXTPASS.Text = String.Empty;
            TXTUSER.Text = String.Empty;
        }

        private void BTNLOGIN_Click_1(object sender, EventArgs e)
        {
            String URL = "http://www.google.com";
            bool WifiConnect = VerificarConexionURL(URL);
            if (WifiConnect == true)
                logue();
            else if (WifiConnect == false)
                FormWarning.confirmacionForm("ERROR", "PARA UTILIZAR EL SISTEMA NECESITA ESTAR CONECTADO A INTERNET!");
        }
        public bool VerificarConexionURL(string mURL)
        {
            System.Net.WebRequest Peticion = default(System.Net.WebRequest);
            System.Net.HttpWebResponse Respuesta = (HttpWebResponse)default(WebResponse);
            try
            {
                Peticion = System.Net.WebRequest.Create(mURL);
                Respuesta = (HttpWebResponse)Peticion.GetResponse();
                return true;
            }
            catch (System.Net.WebException ex)
            {
                if (ex.Status == System.Net.WebExceptionStatus.NameResolutionFailure)
                {
                    return false;
                }
                return false;
            }
        }
    }
}
