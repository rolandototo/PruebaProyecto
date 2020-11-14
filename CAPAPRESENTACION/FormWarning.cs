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
    public partial class FormWarning : FormInvocadoBase
    {
        public FormWarning(string titulo, string mensaje)
        {
            InitializeComponent();
            LBTitulo.Text = titulo;
            LBMensaje.Text = mensaje;
        }
        public static void confirmacionForm(string titulo,string mensaje)
        {
            FormWarning frm = new FormWarning(titulo,mensaje);
            frm.ShowDialog();
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormWarning_Load(object sender, EventArgs e)
        {
            esclarecer.ShowAsyc(this);
        }
    }
}
