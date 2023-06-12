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
        readonly ClOperacionesPersona objPersona = new ClOperacionesPersona();
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

        public void ActualizarConsulta(Consulta datos) {
            objDatos.UpdateConsulta(datos);
        }
    }
}