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

        public List<string> CargarTiposEmpleado() {
            List<TipoEmpleado> objTipos = objDatos.GetTipoEmpleado();
            List<string> tipos = new List<string>();

            foreach (Tipo empleado in objTipos)
                tipos.Add(empleado.Descripcion);

            return tipos;
        }

        public string RegistrarEmpleado(Empleado datos)
        {
            return objDatos.RegistroEmpleado(datos);
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

        public void ActualizarEmpleado(Empleado datos)
        {
            objDatos.UpdateEmpleado(datos);
        }

        public Empleado BuscarEmpleado(string cedula) {
            return objDatos.SearchEmpleado(cedula);
        }

        public Empleado BuscarEmpleadoNumSocial(string numeroSeguroSocial) {
            return objDatos.SearchEmpleadoNS(numeroSeguroSocial);
        }
    }
}