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
    public class ClOperacionesMedico
    {
        //Validacion de datos entidad MEDICO
        readonly ClDatos objDatos = new ClDatos();
        readonly ClOperacionesPersona objPersona = new ClOperacionesPersona();
        readonly ClOperacionesGenerales objMensajes = new ClOperacionesGenerales();

        public bool ValidarTipoMedico(int tipo)
        {
            int[] tipoMedico = { 1, 2, 3 };

            return tipoMedico.Contains(tipo);
        }

        public bool ValidarFechasSutituto(int tipo, DateTime fechaA, DateTime fechaB)
        {
            if (tipo == 3)
                return DateTime.Compare(fechaA, fechaB) < 0;

            return true;
        }

        public bool ValidarNumColegiado(string numCol)
        {
            return numCol.Length == 9;
        }


        public string RegistrarMedico(Medico datos)
        {
            return objDatos.RegistroMedico(datos);
        }

        public string ActualizarMedico(Medico datos)
        {
            return "CORRECTO"; //objDatos.UpdateMedico(datos);

        }

        public string EliminarMedico(string cedula)
        {
            if (objPersona.ValidarCedula(cedula))
            {
                objDatos.DeleteMedico(cedula);
            }
            else
                return objMensajes.errores[0];

            return "CORRECTO";
        }

        /* public List<string> CargarTiposMedicos()
        {
            List<> objMedicos = objDatos.GetPoblaciones();
            List<string> tipos = new List<string>();

            foreach(Poblacion poblano in objPoblaciones)
                tipos.Add(poblano.Descripcion);

            return tipos;
        }  */
        public Medico CargarMedicoCedula(string cedula)
        {
            return objDatos.SearchMedico(cedula);
        }

        public Medico CargarMedicoNS(string numSeg)
        {
            return objDatos.SearchMedicoNS(numSeg);
        }
    }
}
