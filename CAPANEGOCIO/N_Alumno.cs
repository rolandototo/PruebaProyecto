using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPADATOS;
using CAPAENTIDADES;
namespace CAPANEGOCIO
{
    public class N_Alumno
    {
        D_Alumno data = new D_Alumno();
        public List<E_Alumno> obtenerAlumno(string carne)
        {
            return data.listarDatosAlumnos(carne);
        }
        public void ACTUALIZARDATOSALUM(E_Alumno sender)
        {
            data.ACTUALIZARDATOSALUMNO(sender);
        }
        public List<E_Ciclo> listandociclos(DateTime fecha)
        {
            return data.LISTARCICLOSPORFECHAINS(fecha);
        }
        public List<E_Ciclo> CICLOPEFCHARETIRO(DateTime FECHA)
        { return data.LISTARCICLOSPORFECHARETIRO(FECHA); }

        public List<E_Materia> LISTANDOMATERIAS(int IDCARRERA)
        {
            return data.LISTANDOMATERIAS(IDCARRERA);
        }
        public DataTable listandogrupos(int idmateria,int idciclo)
        {
            return data.LISTARGRUPOS(idmateria,idciclo);
        }
        public DataTable listandoHorarios(int idgrupo)
        {
            return data.listarhorarios(idgrupo);
        }
        public DataTable ESTUDIANTESACTUALMENTEINSCRITOSAUNGRUPO(int IDGRUPO)
        {
            return data.REGISTROESTUDIANTESINSCRITOS(IDGRUPO);
        }
        public List<E_CARRERACUOTA>cuotaynombrecarrera(string carne)
        {
            return data.cuotaycarrera(carne);
        }
        public void CREARINSCRIPCION(E_Inscripcion sender)
        {
            data.NUEVAINSCRIPCION(sender);
        }
        public List<E_verINSCRIPCION> VERINSCRIPCION(string CARNE,DateTime FECHAINSCR)
        {
            return data.listarlainscripcion(CARNE, FECHAINSCR);
        }
        public void GRUPOINSCRITO(E_DETALLE_GRUPO_ALUMNO SENDER)
        {
            data.CREAR_DETALLE_GRUPO_ALUMNO(SENDER);
        }
        public DataTable VERGRUPOSINSCRIPTOS(int IDINSCRIPCION)
        {
            return data.VERGRUPOSINSCRITOS(IDINSCRIPCION);
        }
        public void DELETEGRUPOINSCRITO(int IDINSCRIPCION,int idgrupo,String CARNE,int IDALUMNOGRUPO)
        {
            data.ELIMINARGRUPOINSCRITO(IDINSCRIPCION,idgrupo,CARNE,IDALUMNOGRUPO);
        }
        public DataTable GROUPALREADYINSCRIPTED(String CARNE, int IDCICLO)
        {
            return data.GRUPOYAINSCRITO(CARNE,IDCICLO);
        }
        public List<E_Ciclo> LISTARTODOSLOSCICLOS(string BUSCAR)
        {
            return data.LISTADETODOSLOSCICLOS(BUSCAR);
        }
        public List<E_MATERIASINSCRITAS> materiasINSCRITASS(string carne)
        {
            return data.materiasINSCRITAS(carne);
        }
        public DataTable REGISTROSDEMATERIAS(string CARNE)
        {
            return data.REGISTROSDEMATERIAS(CARNE);
        }
        public DataTable OBTENERMESID(string MES)
        {
            return data.IDMENSUALIDADES(MES);
        }
        public void CREARPAGOSS(E_PAGO SENDER)
        {
            data.CREARPAGO(SENDER);
        }
        public List<E_NOTAS>VERNOTAS(string CARNE,int IDMATERIA)
        {
            return data.LISTARNOTAS(CARNE, IDMATERIA);
        }
        public DataTable VERMATERIASARETIRAR(String CARNE,int IDCICLOS)
        {
            return data.MOSTRARMATERIAARETIRAR(CARNE,IDCICLOS);
        }
        public void RETIRARMATERIAYGRUPO(int IDINSCRIPCION,int IDGRUPO, int IDALUMNOGRUPO)
        {
            data.RETIRARMATERIAYGRUPO(IDINSCRIPCION, IDGRUPO, IDALUMNOGRUPO);
        }
        public DataTable IDALUMNO_GRUPOID(string CARNE, int IDGRUPO)
        {
            return data.ALUMNO_GRUPOID(CARNE, IDGRUPO);
        }
        public DataTable IDGRUPO_NOTAS(int IDGRUPO)
        {
            return data.GRUPO_NOTAS(IDGRUPO);
        }
        public void crearnuevasnotasporgrupo(int IDAlumnoGrupo, int IDNotas, Double NOTA)
        {
            data.CREARNOTASPORGRUPO(IDAlumnoGrupo, IDNotas, NOTA);
        }
        public DataTable VERPAGOSRESTANTES(string CARNE)
        {
            return data.VERPAGOS(CARNE);
        }
        public void REALIZARPAGO(E_PAGO SENDER)
        {
            data.PAGAR(SENDER);
        }
        public void PAGOCONMORA(E_PAGO SENDER)
        {
            data.PAGOCONMORA(SENDER);
        }
        public List<E_FACTURA> DatosFactura(int idpago)
        {
            return data.facturadatos(idpago);
        }
    }
}
