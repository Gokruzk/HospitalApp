using CData;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogic
{
    public class ClOperacionesEmpleado
    {
        //Validación de datos entidad EMPLEADO
        ClDatos objDatos = new ClDatos();
        ClOperacionesPersona objPersona = new ClOperacionesPersona();

        public bool ValidartipoEmpleado(string tipo)
        {
            if (string.IsNullOrWhiteSpace(tipo))
            {
                return false;
            }

            return true;
        }

        
        //Función de validación de datos EMPLEADO
        public int RegistrarEmpleado(Empleado datos)
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

            if (objPersona.ValidarDireccion(datos.Direccion))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidartipoEmpleado(datos.Tipo))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (validaciones == 9)
            {
                objDatos.RegistroEmpleado(datos);
            }
            else
            {
                return 0;
            }

            return 0;
        }
    }
}
