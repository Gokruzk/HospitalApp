using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CData;

namespace CLogic
{
    public class ClOperacionesAdmin
    {
        ClDatos objDatos = new ClDatos();
        public bool VerificarUsuario(string id, string pass)
        {
            return objDatos.GetAdministrador(id, pass);
        }   
    }
}
