using CData;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogic
{
    public class ClOperacionesHorario
    {
        //Validación de datos entidad HORARIOS
        readonly ClDatos objDatos = new ClDatos();
        readonly ClOperacionesPersona objPersona = new ClOperacionesPersona();
        readonly ClOperacionesGenerales objMensajes = new ClOperacionesGenerales();

        public bool ValidarDia(string dia)
        {
            string[] diaSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Sábado", "Viernes", "Domingo" };

            return diaSemana.Contains(dia);
        }

        public bool ValidarHoras(DateTime horaI, DateTime horaF)
        {
            return DateTime.Compare(horaI, horaF) < 0;
        }

        public string ValidarTodoHorario(Horarios datos)
        {
            if (!objPersona.ValidarCedula(datos.CedulaMedico))
                return objMensajes.errores[0];

            if (!ValidarDia(datos.DiaSemana))
                return objMensajes.errores[12];

            if (!ValidarHoras(datos.HoraInicio, datos.HoraFin))
                return objMensajes.errores[13];

            return objMensajes.errores[15];
        }

        public string RegistrarHorario(Horarios datos) {
            string validacion = ValidarTodoHorario(datos);

            if (validacion == "CORRECTO")
                objDatos.RegistroHorario(datos);

            return validacion;
        }

        public string ActualizarHorario(Horarios datos) {
            string validacion = ValidarTodoHorario(datos);

            if (validacion == "CORRECTO")
                objDatos.UpdateHorario(datos);

            return validacion;
        }

        public string EliminarHorario(int id) {
            //Falta xd
            return "CORRECTO";
        }
    }
}
