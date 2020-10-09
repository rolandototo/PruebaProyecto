using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uma
{
	public class Materias
	{
		public Materias() { }

		string idMateria;
		public string IdMateria { get => idMateria; set => idMateria = value; }

		string nombreMateria;
		public string NombreMateria1 { get => nombreMateria; set => nombreMateria = value; }

		string idGrupo;
		public string IdGrupo { get => idGrupo; set => idGrupo = value; }

		public List<InnerGroupIns> innerGroupIns = new List<InnerGroupIns>();
	}
	class Materias_Inscrip
    {
		public Materias_Inscrip() { }
		public List<Materias> materias = new List<Materias>();

		public void Get_Id()
		{}
		public void Verificar_Dispo_Inscrip()
		{}
		public void Mostrar_Materias()
		{}
		public void Mostrar_Group()
		{}
		public void Mostrar_Horarios()
		{}
	}

	public class InnerGroupIns
	{
		public InnerGroupIns() { }

		string idHorarios;
		string idCiclo;
		string idLab;

		public string IdHorarios { get => idHorarios; set => idHorarios = value; }
		public string IdCiclo { get => idCiclo; set => idCiclo = value; }
		public string IdLab { get => idLab; set => idLab = value; }
	}

	public class Inscribir_Materias
	{
		private DateTime fecha_incorp;
		private DateTime fecha_venci;

		public DateTime Fecha_incorp { get => fecha_incorp; set => fecha_incorp = value; }
		public DateTime Fecha_venci { get => fecha_venci; set => fecha_venci = value; }

		public void Verificar_Mensualidad()
		{}
	}
}
