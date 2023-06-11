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


        public string RegistrarPaciente(Paciente datos)
        {
            return objDatos.RegistroPaciente(datos);
        }

        public void ActualizarPaciente(Paciente datos)
        {

            objDatos.UpdatePaciente(datos);
        }
        /* 
                public string EliminarPaciente(string cedula)
                {
                    if (!objPersona.ValidarCedula(cedula))
                    {
                        objDatos.DeletePaciente(cedula);
                    }
                    else
                        return objMensajes.errores[0];

                    return "CORRECTO";
                } */

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
