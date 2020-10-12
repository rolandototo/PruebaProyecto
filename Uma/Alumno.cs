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
    public partial class Alumno : Form
    {
        public Alumno()
        {
            InitializeComponent();
        }
        private string ID_Alum;
        private List<Grupos_Alum> grupos_Alum;
        private string Sede;
        private string Carrera;
        private int Ciclo;
        private double Cuota;
        private List<Grupos_Alum> Grupos_Alum { get => grupos_Alum; set => grupos_Alum = value; }

        private void Perfil() { }

        public void Mostrar_Grupos() { }

        public void Click_Grupos() { }

        public void Crear() { }

        public void Destruir() { }

        //public override string Edit_Connection()
        //{
        //    return "";
        //}
    }
    public class Grupos_Alum
    {

        public Grupos_Alum()
        {
        }
        private string carnet;
        private List<InnerGroupAlum> innerGruopAlum;
        private string iD_Grupo;

        public string Carnet { get => carnet; set => carnet = value; }
        public string ID_Grupo { get => iD_Grupo; set => iD_Grupo = value; }
        public List<InnerGroupAlum> InnerGruopAlum { get => innerGruopAlum; set => innerGruopAlum = value; }

        public void Edit_Conection()
        { }

    }
    public class InnerGroupAlum
    {
        public InnerGroupAlum()
        {
        }
        private string grupo;
        private double promedio;
        public string Grupo { get => grupo; set => grupo = value; }
        public double Promedio { get => promedio; set => promedio = value; }
    }
}
