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
        readonly ClOperacionesPoblacion objOperacionesPoblacion = new ClOperacionesPoblacion();

        public bool ValidarTipoMedico(int tipo)
        {
            int[] tipoMedico = { 1, 2, 3 };

            return tipoMedico.Contains(tipo);
        }

        public bool ValidarFechasSutituto(int tipo, DateTime fechaA, DateTime fechaB)
        {
            if (tipo == 3)
                return DateTime.Compare(fechaA, fechaB) < 0;
            Console.WriteLine(tipo + " 0000000");
            return true;
        }

        public bool ValidarNumColegiado(string numCol)
        {
            return numCol.Length == 9;
        }


        public string RegistrarMedico(Medico datos)
        {
            return ValidarTodoMedico(datos, 1);
        }

        public string ActualizarMedico(Medico datos)
        {
            return ValidarTodoMedico(datos, 2);

        }

        public List<string> CargarTiposMedicos()
        {
            List<TipoMedico> objTipos = objDatos.GetTipoMedico();
            List<string> tipos = new List<string>();

            foreach (Tipo medico in objTipos)
                tipos.Add(medico.Descripcion);

            return tipos;
        }

        public List<string> CargarNombresMedicos()
        {
            List<Medico> objNombresMedicos = objDatos.GetMedicos();
            List<string> nombres = new List<string>();

            foreach (Medico medico in objNombresMedicos)
                nombres.Add(medico.Nombre);

            return nombres;
        }

        public List<string> CargarCedulasMedicos()
        {
            List<Medico> objCedulasMedicos = objDatos.GetMedicos();
            List<string> cedulas = new List<string>();

            foreach (Medico medico in objCedulasMedicos)
                cedulas.Add(medico.Cedula);

            return cedulas;
        }

        public Medico CargarMedicoCedula(string cedula)
        {
            return objDatos.SearchMedico(cedula);
        }

        public Medico CargarMedicoNS(string numSeg)
        {
            Console.WriteLine("" + numSeg);
            return objDatos.SearchMedicoNS(numSeg);
        }

        public SqlDataAdapter CargarMedicosTipos()
        {
            return objDatos.GetMedicoTipos();
        }

        public SqlDataAdapter CargarMedicosVacaciones()
        {
            return objDatos.GetMedicoVacaciones();

        }

        public string ValidarTodoMedico(Medico datos, int i)
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
            if (datos.Tipo == 3)
            {
                if (!ValidarFechasSutituto(datos.Tipo, datos.FechaA, datos.FechaB))
                    return objMensajes.errores[13];
            }
            if (!ValidarNumColegiado(datos.NumColegiado))
                return objMensajes.errores[11];
            if (!objOperacionesPoblacion.ValidarPoblacion(datos.Poblacion))
                return objMensajes.errores[18];

            if (i == 1)
                return objDatos.RegistroMedico(datos);
            else
                return objDatos.UpdateMedico(datos);
        }
    }
}
