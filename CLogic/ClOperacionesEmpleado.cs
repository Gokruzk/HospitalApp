using CData;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        readonly ClOperacionesPoblacion objOperacionesPoblacion = new ClOperacionesPoblacion();

        public bool ValidarTipoEmpleado(int tipo)
        {
            int[] tipoEmpleado = { 1, 2, 3, 4, 5 };

            return tipoEmpleado.Contains(tipo);
        }

        public List<string> CargarTiposEmpleado()
        {
            List<TipoEmpleado> objTipos = objDatos.GetTipoEmpleado();
            List<string> tipos = new List<string>();

            foreach (Tipo empleado in objTipos)
                tipos.Add(empleado.Descripcion);

            return tipos;
        }

        public string RegistrarEmpleado(Empleado datos)
        {
            return ValidarTodoEmpleado(datos, 1);
        }

        public string EliminarEmpleado(string cedula)
        {
            if (objPersona.ValidarCedula(cedula))
            {
                objDatos.DeleteEmpleado(cedula);

            }
            else
                return objMensajes.errores[0];

            return "CORRECTO";
        }

        public string EliminarEmpleadoNumSocial(string numeroSeguroSocial)
        {
            if (objPersona.ValidarNumeroSeguroSocial(numeroSeguroSocial))
            {
                objDatos.DeleteEmpleadoNS(numeroSeguroSocial);

            }
            else
                return objMensajes.errores[2];

            return "CORRECTO";
        }

        public string ActualizarEmpleado(Empleado datos)
        {
            return ValidarTodoEmpleado(datos, 2);
        }

        public Empleado BuscarEmpleado(string cedula)
        {
            return objDatos.SearchEmpleado(cedula);
        }

        public Empleado BuscarEmpleadoNumSocial(string numeroSeguroSocial)
        {
            return objDatos.SearchEmpleadoNS(numeroSeguroSocial);
        }

        public SqlDataAdapter CargarEmpleadosTipos()
        {
            return objDatos.GetEmpleadoTipos();
        }

        public SqlDataAdapter CargarEmpleadosVacaciones()
        {
            return objDatos.GetEmpleadoVacaciones();
        }

        public string ValidarTodoEmpleado(Empleado datos, int i)
        {
            if (!objPersona.ValidarCedula(datos.Cedula))
                return objMensajes.errores[0];

            if (!objPersona.ValidarNombre(datos.Nombre))
                return objMensajes.errores[1];

            if (!objPersona.ValidarDireccion(datos.Direccion))
                return objMensajes.errores[3];

            if (!objOperacionesPoblacion.ValidarPoblacion(datos.Poblacion))
                return objMensajes.errores[11];

            if (!objOperacionesPoblacion.ValidarPoblacion(datos.Poblacion))
                return objMensajes.errores[7];

            if (!objPersona.ValidarNumeroSeguroSocial(datos.NumSegSocial))
                return objMensajes.errores[2];

            if (i == 1)
            {
                return objDatos.RegistroEmpleado(datos);
            }
            else
            {
                return objDatos.UpdateEmpleado(datos);
            }
        }
    }
}