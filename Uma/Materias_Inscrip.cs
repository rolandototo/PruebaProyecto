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
    public partial class Materias_Inscrip : Form

    {
        public Materias_Inscrip()
        {
            InitializeComponent();
        }
        public List<Materias> ID_Materias;

        void Get_Materias_Inscritas()
        {

        }
        void Get_Id()
        {

        }
        void Verificar_Dispo_Inscrip()
        {

        }
        void Mostrar_MAteria()
        {

        }
        void Mostrar_Grupo()
        {

        }
        void Mostrar_Horarios()
        {

        }
    }
	public class Materias
	{
		public Materias() { }

        string ID_Materia { get; set; }
        string Nombre_Materia { get; set; }
        public List<InnerGroupIns> InGrupo { get; set; }

        string ID_Grupo { get; set; }
    }

    public class InnerGroupIns
    {
        string ID_Horarios { get; set; }
        string ID_Ciclo { get; set; }
        string ID_Lab { get; set; }

    }
    public class Inscribir_Materias : Alumno
    {
        DateTime Fecha_Incorp;
        DateTime Fecha_Vencimiento;

        void Verificcar_Mensualidad()
        {
            
        }

    }
}
