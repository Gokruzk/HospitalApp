using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CLogic
{
    public class ClOperaciones
    {
        /* public class Medico : Persona
        {
            public string Tipo { get; set; }
            public string FechaA { get; set; }
            public string FechaB { get; set; }
            public string NumColegiado { get; set; }
            public int Poblacion { get; set; }
        } */
        public int RegistrarMedico(Medico medicoN)
            
        {
            string tipo = medicoN.Tipo.ToUpper();
            int validaciones = 0;

            if (tipo != "TITULAR" && tipo != "INTERINO" & tipo != "SUSTITUTO")
                return 0;
            else
                validaciones++;

            if (tipo == "SUSTITUTO")
            {
                if (medicoN.FechaA.Length > 0 && medicoN.FechaB.Length > 0)
                {
                    validaciones++;
                }
                else
                    return 0;
            }
            else
                validaciones++;

            if (medicoN.NumColegiado.Length > 0)
                validaciones++;
            else
                return 0;

            if(medicoN.)


            return 0;
        }
    }
}
