using CData;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public List<string> CargarNombresPacientes()
        {
            List<Paciente> objNombresPacientes = objDatos.GetPacientes();
            List<string> nombres = new List<string>();

            foreach (Paciente paciente in objNombresPacientes)
                nombres.Add(paciente.Nombre);

            return nombres;
        }

        public string RegistrarPaciente(Paciente datos)
        {
            return ValidarTodoPaciente(datos, 1);
        }

        public string ActualizarPaciente(Paciente datos)
        {

            return ValidarTodoPaciente(datos, 2);
        }
        public SqlDataAdapter CargarPacientesAD()
        {
            return objDatos.GetPacientesAD();
        }

        public Paciente CargarPacienteCedula(string cedula)
        {
            return objDatos.SearchPaciente(cedula);
        }

        public Paciente CargarPacienteNS(string numSeg)
        {
            return objDatos.SearchPacienteNS(numSeg);
        }

        public List<string> CargarCedulasPacientes()
        {
            List<Paciente> objCedulasPacientes = objDatos.GetPacientes();
            List<string> cedulas = new List<string>();

            foreach (Paciente paciente in objCedulasPacientes)
                cedulas.Add(paciente.Cedula);

            return cedulas;
        }

        public string ValidarTodoPaciente(Paciente datos, int i)
        {
            if (!objPersona.ValidarCedula(datos.Cedula))
                return objMensajes.errores[0];
            if (!objPersona.ValidarNombre(datos.Nombre))
                return objMensajes.errores[1];
            if (!objPersona.ValidarNumeroSeguroSocial(datos.NumSegSocial))
                return objMensajes.errores[2];
            if (!objPersona.ValidarDireccion(datos.Direccion))
                return objMensajes.errores[3];

            if(i == 1)
                return objDatos.RegistroPaciente(datos);
            else
                return objDatos.UpdatePaciente(datos);
        }
    }
}
