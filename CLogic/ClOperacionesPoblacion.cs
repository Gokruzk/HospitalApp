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
        List<Poblacion> objPoblaciones = new List<Poblacion>();

        public List<string> CargarPoblaciones()
        {
            objPoblaciones = objDatos.GetPoblaciones();
            List<string> tipos = new List<string>();

            foreach(Poblacion poblano in objPoblaciones)
                tipos.Add(poblano.Descripcion);

            return tipos;
        } 
    }
}
