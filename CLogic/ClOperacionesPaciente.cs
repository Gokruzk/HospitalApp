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
        readonly ClDatos objDatos = new ClDatos();
        readonly ClOperacionesPersona objPersona = new ClOperacionesPersona();
        readonly ClOperacionesGenerales objMensajes = new ClOperacionesGenerales();

        private string ValidarTodoPaciente(Paciente datos)
        {
            if (objPersona.ValidarCedula(datos.Cedula))
            {; }
            else
            {
                return objMensajes.errores[0];
            }

            if (objPersona.ValidarNombre(datos.Nombre))
            {; }
            else
            {
                return objMensajes.errores[1];
            }

            if (objPersona.ValidarNumeroSeguroSocial(datos.NumSegSocial))
            {; }
            else
            {
                return objMensajes.errores[2];
            }

            if (objPersona.ValidarCedula(datos.Medico))
            {; }
            else
            {
                return objMensajes.errores[0];
            }

            if (objPersona.ValidarDireccion(datos.Direccion))
            {; }
            else
            {
                return objMensajes.errores[3];
            }

            return objMensajes.errores[15];
        }
        public string RegistrarPaciente(Paciente datos)
        {
            string validacion = ValidarTodoPaciente(datos);

            if (ValidarTodoPaciente(datos) == "CORRECTO")
                objDatos.RegistroPaciente(datos);

            return validacion;
        }

        public string ActualizarPaciente(Paciente datos)
        {
            string validacion = ValidarTodoPaciente(datos);

            if (validacion == "CORRECTO")
                objDatos.UpdatePaciente(datos);

            return validacion;
        }

        public string EliminarPaciente(string cedula)
        {
            if (objPersona.ValidarCedula(cedula))
            {
                objDatos.DeletePaciente(cedula);
            }
            else
                return objMensajes.errores[0];
            
            return "CORRECTO";
        }
    }
}
