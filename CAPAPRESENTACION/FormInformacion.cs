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
    public partial class FormInformacion : FormInvocadoBase
    {
        public FormInformacion(string titulo,string mensaje)
        {
            InitializeComponent();
            LBTitulo.Text = titulo;
            LBMensaje.Text = mensaje;
        }

        private void FormInformacion_Load(object sender, EventArgs e)
        {
            esclarecer.ShowAsyc(this);
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btncalcelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
