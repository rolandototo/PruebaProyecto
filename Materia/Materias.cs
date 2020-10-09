using System;
using System.Collections.Generic;

public class Materias
{
	public Materias() {}

	string idMateria;
    public string IdMateria { get => idMateria; set => idMateria = value; }

	string nombreMateria;
	public string NombreMateria1 { get => nombreMateria; set => nombreMateria = value; }

	string idGrupo;
	public string IdGrupo { get => idGrupo; set => idGrupo = value; }

	public List <InnerGroupIns> = new InnerGroupIns;
}

public class Materias_Inscrip
{
    public Materias_Inscrip() { }
    public List <Materias> = new Materias;

    public void Get_Id()
    {

    }
    public void Verificar_Dispo_Inscrip()
    {

    }
    public void Mostrar_Materias()
    {

    }
    public void Mostrar_Group()
    {

    }
    public void Mostrar_Horarios()
    {

    }
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
    private datetime fecha_incorp;
    private datetime fecha_venci;

    public datetime Fecha_incorp { get => fecha_incorp; set => fecha_incorp = value; }
    public datetime Fecha_venci { get => fecha_venci; set => fecha_venci = value; }

    public void Verificar_Mensualidad()
    {

    }
}