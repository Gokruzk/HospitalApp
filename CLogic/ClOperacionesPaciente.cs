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
            if (!objPersona.ValidarCedula(datos.Cedula))
                return objMensajes.errores[0];


            if (!objPersona.ValidarNombre(datos.Nombre))
                return objMensajes.errores[1];


            if (!objPersona.ValidarNumeroSeguroSocial(datos.NumSegSocial))
                return objMensajes.errores[2];


            if (!objPersona.ValidarCedula(datos.Medico))
                return objMensajes.errores[0];


            if (!objPersona.ValidarDireccion(datos.Direccion))
                return objMensajes.errores[3];

            return objMensajes.errores[15];
        }
        public string RegistrarPaciente(Paciente datos)
        {
            string validacion = ValidarTodoPaciente(datos);

            if (ValidarTodoPaciente(datos) == "CORRECTO")
            {
                string estado = objDatos.RegistroPaciente(datos);
                if(estado == "2627")
                    return estado;
            }
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
            if (!objPersona.ValidarCedula(cedula))
            {
                objDatos.DeletePaciente(cedula);
            }
            else
                return objMensajes.errores[0];

            return "CORRECTO";
        }

        public Paciente CargarPacienteCedula(string cedula)
        {
            return objDatos.SearchPaciente(cedula);
        }

        public Paciente CargarPacienteNS(string numSeg)
        {
            return objDatos.SearchPacienteNS(numSeg);
        }
    }
}
