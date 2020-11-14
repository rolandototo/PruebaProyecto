using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPAENTIDADES
{
    public class E_Alumno
    {
        public string Carnet { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Correo_Alternativo { get; set; }
        public string Sede { get; set; }
        public string NombreCarrera { get; set; }
    }
    public class E_Inscripcion
    {
        public int Id_inscripcion { get; set; }
        public string Carnet { get; set; }
        public DateTime Fecha_inscripcion { get; set; }
        public Decimal Cuota { get; set; }
        public Decimal Total { get; set; }
        public DateTime Fecha_vencimiento { get; set; }
        public int Id_ciclo { get; set; }
    }
    public class E_Ciclo
    {
        public int Idciclo { get; set; }
        public string CODECICLO { get; set; }
        public string Detalle_ciclo { get; set; }
        public int Id_sede { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public DateTime FechaRetiro { get; set; }
    }
    public class E_Materia
    {
        public int Idmateria { get; set; }
        public string CODEMATERIA { get; set; }
        public string Nombre_materia { get; set; }
        public int U_v { get; set; }
        public int Id_pensum { get; set; }
        public int Idciclo { get; set; }
        public int Anno { get; set; }
        public string Requisitos { get; set; }
    }
    public class E_MATERIASINSCRITAS
    {
        public int IDMateria { get; set; }
        public string CODEMATERIA { get; set; }
        public string NombreMateria { get; set; }
        public int U_V { get; set; }
        public string Requisitos { get; set; }
        public string Estado { get; set; }
    }
    //clase que podria ser necesaria en un futuro
    public class E_Horarios
    {
        public int Id_horario { get; set; }
        public string Detalle_horario { get; set; }
        public string Dias { get; set; }
        public string Hora_inicio { get; set; }
        public string Hora_fin { get; set; }
    }
    public class E_CARRERACUOTA
    {
        public decimal Cuota { get; set; }
        public int Idcarrera { get; set; }
        public string Nombre_carrera { get; set; }
    }
    public class E_verINSCRIPCION
    {
        public int ID_Inscripcion { get; set; }
        public string Carnet { get; set; }
        public DateTime Fecha_Inscripcion{ get; set; }
        public decimal Cuota { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha_INSCRIP_Vencimiento { get; set; }
        public int ID_Ciclo { get; set; }
    }
    public class E_DETALLE_GRUPO_ALUMNO
    {
        public string Carnet { get; set; }
        public int Id_Grupo { get; set; }
        public string Detalle { get; set; }
        public int ID_Inscripcion { get; set; }
        public int IDMateria { get; set; }
        public string ESTADO { get; set; }
    }
    public class E_PAGO
    {
        public int IDPago { get; set; }
        public string DetallePago { get; set; }
        public decimal Monto { get; set; }
        public int IDInscripcion { get; set; }
        public int IDMensualidad { get; set; }
        public string MetodoPago { get; set; }
        public string Carnet { get; set; }
        public DateTime FechaPago { get; set; }
        public int PagoStatus { get; set; }
    }
    public class E_NOTAS
    {
        public string Evaluacion { get; set; }
        public Double Porcentaje_Nota { get; set; }
        public Double Nota { get; set; }
    }
    public class E_FACTURA
    {
        public int IDPago { get; set; }
        public string MES { get; set; }
        public string DetallePago { get; set; }
        public decimal Monto { get; set; }
        public string MetodoPago { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }
}
