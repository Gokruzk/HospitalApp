using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    using System;

    //Estado = [ Habilitado, No habilitado ]
    public class Persona
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string NumSegSocial { get; set; }
        public string Direccion { get; set; }
        public int Estado { get; set; }
        public int Tipo { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }

    //TipoEmpleado = [ Administrativo, Celador, Auxiliar de Enfermería, ATS de Zona, ATS ]
    public class Empleado : Persona
    {
        public int Poblacion { get; set; }
    }

    //TipoMedico = [ Titular, Interino, Sustituto ]
    public class Medico : Persona
    {
        public DateTime FechaA { get; set; }
        public DateTime FechaB { get; set; }
        public string NumColegiado { get; set; }
        public int Poblacion { get; set; }
    }

    public class Paciente : Persona
    {
        public string Medico { get; set; }
    }

    //Poblacion = [ Mestiza, Montubia, Afroecutoriana, Blanca, Indígena, Otra ]
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
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
    }

    //Estado = [ Realizada, Planificada ]
    public class Vacaciones
    {
        public int VID { get; set; }
        public string Cedula { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int Estado { get; set; }
    }

    public class Consulta
    {
        public int CID { get; set; }
        public string Descripcion { get; set; }
        public string Medico { get; set; }
        public string Paciente { get; set; }
        public DateTime Fecha { get; set; }
    }
}
