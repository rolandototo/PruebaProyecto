using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uma
{
    class Maestro
    {
        private string Id_maestro;
        private List<Grupos> Grupos = new List<Grupos>();

        static void Mostrar_Grupos()
        {

        }

        static void Edit_Conection()
        {

        }

        static void Crear()
        {

        }

        static void Destruir()
        {

        }

        static void Perfil()
        {

        }
    }

    class Grupos
    {
        private string id_grupo;
        private string nombre_grupo;
        private string id_maestro;
        private int max_grup;

        public string ID_Grupo
        {
            get { return id_grupo; }
            set { id_grupo = value; }
        }

        public string Nombre_Grupo
        {
            get { return nombre_grupo; }
            set { nombre_grupo = value; }
        }

        public string ID_Maestro
        {
            get { return id_maestro; }
            set { id_maestro = value; }
        }

        public int Max_Grup
        {
            get { return max_grup; }
            set { max_grup = value; }
        }

    }
}
