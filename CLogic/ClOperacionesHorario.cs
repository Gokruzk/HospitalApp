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
        ClDatos objDatos = new ClDatos();
        ClOperacionesPersona objPersona = new ClOperacionesPersona();

        public bool ValidarDia(string dia)
        {
            string[] diaSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Sábado", "Viernes", "Domingo" };

            return diaSemana.Contains(dia);
        }

        public bool ValidarHoras(DateTime horaI, DateTime horaF)
        {
            return DateTime.Compare(horaI, horaF) < 0;
        }

        //Función de validación de datos Horario
        public int RegistrarHorario(Horarios datos)
        {
            int validaciones = 0;

            if (objPersona.ValidarCedula(datos.CedulaMedico))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarDia(datos.DiaSemana))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarHoras(datos.HoraInicio, datos.HoraFin))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (validaciones == 3)
            {
                objDatos.RegistroHorario(datos);
            }
            return 0;
        }

    }
}
