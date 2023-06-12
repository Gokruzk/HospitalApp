using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CData;
using Entidades;

namespace CLogic
{
    public class ClOperacionesPoblacion
    {
        readonly ClDatos objDatos = new ClDatos();

        public bool ValidarPoblacion(int poblacion)
        {
            int[] tipoMedico = { 1, 2, 3, 4, 5, 6 };

            return tipoMedico.Contains(poblacion);
        }

        public List<string> CargarPoblaciones()
        {
            List<Poblacion> objPoblaciones = objDatos.GetPoblaciones();
            List<string> tipos = new List<string>();

            foreach (Poblacion poblano in objPoblaciones)
                tipos.Add(poblano.Descripcion);

            return tipos;
        }

        public string CargarPoblacion(int id)
        {
            Poblacion objPoblacion = objDatos.SearchPoblacion(id);

            return objPoblacion.Descripcion;
        }
    }
}
