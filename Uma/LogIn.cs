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
    public partial class LogIn : Sql_Connection
    {
        public LogIn()
        {
            InitializeComponent();
        }
        string Pass = "";
        string ID = "";

        void Check_Pass()
        {

        }

        public override string Edit_Connection()
        {
            return "";
        }


    }
    public partial class Sql_Connection : Utilities
    {

        public Sql_Connection()
        {

        }
        public virtual string Edit_Connection()
        {
            return "";
        }
        void Insert()
        {

        }
        void Remove()
        {

        }
    }
    public partial class Utilities : Form
    {
        int Cont_Destruir = 0;

        void Destruir()
        {

        }
        void Crear()
        {

        }

        void Perfil()
        {

        }

        void Verificar_Dispo_Inscrip()
        {

        }
    }
}
