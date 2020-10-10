using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uma
{
    class Nota
    {
        private List<Notas> Grupos = new List<Notas>();

        static void Agregar_Nota()
        {

        }

        static void Lista_Notas()
        {

        }

        static void Editar_Nota()
        {

        }

        static void Detalle_Nota()
        {

        }

        static void Edit_Conection()
        {

        }
    }

    class Notas
    {
        private string id_notas;
        private string detalle_nota;
        private string carnet;
        private double nota;
        private int ciclo;
        private int año;

        public string ID_Notas
        {
            get { return id_notas; }
            set { id_notas = value; }
        }

        public string Detalle_Nota
        {
            get { return detalle_nota; }
            set { detalle_nota = value; }
        }

        public string Carnet
        {
            get { return carnet; }
            set { carnet = value; }
        }

        public double Nota
        {
            get { return nota; }
            set { nota = value; }
        }

        public int Ciclo
        {
            get { return ciclo; }
            set { ciclo = value; }
        }

        public int Año
        {
            get { return año; }
            set { año = value; }
        }
    }
}
