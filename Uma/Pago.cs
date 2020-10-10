using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uma
{
    class Pago
    {
        double cantidad, cuota, Lab_Costo_Cont;
        string ID_Alumno;

        private void Procesar_Pago() { }
        private void Confirmacion_detalles() { }
    }

    class Grupo_Inscri
    {
        List<Materias> materias = new List<Materias>();
        double Lab_Costo_Cont;

        private void Verificar_Dispo_Inscrip() { }
        private void Inscribir() { }
        private void Verificar_Lab() { }
    }
}
