using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    using System;

    public class Persona
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string NumSegSocial { get; set; }
        public string Direccion { get; set; }
    }

    public class Empleado : Persona
    {
        public string Tipo { get; set; }
        public int Poblacion { get; set; }
    }

    public class Medico : Persona
    {
        public string Tipo { get; set; }
        public DateTime FechaA { get; set; }
        public DateTime FechaB { get; set; }
        public string NumColegiado { get; set; }
        public int Poblacion { get; set; }
    }

    public class Paciente : Persona
    {
        public string Medico { get; set; }
    }

    public class Poblacion
    {
        public int PID { get; set; }
        public string Descripcion { get; set; }
    }

    public class Horarios
    {
        public int HorID { get; set; }
        public string CedulaMedico { get; set; }
        public string DiaSemana { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
    }

    public class Vacaciones
    {
        public int VID { get; set; }
        public string Cedula { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
    }
}
