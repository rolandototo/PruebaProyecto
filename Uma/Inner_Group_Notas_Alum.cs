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
    public partial class Inner_Group_Notas_Alum : Form
    {
        public Inner_Group_Notas_Alum()
        {
            InitializeComponent();
        }
        private List<Notas_Alum> notas_Alum;

        public List<Notas_Alum> Notas_Alum { get => notas_Alum; set => notas_Alum = value; }

        public void Mostrar_Notas() { }

        public void Apelar_Nota() { }

        public void Mostrar_Doc_Revisado() { }

        //public override string Edit_Connection()
        //{
        //    return "";
        //}
    }
    public class Notas_Alum
    {

        public Notas_Alum()
        {
        }

        private string carnet;
        private string detalle_Nota;
        private string iD_Materia;
        private int porcen_Nota;
        private double nota;
        private int ciclo;
        private int año;

        public string Carnet { get => carnet; set => carnet = value; }
        public string Detalle_Nota { get => detalle_Nota; set => detalle_Nota = value; }
        public string ID_Materia { get => iD_Materia; set => iD_Materia = value; }
        public int Porcen_Nota { get => porcen_Nota; set => porcen_Nota = value; }
        public double Nota { get => nota; set => nota = value; }
        public int Ciclo { get => ciclo; set => ciclo = value; }
        public int Año { get => año; set => año = value; }
    }
}
