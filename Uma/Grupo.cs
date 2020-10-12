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
    public partial class Grupo : Form
    {
        public Grupo()
        {
            InitializeComponent();
        }
        static void Call_Honorarios()
        {

        }

        static void Mostrar_Alumnos()
        {

        }

        static void Click_Alumno()
        {

        }

        static void Mostrar_Materia()
        {

        }

        //public override string Edit_Connection()
        //{
        //    return "";
        //}
    }
    class Alum
    {
        private string id_alum;
        private string id_materia;
        private string id_grupo;
        private string id_honorarios;
        private string nom_ape_alum;
        private string materia;

        public string ID_Alum
        {
            get { return id_alum; }
            set { id_alum = value; }
        }

        public string ID_Materia
        {
            get { return id_materia; }
            set { id_materia = value; }
        }

        public string ID_Grupo
        {
            get { return id_grupo; }
            set { id_grupo = value; }
        }

        public string ID_Honorarios
        {
            get { return id_honorarios; }
            set { id_honorarios = value; }
        }

        public string Nom_Ape_Alum
        {
            get { return nom_ape_alum; }
            set { nom_ape_alum = value; }
        }

        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        }
    }
}
