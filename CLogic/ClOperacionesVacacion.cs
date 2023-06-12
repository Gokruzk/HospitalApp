using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CData;
using System.Collections.Specialized;

namespace CLogic
{
    public class ClOperacionesVacacion
    {
        readonly ClOperacionesGenerales objMensajes = new ClOperacionesGenerales();
        readonly ClOperacionesPersona objPersona = new ClOperacionesPersona();
        readonly ClDatos objDatos = new ClDatos();

        //Validación de datos entidad VACACIONES
        public bool ValidarEstadoVacacion(int estado)
        {
            int[] estadosVa = { 1, 2 };

            return estadosVa.Contains(estado);
        }

        public bool ValidarFechas(DateTime fechaI, DateTime fechaF)
        {
            return DateTime.Compare(fechaI, fechaF) < 0;
        }

        public List<Vacaciones> CargarVacacionesCedula(string cedula)
        {
            List<Vacaciones> vacas = objDatos.GetVacaciones();
            List<Vacaciones> vacasCedula = new List<Vacaciones>();

            foreach(Vacaciones vaca in vacas )
            {
                if(vaca.Cedula == cedula)
                    vacasCedula.Add(vaca);
            }

            return vacasCedula;
        }

        public string RegistrarVacacion(Vacaciones datos)
        {
            return objDatos.RegistroVacacion(datos);
        }

        public void ActualizarVacacion(Vacaciones datos)
        {
            objDatos.UpdateVacacion(datos);
        }

        public Vacaciones CargarVacacionCedula(string cedula)
        {
            return objDatos.SearchVacacionCedula(cedula);
        }

        public Vacaciones CargarVacacionCedulaId(string cedula, int id)
        {
            return objDatos.SearchVacacion(id, cedula);
        }

    }
}
