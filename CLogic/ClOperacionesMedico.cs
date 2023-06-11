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
        readonly ClDatos objDatos = new ClDatos();
        readonly ClOperacionesPersona objPersona = new ClOperacionesPersona();
        readonly ClOperacionesGenerales objMensajes = new ClOperacionesGenerales();

        private bool ValidarTipoMedico(string tipo)
        {
            string[] tipoMedico = { "Médico Titular", "Médico Interino", "Médico Sustituto" };

            return tipoMedico.Contains(tipo);
        }

        private bool ValidarFechasSutituto(string tipo, DateTime fechaA, DateTime fechaB)
        {
            if (tipo == "Médico Sustituto")
                return DateTime.Compare(fechaA, fechaB) < 0;

            return true;
        }

        private bool ValidarNumColegiado(string numCol)
        {
            return numCol.Length == 9;
        }

        private string ValidarTodoMedico(Medico datos)
        {
            if (objPersona.ValidarCedula(datos.Cedula))
                return objMensajes.errores[0];

            if (objPersona.ValidarNombre(datos.Nombre))
                return objMensajes.errores[1];

            if (objPersona.ValidarNumeroSeguroSocial(datos.NumSegSocial))
                return objMensajes.errores[2];

            if (objPersona.ValidarDireccion(datos.Direccion))
                return objMensajes.errores[3];

            if (ValidarTipoMedico(datos.Tipo))
                return objMensajes.errores[9];

            if (ValidarFechasSutituto(datos.Tipo, datos.FechaA, datos.FechaB))
                return objMensajes.errores[13];

            if (ValidarNumColegiado(datos.NumColegiado))
                return objMensajes.errores[11];

            return objMensajes.errores[15];
        }

        public string RegistrarMedico(Medico datos)
        {
            string validacion = ValidarTodoMedico(datos);

            if (ValidarTodoMedico(datos) == "CORRECTO")
                objDatos.RegistroMedico(datos);

            return validacion;
        }

        public string ActualizarMedico(Medico datos)
        {
            string validacion = ValidarTodoMedico(datos);

            if (validacion == "CORRECTO")
                objDatos.UpdateMedico(datos);

            return validacion;
        }

        public string EliminarMedico(string cedula)
        {
            if (objPersona.ValidarCedula(cedula))
            {
                objDatos.DeleteMedico(cedula);
            }
            else
                return objMensajes.errores[0];

            return "CORRECTO";
        }
    }
}
