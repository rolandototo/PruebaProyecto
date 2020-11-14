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
    public partial class FormSucces : FormInvocadoBase
    {
        public FormSucces(string mensaje)
        {
            InitializeComponent();
            LBTitulo.Text = mensaje;
        }
        public static void confirmacionForm(string mensaje)
        {
            FormSucces frm = new FormSucces(mensaje);
            frm.ShowDialog();
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSucces_Load(object sender, EventArgs e)
        {
            Esclarecerfrom.ShowAsyc(this);
        }
    }
}
