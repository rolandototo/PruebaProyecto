
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Alumno : LogIn {

    public Alumno() {
    }

    public string ID_Alum;
    public <List>Grupos_Alum;
    public string Sede;
    public string Carrera;
    public int Ciclo;
    public double Cuota;


    private void Perfil() {
        
    }

    public void Mostrar_Grupos() {
       
    }

    public void Click_Grupos() {
        
    }

    public void Crear() {
       
    }

    public void Destruir() {
        
    }

    public void Edit_Conection() {
       
    }
}
public class Grupos_Alum
{

    public Grupos_Alum()
    {
    }
    private string carnet;
    private <List>innerGruopAlum;
    private string iD_Grupo ;
    public List<Alumno> InnerGruopAlum { get => innerGruopAlum; set => innerGruopAlum = value; }
    public string Carnet { get => carnet; set => carnet = value; }
    public string ID_Grupo { get => iD_Grupo; set => iD_Grupo = value; }
    public void Edit_Conection()
    { }
    
}
public class InnerGroupAlum
{

    public InnerGruopAlum()
    {
    }

    private string grupo;
    private double promedio;
    public string Grupo { get => grupo; set => grupo = value; }
    public double Promedio { get => promedio; set => promedio = value; }
}

