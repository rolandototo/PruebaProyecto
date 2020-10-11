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
    public partial class Mensualidades : Form
    {
        public static List<Mensualidad> MensualidadesL = new List<Mensualidad>();

        public Mensualidades()
        {
            InitializeComponent();

        }

        public void Mostrar_Mensualidad()
        {

        }

        public void Edit_Conection()
        {

        }
    }

    public abstract class Pago_Mensualidad
    {
        private string id_pago;

        public string ID_pago { get => id_pago; set => id_pago = value; }

        public void Mostrar_Pagos()
        {

        }

        public void Pagar()
        {

        }

        public void Factura()
        {

        }
    }

    public class Mensualidad : Pago_Mensualidad
    {
        private string id;
        private string detalle;
        private string mes;
        private DateTime fecha_ven;
        private DateTime fecha_Init;

        public string ID { get => id; set { id = value; ID_pago = value; } }
        public string Detalle { get => detalle; set => detalle = value; }
        public string Mes { get => mes; set => mes = value; }
        public DateTime Fecha_ven { get => fecha_ven; set => fecha_ven = value; }
        public DateTime Fecha_Init { get => fecha_Init; set => fecha_Init = value; }
    }
}
