using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CData;
using System.Collections.Specialized;

namespace CLogic
{
    public class ClOperacionesVacacion
    {
        readonly ClOperacionesGenerales objMensajes = new ClOperacionesGenerales();
        readonly ClOperacionesPersona objPersona = new ClOperacionesPersona();
        readonly ClDatos objDatos = new ClDatos();
        readonly ClOperacionesEstadoVacacion objEstado = new ClOperacionesEstadoVacacion();

        //Validación de datos entidad VACACIONES
        private bool ValidarEstado(string estado)
        {
            string[] estadosVa = { "Planificada", "Realizada" };

            return estadosVa.Contains(estado);
        }

        private bool ValidarFechas(DateTime fechaI, DateTime fechaF)
        {
            return DateTime.Compare(fechaI, fechaF) < 0;
        }


        private string ValidarTodoVacacion(Vacaciones datos)
        {
            if (objEstado.ValidarEstado(datos.Estado))
                return objMensajes.errores[14];

            if (!objPersona.ValidarCedula(datos.Cedula))
                return objMensajes.errores[0];

            if (ValidarFechas(datos.FechaInicio, datos.FechaFin))
                return objMensajes.errores[13];

            return objMensajes.errores[15];
        }

        public string RegistrarVacacion(Vacaciones datos)
        {
            string validacion = ValidarTodoVacacion(datos);

            if (ValidarTodoVacacion(datos) == "CORRECTO")
            {
                string estado = "";//objDatos.RegistroVacacion();

                if(estado == "CORRECTO")
                    return estado; 
            }

            return validacion;
        }
    }
}
