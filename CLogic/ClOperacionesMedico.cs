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

        public string ValidarTodoMedico(Medico datos)
        {
            if (!objPersona.ValidarCedula(datos.Cedula))
                return objMensajes.errores[0];

            if (!objPersona.ValidarNombre(datos.Nombre))
                return objMensajes.errores[1];

            if (!objPersona.ValidarNumeroSeguroSocial(datos.NumSegSocial))
                return objMensajes.errores[2];

            if (!objPersona.ValidarDireccion(datos.Direccion))
                return objMensajes.errores[3];

            if (!ValidarTipoMedico(datos.Tipo))
                return objMensajes.errores[9];

            if (!ValidarFechasSutituto(datos.Tipo, datos.FechaA, datos.FechaB))
                return objMensajes.errores[13];

            if (!ValidarNumColegiado(datos.NumColegiado))
                return objMensajes.errores[11];

            return objMensajes.errores[15];
        }

        public string RegistrarMedico(Medico datos)
        {
            string validacion = ValidarTodoMedico(datos);

            if (ValidarTodoMedico(datos) == "CORRECTO")
            {
                string estado = objDatos.RegistroMedico(datos);

                if (estado == "2627")
                    return estado;
            }

            return validacion;
        }

        public string ActualizarMedico(Medico datos)
        {
            string validacion = ValidarTodoMedico(datos);

            if (validacion == "CORRECTO")
                objDatos.UpdateMedico(datos);

            return validacion;
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
