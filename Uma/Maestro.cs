using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uma
{
    public partial class Maestro : LogIn
    {
        public Maestro()
        {
            InitializeComponent();
        }
        public void Mostrar_Grupos()
        {

        }

        public override string Edit_Connection()
        {
            return "";
        }

        public void Crear()
        {

        }

        public void Destruir()
        {

        }

        public void Perfil()
        {

        }
    }

    class Grupos
    {
        private string id_grupo;
        private string nombre_grupo;
        private string id_maestro;
        private int max_grup;

        public string ID_Grupo
        {
            get { return id_grupo; }
            set { id_grupo = value; }
        }

        public string Nombre_Grupo
        {
            get { return nombre_grupo; }
            set { nombre_grupo = value; }
        }

        public string ID_Maestro
        {
            get { return id_maestro; }
            set { id_maestro = value; }
        }

        public int Max_Grup
        {
            get { return max_grup; }
            set { max_grup = value; }
        }

    }
}
