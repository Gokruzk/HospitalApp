using CData;
using Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogic {
    public class ClOperacionesConsultas {
        readonly ClDatos objDatos = new ClDatos();
        readonly ClOperacionesGenerales objMensajes = new ClOperacionesGenerales();

        public bool ValidarDescripcion(string descripcion) {
            if (string.IsNullOrWhiteSpace(descripcion)) {
                return false;
            }

            return true;
        }

        public string RegistrarConsulta(Consulta datos) {
            return objDatos.RegistroConsulta(datos);
        }

        public Consulta BuscarConsulta(string id) {
            return objDatos.SearchConsulta(id);
        }

        public string ActualizarConsulta(Consulta datos) {
            return objDatos.UpdateConsulta(datos);
        }

        public string ValidarTodoConsulta(Consulta datos, int i) {
            if (!ValidarDescripcion(datos.Descripcion))
                return objMensajes.errores[8];

            if (i == 1)
                return objDatos.RegistroConsulta(datos);
            else
                return objDatos.UpdateConsulta(datos);
        }
    }
}