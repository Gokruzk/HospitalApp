using CData;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogic
{
    public class ClOperacionesPaciente
    {
        //Función de validación de datos PACIENTE
        ClDatos objDatos = new ClDatos();
        ClOperacionesPersona objPersona = new ClOperacionesPersona();

        public int RegistrarPaciente(Paciente datos)
        {
            int validaciones = 0;

            if (objPersona.ValidarCedula(datos.Cedula))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (objPersona.ValidarNombre(datos.Nombre))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (objPersona.ValidarNumeroSeguroSocial(datos.NumSegSocial))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (objPersona.ValidarCedula(datos.Medico))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (objPersona.ValidarDireccion(datos.Direccion))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            return 0;
        }
    }
}
