using CData;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogic
{
    public class ClOperacionesMedico
    {
        //Validacion de datos entidad MEDICO
        ClDatos objDatos = new ClDatos();
        ClOperacionesPersona objPersona = new ClOperacionesPersona();
        private bool ValidarTipoMedico(string tipo)
        {
            string[] tipoMedico = { "Médico Titular", "Médico Interino", "Médico Sustituto" };

            return tipoMedico.Contains(tipo);
        }

        private bool ValidarFechasSutituto(string tipo, DateTime fechaA, DateTime fechaB)
        {
            if (tipo == "Sustituto")
                return DateTime.Compare(fechaA, fechaB) < 0;

            return true;
        }

        private bool ValidarNumColegiado(string numCol)
        {
            return numCol.Length == 9;
        }

        private int ValidarTodoMedico(Medico datos)
        {
            int validaciones = 0;

            if (objPersona.ValidarCedula(datos.Cedula))
                validaciones++;
            else
                return 1;

            if (objPersona.ValidarNombre(datos.Nombre))
                validaciones++;
            else
                return 2;

            if (objPersona.ValidarNumeroSeguroSocial(datos.NumSegSocial))
                validaciones++;
            else
                return 3;

            if (objPersona.ValidarDireccion(datos.Direccion))
                validaciones++;
            else
                return 4;

            if (ValidarTipoMedico(datos.Tipo))
                validaciones++;
            else
                return 5;

            if (ValidarFechasSutituto(datos.Tipo, datos.FechaA, datos.FechaB))
                validaciones++;
            else
                return 6;

            if (ValidarNumColegiado(datos.NumColegiado))
                validaciones++;
            else
                return 7;

            if (objPersona.ValidarNombre(datos.Nombre))
                validaciones++;
            else
                return 8;

            if (objPersona.ValidarNumeroSeguroSocial(datos.NumSegSocial))
                validaciones++;
            else
                return 9;

            if (ValidarTipoMedico(datos.Tipo))
                validaciones++;
            else
                return 10;

            return validaciones;
        }

        //Función de validación de datos MEDICO
        public int RegistrarMedico(Medico datos)
        {
            if (ValidarTodoMedico(datos) == 10)
            {
                objDatos.RegistroMedico(datos);
            }
            else
                return 111;

            return -121;
        }

        public int ActualizarMedico(Medico datos)
        {
            if (ValidarTodoMedico(datos) == 10)
                objDatos.UpdateMedico(datos);
            else
                return 222;

            return -1290;
        }

    }
}
