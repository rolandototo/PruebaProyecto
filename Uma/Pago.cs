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
    public partial class Pago : Grupo_Inscri
    {
        public Pago()
        {
            InitializeComponent();
        }
        double cantidad, cuota, Lab_Costo_Cont;
        string ID_Alumno;

        private void Procesar_Pago() { }
        private void Confirmacion_detalles() { }
    }
    public class Grupo_Inscri : Materias_Inscrip
    {
        public List<String> Masterias;
        double Lab_Costo_Cont;

        private void Verificar_Dispo_Inscrip() { }
        private void Inscribir() { }
        private void Verificar_Lab() { }
    }
}
