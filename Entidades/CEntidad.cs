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
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string NumSegSocial { get; set; }
        public int ID { get; set; }
        public int Direccion { get; set; }
    }

    public class Empleado : Persona
    {
        public string Tipo { get; set; }
        public int Poblacion { get; set; }
    }

    public class Medico : Persona
    {
        public string Tipo { get; set; }
        public string FechaA { get; set; }
        public string FechaB { get; set; }
        public string NumColegiado { get; set; }
        public int Poblacion { get; set; }
    }

    public class Paciente : Persona
    {
        public int Medico { get; set; }
    }
}
