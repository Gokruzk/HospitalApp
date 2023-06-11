using CData;
using Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogic {
    public class ClOperacionesConsultas {
        readonly ClDatos objDatos = new ClDatos();
        readonly ClOperacionesPersona objPersona = new ClOperacionesPersona();
        readonly ClOperacionesGenerales objMensajes = new ClOperacionesGenerales();

        public bool ValidarDescripcion(string descripcion) {
            if (string.IsNullOrWhiteSpace(descripcion)) {
                return false;
            }

            return true;
        }

        private string ValidarTodoConsulta(Consulta datos) {
            if(ValidarDescripcion(datos.Descripcion))
                return objMensajes.errores[8];

            if (!objPersona.ValidarCedula(datos.Medico))
                return objMensajes.errores[0];

            if (!objPersona.ValidarCedula(datos.Paciente))
                return objMensajes.errores[0];

            return objMensajes.errores[15];
        }

        public string RegistrarConsulta(Consulta datos) {
            string validacion = ValidarTodoConsulta(datos);

            if (validacion == "CORRECTO") {
                objDatos.RegistroConsulta(datos);
            }

            return validacion;
        }

        public string ActualizarConsulta(Consulta datos) {
            string validacion = ValidarTodoConsulta(datos);

            if (validacion == "CORRECTO")
                objDatos.UpdateConsulta(datos);

            return validacion;
        }

        public Consulta BuscarConsultaPaciente(string cedula) {
            return objDatos.SearchConsultaPaciente(cedula);
        }

        public Consulta BuscarConsultaMedico(string cedula) {
            return objDatos.SearchConsultaMedico(cedula);
        }
    }
}