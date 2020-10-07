
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Inner_Group_Notas_Alum : Alumno 
{

    public Inner_Group_Notas_Alum() 
    {}

    public <List>Notas_Alum;


    public void Mostrar_Notas() {}

    public void Apelar_Nota() {}

    public void Mostrar_Doc_Revisado() {}

    public void Edit_Conection() {}

}
public class Notas_Alum
{

    public Notas_Alum()
    {
    }

    private string carnet;
    private string detalle_Nota ;
    private string iD_Materia ;
    private int porcen_Nota ;
    private double nota ;
    private Int ciclo;
    private int año;

    public string Carnet { get => carnet; set => carnet = value; }
    public string Detalle_Nota { get => detalle_Nota; set => detalle_Nota = value; }
    public string ID_Materia { get => iD_Materia; set => iD_Materia = value; }
    public int Porcen_Nota { get => porcen_Nota; set => porcen_Nota = value; }
    public double Nota { get => nota; set => nota = value; }
    public Int Ciclo { get => ciclo; set => ciclo = value; }
    public int Año { get => año; set => año = value; }
}