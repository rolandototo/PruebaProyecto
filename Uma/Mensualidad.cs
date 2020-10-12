using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Uma
{
    public partial class Mensualidad : Alumno
    {
        public Mensualidad()
        {
            InitializeComponent();
        }
        public static List<Mensualidad> ID_Mensualidades;

        public void Mostrar_Mensualidad()
        {

        }
        public override string Edit_Connection()
        {
            return "";
        }
    }
    public class Mensualidades
    {
        string ID_Mensualidades { get; set; }
        string Detalle_Mensualidad { get; set; }
        string Mes { get; set; }
        DateTime Fecha_Ven { get; set; }
        DateTime Fecha_Init { get; set; }

    }
    public abstract class Pago_Mensualidad
    {
        public static List<Mensualidad> ID_Mensualidades;

        void Mostrar_Mensaulidades()
        {

        }
        void Pagar()
        {

        }
        void Imprimir_Factura()
        {

        }
    }
}
