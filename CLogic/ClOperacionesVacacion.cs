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

        //Validación de datos entidad VACACIONES
        private bool ValidarEstadoVacacion(int estado)
        {
            int[] estadosVa = { 1, 2 };

            return estadosVa.Contains(estado);
        }

        private bool ValidarFechas(DateTime fechaI, DateTime fechaF)
        {
            return DateTime.Compare(fechaI, fechaF) < 0;
        }


        private string ValidarTodoVacacion(Vacaciones datos)
        {
            if (ValidarEstadoVacacion(datos.Estado))
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
                objDatos.RegistroVacacion(datos);

                /* if (estado == "CORRECTO")
                    return estado; */
            }

            return validacion;
        }

        public Vacaciones CargarVacacionesCedula(string cedula)
        {
            return objDatos.SearchVacacionCedula(cedula);
        }

        public Vacaciones CargarVacacionesEstado(int estado)
        {
            return objDatos.SearchVacacionEstado(estado);
        }

    }
}
