using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPAENTIDADES;
using CAPADATOS;
using System.Data;

namespace CAPANEGOCIO
{
    public class N_login
    {
        D_Login data = new D_Login();
        public DataTable mostrandoUsuarios(E_Login sender)
        {
            return data.d_usuarios(sender);
        }
    }
}
