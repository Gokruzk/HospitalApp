using CData;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CLogic
{
    public class ClOperacionesEmpleado
    {
        readonly ClDatos objDatos = new ClDatos();
        readonly ClOperacionesPersona objPersona = new ClOperacionesPersona();
        readonly ClOperacionesGenerales objMensajes = new ClOperacionesGenerales();

        public bool ValidartipoEmpleado(int tipo)
        {
            int[] tipoEmpleado = { 1, 2, 3, 4, 5 };

            return tipoEmpleado.Contains(tipo);
        }

        public string ValidarTodoEmpleado(Empleado datos)
        {
            if (!objPersona.ValidarCedula(datos.Cedula))
                return objMensajes.errores[0];

            if (!objPersona.ValidarNombre(datos.Nombre))
                return objMensajes.errores[1];

            if (!objPersona.ValidarNumeroSeguroSocial(datos.NumSegSocial))
                return objMensajes.errores[2];

            if (!objPersona.ValidarDireccion(datos.Direccion))
                return objMensajes.errores[3];

            if (!ValidartipoEmpleado(datos.Tipo))
                return objMensajes.errores[7];

            return objMensajes.errores[15];
        }

        public string RegistrarEmpleado(Empleado datos)
        {
            string validacion = ValidarTodoEmpleado(datos);

            if (validacion == "CORRECTO")
            {
                string estado = objDatos.RegistroEmpleado(datos);

                if (estado == "2627")
                    return estado;
            }

            return validacion;
        }

        public string EliminarEmpleado(string cedula) {
            if (objPersona.ValidarCedula(cedula)) {
                objDatos.DeleteEmpleado(cedula);

            } else
                return objMensajes.errores[0];

            return "CORRECTO";
        }

        public string EliminarEmpleadoNumSocial(string numeroSeguroSocial) {
            if (objPersona.ValidarNumeroSeguroSocial(numeroSeguroSocial)) {
                objDatos.DeleteEmpleadoNS(numeroSeguroSocial);

            } else
                return objMensajes.errores[2];

            return "CORRECTO";
        }

        public string ActualizarEmpleado(Empleado datos)
        {
            string validacion = ValidarTodoEmpleado(datos);

            if (validacion == "CORRECTO")
                objDatos.UpdateEmpleado(datos);

            return validacion;
        }

        public Empleado BuscarEmpleado(string cedula) {
            return objDatos.SearchEmpleado(cedula);
        }

        public Empleado BuscarEmpleadoNumSocial(string numeroSeguroSocial) {
            return objDatos.SearchEmpleadoNS(numeroSeguroSocial);
        }
    }
}