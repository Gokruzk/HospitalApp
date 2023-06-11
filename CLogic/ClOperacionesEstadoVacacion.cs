using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogic
{
    public class ClOperacionesEstadoVacacion
    {
        public bool ValidarEstado(int estado)
        {
            if (estado == 1 ||  estado == 2)
                return true;

            return false;
        }
    }
}
