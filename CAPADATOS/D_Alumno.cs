using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CAPAENTIDADES;
using System.Data;
using System.Runtime.Remoting.Channels;
using System.Net.Http.Headers;

namespace CAPADATOS
{
    public class D_Alumno
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public List<E_Alumno> listarDatosAlumnos(string carne)
        {
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_CARGARDATOSALUMNO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@CARNET", carne);
            leerfilas = cmd.ExecuteReader();
            List<E_Alumno> listar = new List<E_Alumno>();
            while (leerfilas.Read())
            {
                listar.Add(new E_Alumno
                {
                    Carnet = leerfilas.GetString(0),
                    Nombres = leerfilas.GetString(1),
                    Apellidos = leerfilas.GetString(2),
                    Telefono = leerfilas.GetInt32(3),
                    Direccion = leerfilas.GetString(4),
                    Correo = leerfilas.GetString(5),
                    Correo_Alternativo = leerfilas.GetString(6),
                    Sede = leerfilas.GetString(7),
                    NombreCarrera = leerfilas.GetString(8)
                });
            }
            conexion.Close();
            leerfilas.Close();
            return listar;
        }
        public void ACTUALIZARDATOSALUMNO(E_Alumno sender)
        {
            SqlCommand cmd = new SqlCommand("SP_ACTUALIZARDATOSALUMNO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@Carnet", sender.Carnet);
            cmd.Parameters.AddWithValue("@Telefono", sender.Telefono);
            cmd.Parameters.AddWithValue("@Direccion", sender.Direccion);
            cmd.Parameters.AddWithValue("@Correo", sender.Correo);
            cmd.Parameters.AddWithValue("@Correo_Alternativo", sender.Correo_Alternativo);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void NUEVAINSCRIPCION(E_Inscripcion SENDER)
        {
            SqlCommand cmd = new SqlCommand("SP_CREARINSCRIPCION", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@CARNET", SENDER.Carnet);
            cmd.Parameters.AddWithValue("@Fecha_Inscripcion", SENDER.Fecha_inscripcion);
            cmd.Parameters.AddWithValue("@Cuota", SENDER.Cuota);
            cmd.Parameters.AddWithValue("@Total", SENDER.Total);
            cmd.Parameters.AddWithValue("@Fecha_INSCRIP_Vencimiento", SENDER.Fecha_vencimiento);
            cmd.Parameters.AddWithValue("@ID_Ciclo", SENDER.Id_ciclo);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public List<E_Ciclo> LISTARCICLOSPORFECHAINS(DateTime fecha)
        {
            SqlDataReader leerfilas;
            SqlCommand comando = new SqlCommand("SP_FECHAINSCRIPCION", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.Parameters.AddWithValue("@FECHA", fecha);
            leerfilas = comando.ExecuteReader();
            List<E_Ciclo> lista = new List<E_Ciclo>();
            while (leerfilas.Read())
            {
                lista.Add(new E_Ciclo
                {
                    Idciclo = leerfilas.GetInt32(0),
                    CODECICLO = leerfilas.GetString(1),
                    Detalle_ciclo = leerfilas.GetString(2),
                    Id_sede = leerfilas.GetInt32(3),
                    FechaInicio = leerfilas.GetDateTime(4),
                    FechaFin = leerfilas.GetDateTime(5),
                    FechaInscripcion = leerfilas.GetDateTime(6),
                    FechaRetiro = leerfilas.GetDateTime(7)
                });

            }
            conexion.Close();
            leerfilas.Close();
            return lista;
        }
        public List<E_Ciclo> LISTARCICLOSPORFECHARETIRO(DateTime FECHA)
        {
            SqlDataReader leerfilas;
            SqlCommand comando = new SqlCommand("SP_FECHARETIRO", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.Parameters.AddWithValue("@FECHA", FECHA);
            leerfilas = comando.ExecuteReader();
            List<E_Ciclo> lista = new List<E_Ciclo>();
            while (leerfilas.Read())
            {
                lista.Add(new E_Ciclo
                {
                    Idciclo = leerfilas.GetInt32(0),
                    CODECICLO = leerfilas.GetString(1),
                    Detalle_ciclo = leerfilas.GetString(2),
                    Id_sede = leerfilas.GetInt32(3),
                    FechaInicio = leerfilas.GetDateTime(4),
                    FechaFin = leerfilas.GetDateTime(5),
                    FechaInscripcion = leerfilas.GetDateTime(6),
                    FechaRetiro = leerfilas.GetDateTime(7)
                });

            }
            conexion.Close();
            leerfilas.Close();
            return lista;
        }
        public List<E_Materia> LISTANDOMATERIAS(int IDCARRERA)
        {
            SqlDataReader leerfilas;
            SqlCommand comando = new SqlCommand("SP_MATERIAPORCARRERA", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.Parameters.AddWithValue("@IDCARRERA", IDCARRERA);
            leerfilas = comando.ExecuteReader();
            List<E_Materia> LISTA = new List<E_Materia>();
            while (leerfilas.Read())
            {
                LISTA.Add(new E_Materia
                {
                    Idmateria = leerfilas.GetInt32(0),
                    CODEMATERIA = leerfilas.GetString(1),
                    Nombre_materia = leerfilas.GetString(2),
                    U_v = leerfilas.GetInt32(3),
                    Id_pensum = leerfilas.GetInt32(4),
                    Idciclo = leerfilas.GetInt32(5),
                    Anno = leerfilas.GetInt32(6),
                    Requisitos = leerfilas.GetString(7),
                });
            }
            conexion.Close();
            leerfilas.Close();
            return LISTA;
        }
        public DataTable LISTARGRUPOS(int idmateria, int idciclo)
        {
            DataTable TABLA = new DataTable();
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_MOSTRARGRUPOS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDMATERIA", idmateria);
            cmd.Parameters.AddWithValue("@IDCICLO", idciclo);
            leerfilas = cmd.ExecuteReader();
            TABLA.Load(leerfilas);
            leerfilas.Close();
            conexion.Close();
            return TABLA;
        }
        public DataTable listarhorarios(int idgrupo)
        {
            DataTable TABLA = new DataTable();
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_MOSTRARHORARIOS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDGRUPO", idgrupo);
            leerfilas = cmd.ExecuteReader();
            TABLA.Load(leerfilas);
            leerfilas.Close();
            conexion.Close();
            return TABLA;
        }
        public DataTable REGISTROESTUDIANTESINSCRITOS(int IDGRUPO)
        {
            DataTable TABLA = new DataTable();
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_ESTUDIANTESACTUALEMENTEINSCRITOS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue ("@IDGRUPO", IDGRUPO);
            leerfilas = cmd.ExecuteReader();
            TABLA.Load(leerfilas);
            leerfilas.Close();
            conexion.Close();
            return TABLA;
        }
        public List<E_CARRERACUOTA> cuotaycarrera(string carnet)
        {
            SqlDataReader leerfilas;
            SqlCommand comando = new SqlCommand("SP_CUOTA", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.Parameters.AddWithValue("@CARNET", carnet);
            leerfilas = comando.ExecuteReader();
            List<E_CARRERACUOTA> LISTA = new List<E_CARRERACUOTA>();
            while (leerfilas.Read())
            {
                LISTA.Add(new E_CARRERACUOTA
                {
                    Cuota = leerfilas.GetDecimal(0),
                    Idcarrera = leerfilas.GetInt32(1),
                    Nombre_carrera = leerfilas.GetString(2)
                });
            }
            conexion.Close();
            leerfilas.Close();
            return LISTA;
        }
        public List<E_verINSCRIPCION> listarlainscripcion(string CARNE, DateTime FECHAINSCRIPCION)
        {
            SqlDataReader leerfilas;
            SqlCommand comando = new SqlCommand("SP_VERINSCRIPCIONESREALIZADA", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.Parameters.AddWithValue("@CARNET", CARNE);
            comando.Parameters.AddWithValue("@FECHADEINSCRIPCION", FECHAINSCRIPCION);
            leerfilas = comando.ExecuteReader();
            List<E_verINSCRIPCION> LISTA = new List<E_verINSCRIPCION>();
            while (leerfilas.Read())
            {
                LISTA.Add(new E_verINSCRIPCION
                {
                    ID_Inscripcion = leerfilas.GetInt32(0),
                    Carnet = leerfilas.GetString(1),
                    Fecha_Inscripcion = leerfilas.GetDateTime(2),
                    Cuota = leerfilas.GetDecimal(3),
                    Total = leerfilas.GetDecimal(4),
                    Fecha_INSCRIP_Vencimiento = leerfilas.GetDateTime(5),
                    ID_Ciclo = leerfilas.GetInt32(6)
                });
            }
            conexion.Close();
            leerfilas.Close();
            return LISTA;
        }
        public void CREAR_DETALLE_GRUPO_ALUMNO(E_DETALLE_GRUPO_ALUMNO SENDER)
        {
            SqlCommand cmd = new SqlCommand("SP_CREARGRUPOALUMNOELEGIDO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@CARNET", SENDER.Carnet);
            cmd.Parameters.AddWithValue("@IDGRUPO", SENDER.Id_Grupo);
            cmd.Parameters.AddWithValue("@DETALLE", SENDER.Detalle);
            cmd.Parameters.AddWithValue("@IDINSCRIPCION", SENDER.ID_Inscripcion);
            cmd.Parameters.AddWithValue("@IDMATERIA", SENDER.IDMateria);
            cmd.Parameters.AddWithValue("@ESTADO", SENDER.ESTADO);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public DataTable ALUMNO_GRUPOID(String CARNE, int IDGRUPO)
        {
            //PARA OBTENER EL ID_Alumno_Grupo
            DataTable TABLA = new DataTable();
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_VERGRUPOSYMATERIASINSCRITAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@CARNET", CARNE);
            cmd.Parameters.AddWithValue("@IDGRUPO", IDGRUPO);
            leerfilas = cmd.ExecuteReader();
            TABLA.Load(leerfilas);
            leerfilas.Close();
            conexion.Close();
            return TABLA;
        }
        public DataTable GRUPO_NOTAS(int IDGRUPO)
        {
            //PARA OBTENER EL ID_NOTAS
            DataTable TABLA = new DataTable();
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_VERGRUPONOTAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDGRUPO", IDGRUPO);
            leerfilas = cmd.ExecuteReader();
            TABLA.Load(leerfilas);
            leerfilas.Close();
            conexion.Close();
            return TABLA;
        }
        public void CREARNOTASPORGRUPO(int IDAlumnoGrupo, int IDNotas, Double NOTA)
        {
            SqlCommand cmd = new SqlCommand("SP_CREANDOALUMNONOTAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDAlumnoGrupo", IDAlumnoGrupo);
            cmd.Parameters.AddWithValue("@IDNotas", IDNotas);
            cmd.Parameters.AddWithValue("@NOTA", NOTA);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public DataTable VERGRUPOSINSCRITOS(int IDINSCRIPCION)
        {
            DataTable TABLA = new DataTable();
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_MOSTRARGRUPOSINSCRITOS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDINSCRIPCION", IDINSCRIPCION);
            leerfilas = cmd.ExecuteReader();
            TABLA.Load(leerfilas);
            leerfilas.Close();
            conexion.Close();
            return TABLA;
        }
        public void ELIMINARGRUPOINSCRITO(int IDINSCRIPCION, int idgrupo, String CARNE, int IDAlumnoGrupo)
        {
            SqlCommand cmd = new SqlCommand("SP_BORRARGRUPOYMATERIASINSCRITAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDINSCRIPCION", IDINSCRIPCION);
            cmd.Parameters.AddWithValue("@IDGRUPO", idgrupo);
            cmd.Parameters.AddWithValue("@CARNET", CARNE);
            cmd.Parameters.AddWithValue("@IDAlumnoGrupo", IDAlumnoGrupo);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public DataTable GRUPOYAINSCRITO(string CARNE, int idciclo)
        {
            DataTable TABLA = new DataTable();
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_VERGRUPOSINSCRITOSTODOS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@CARNET", CARNE);
            cmd.Parameters.AddWithValue("@ID_Ciclo", idciclo);
            leerfilas = cmd.ExecuteReader();
            TABLA.Load(leerfilas);
            leerfilas.Close();
            conexion.Close();
            return TABLA;
        }
        public List<E_Ciclo> LISTADETODOSLOSCICLOS(string BUSCAR)
        {
            SqlDataReader leerfilas;
            SqlCommand comando = new SqlCommand("SP_VERTODOSLOSCICLOS", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.Parameters.AddWithValue("@BUSCAR", BUSCAR);
            leerfilas = comando.ExecuteReader();
            List<E_Ciclo> lista = new List<E_Ciclo>();
            while (leerfilas.Read())
            {
                lista.Add(new E_Ciclo
                {
                    Idciclo = leerfilas.GetInt32(0),
                    CODECICLO = leerfilas.GetString(1),
                    Detalle_ciclo = leerfilas.GetString(2),
                    Id_sede = leerfilas.GetInt32(3),
                    FechaInicio = leerfilas.GetDateTime(4),
                    FechaFin = leerfilas.GetDateTime(5),
                    FechaInscripcion = leerfilas.GetDateTime(6),
                    FechaRetiro = leerfilas.GetDateTime(7)
                });

            }
            conexion.Close();
            leerfilas.Close();
            return lista;
        }
        public List<E_MATERIASINSCRITAS> materiasINSCRITAS(string carne)
        {
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_VERMATERIASINSCRITAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@CARNET", carne);
            leerfilas = cmd.ExecuteReader();
            List<E_MATERIASINSCRITAS> LISTA = new List<E_MATERIASINSCRITAS>();
            while (leerfilas.Read())
            {
                LISTA.Add(new E_MATERIASINSCRITAS
                {
                    IDMateria = leerfilas.GetInt32(0),
                    CODEMATERIA = leerfilas.GetString(1),
                    NombreMateria = leerfilas.GetString(2),
                    U_V = leerfilas.GetInt32(3),
                    Requisitos = leerfilas.GetString(4),
                    Estado = leerfilas.GetString(5)
                });
            }
            conexion.Close();
            leerfilas.Close();
            return LISTA;
        }
        public DataTable REGISTROSDEMATERIAS(string CARNE)
        {
            DataTable TABLA = new DataTable();
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_VERREGISTROSDEMATERIAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@CARNET", CARNE);
            leerfilas = cmd.ExecuteReader();
            TABLA.Load(leerfilas);
            leerfilas.Close();
            conexion.Close();
            return TABLA;
        }
        public DataTable IDMENSUALIDADES(string MES)
        {
            //OBTENER ID MENSUALIDAD SEGUN EL MES
            DataTable TABLA = new DataTable();
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_VERMENSUALIDADES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@MES", MES);
            leerfilas = cmd.ExecuteReader();
            TABLA.Load(leerfilas);
            leerfilas.Close();
            conexion.Close();
            return TABLA;
        }
        public void CREARPAGO(E_PAGO SENDER)
        {
            SqlCommand cmd = new SqlCommand("SP_CREACIONDEPAGOS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@Detalle_Pago", SENDER.DetallePago);
            cmd.Parameters.AddWithValue("@Monto", SENDER.Monto);
            cmd.Parameters.AddWithValue("@ID_Inscripcion", SENDER.IDInscripcion);
            cmd.Parameters.AddWithValue("@ID_Mensualidad", SENDER.IDMensualidad);
            cmd.Parameters.AddWithValue("@Carnet", SENDER.Carnet);
            cmd.Parameters.AddWithValue("@Pago_Status", SENDER.PagoStatus);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
       
        public DataTable VERPAGOS(string CARNE)
        {
            DataTable TABLA = new DataTable();
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_VERPAGOSRESTANTES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@CARNET", CARNE);
            leerfilas = cmd.ExecuteReader();
            TABLA.Load(leerfilas);
            leerfilas.Close();
            conexion.Close();
            return TABLA;
        }
        public void PAGAR(E_PAGO SENDER)
        {
            SqlCommand cmd = new SqlCommand("SP_PAGAR", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDPAGO", SENDER.IDPago);
            cmd.Parameters.AddWithValue("@DETALLEPAGO", SENDER.DetallePago);
            cmd.Parameters.AddWithValue("@METODODEPAGO", SENDER.MetodoPago);
            cmd.Parameters.AddWithValue("@FECHAPAGO", SENDER.FechaPago);
            cmd.Parameters.AddWithValue("@PAGOSTATUS", SENDER.PagoStatus);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void PAGOCONMORA(E_PAGO SENDER)
        {
            SqlCommand cmd = new SqlCommand("SP_PAGARCONMORA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDPAGO", SENDER.IDPago);
            cmd.Parameters.AddWithValue("@DETALLEPAGO", SENDER.DetallePago);
            cmd.Parameters.AddWithValue("@MONTO", SENDER.Monto);
            cmd.Parameters.AddWithValue("@METODODEPAGO", SENDER.MetodoPago);
            cmd.Parameters.AddWithValue("@FECHAPAGO", SENDER.FechaPago);
            cmd.Parameters.AddWithValue("@PAGOSTATUS", SENDER.PagoStatus);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public List<E_NOTAS> LISTARNOTAS(string CARNE, int IDMATERIA)
        {
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_VERNOTAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDMATERIA", IDMATERIA);
            cmd.Parameters.AddWithValue("@CARNET", CARNE);
            leerfilas = cmd.ExecuteReader();
            List<E_NOTAS> LISTA = new List<E_NOTAS>();
            while (leerfilas.Read())
            {
                LISTA.Add(new E_NOTAS
                {
                    Evaluacion = leerfilas.GetString(0),
                    Porcentaje_Nota = leerfilas.GetDouble(1),
                    Nota = leerfilas.GetDouble(2),
                });
            }
            conexion.Close();
            leerfilas.Close();
            return LISTA;
        }
        public DataTable MOSTRARMATERIAARETIRAR(String CARNE, int IDCICLOS)
        {
            DataTable TABLA = new DataTable();
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_MATERIASARETIRAR", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@CARNET", CARNE);
            cmd.Parameters.AddWithValue("@ID_Ciclo", IDCICLOS);
            leerfilas = cmd.ExecuteReader();
            TABLA.Load(leerfilas);
            leerfilas.Close();
            conexion.Close();
            return TABLA;
        }
        public void RETIRARMATERIAYGRUPO(int IDINSCRIPCION, int IDGRUPO, int IDAlumnoGrupo)
        {
            SqlCommand cmd = new SqlCommand("SP_RETIROMATERIAYGRUPO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDINSCRIPCION", IDINSCRIPCION);
            cmd.Parameters.AddWithValue("@IDGRUPO", IDGRUPO);
            cmd.Parameters.AddWithValue("@IDAlumnoGrupo", IDAlumnoGrupo);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public List<E_FACTURA> facturadatos(int idpago)
        {
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_FACTURA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDPAGO", idpago);
            leerfilas = cmd.ExecuteReader();
            List<E_FACTURA> LISTA = new List<E_FACTURA>();
            while (leerfilas.Read())
            {
                LISTA.Add(new E_FACTURA
                {
                    IDPago = leerfilas.GetInt32(0),
                    MES = leerfilas.GetString(1),
                    DetallePago = leerfilas.GetString(2),
                    Monto = leerfilas.GetDecimal(3),
                    MetodoPago = leerfilas.GetString(4),
                    FechaPago = leerfilas.GetDateTime(5),
                    FechaVencimiento = leerfilas.GetDateTime(6)
                });
            }
            conexion.Close();
            leerfilas.Close();
            return LISTA;
        }
    }
    
}