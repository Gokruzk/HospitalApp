using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogic
{
    public class ClOperacionesVacacion
    {
        //Validación de datos entidad VACACIONES
        public bool ValidarEstado(string estado)
        {
            string[] estadosVa = { "Planificadas", "Realizadas" };

            return estadosVa.Contains(estado);
        }

    }
}
