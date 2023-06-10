using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CData;
using Entidades;

namespace CLogic
{
    public class ClOperaciones
    {
        ClDatos objDatos = new ClDatos();

        //Validación de datos entidad PERSONA
        private bool ValidarCedula(string cedula)
        {
            if (cedula.Length != 10 || !int.TryParse(cedula, out int n))
            {
                return false;
            }

            int sum = 0;

            for (int i = 0; i < 9; i++)
            {
                int digit = int.Parse(cedula[i].ToString());
                int coef = (i % 2 == 0) ? 2 : 1;
                int product = digit * coef;
                sum += (product >= 10) ? (product - 9) : product;
            }

            int lastDigit = int.Parse(cedula[9].ToString());
            int calculatedDigit = (sum % 10 == 0) ? 0 : (10 - (sum % 10));

            if (lastDigit == calculatedDigit)
                return true;

            else
            {
                return false;
            }
        }

        private bool ValidarNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre) || nombre.Any(char.IsDigit) || Regex.IsMatch(nombre, @"[^\w]"))
            {
                return false;
            }

            return true;
        }

        private bool ValidarNumeroSeguroSocial(string numeroSeguroSocial)
        {
            if ((numeroSeguroSocial.Length != 9) || (!numeroSeguroSocial.All(char.IsDigit)))
            {
                return false;
            }

            if (!Regex.IsMatch(numeroSeguroSocial, @"^\d{9}$") && !Regex.IsMatch(numeroSeguroSocial, @"^\d{3}-\d{2}-\d{4}$"))
            {
                return false;
            }

            int suma = 0;

            for (int i = 0; i < 9; i++)
            {
                int digito = int.Parse(numeroSeguroSocial[i].ToString());
                if (i % 2 == 0)
                {
                    digito *= 2;
                    if (digito > 9)
                    {
                        digito = digito % 10 + digito / 10;
                    }
                }
                suma += digito;
            }
            int digitoVerificador = (10 - (suma % 10)) % 10;

            int ultimoDigito = int.Parse(numeroSeguroSocial[8].ToString());

            if (digitoVerificador != ultimoDigito)
            {
                return false;
            }
            return true;
        }

        //Validación de datos entidad EMPLEADO
        public bool ValidartipoEmpleado(string tipo)
        {
            if (string.IsNullOrWhiteSpace(tipo))
            {
                return false;
            }

            return true;
        }

        //Validación de datos entidad POBLACIÓN
        public bool ValidarDescripcionPoblacion(string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                return false;
            }

            return true;
        }

        //Validación de datos entidad DIRECCIONES
        public bool ValidarDireccion(string dirrecion)
        {
            if (string.IsNullOrWhiteSpace(dirrecion) && (!Regex.IsMatch(dirrecion, @"^[a-zA-Z0-9\s-]+$")))
            {
                return false;
            }

            return true;
        }

        public bool ValidarTelefono(string telefono)
        {
            if (string.IsNullOrWhiteSpace(telefono) || !telefono.Any(char.IsDigit) || telefono.Length != 10)
            {
                return false;
            }

            return true;
        }

        public bool ValidarProvincia(string provincia)
        {
            string[] provinciasEcuador = { "Azuay", "Bolívar", "Cañar", "Carchi", "Chimborazo", "Cotopaxi", "El Oro",
                                   "Esmeraldas", "Galápagos", "Guayas", "Imbabura", "Loja", "Los Ríos", "Manabí",
                                   "Morona Santiago", "Napo", "Orellana", "Pastaza", "Pichincha", "Santa Elena",
                                   "Santo Domingo de los Tsáchilas", "Sucumbíos", "Tungurahua", "Zamora Chinchipe" };

            return provinciasEcuador.Contains(provincia);
        }

        public static bool ValidarCodigoPostal(string codigoPostal)
        {
            string patron = @"^\d{2}\d{3}$";

            if (Regex.IsMatch(codigoPostal, patron))
            {
                return false;
            }

            return true;
        }

        //Función de validación de datos EMPLEADO
        public int RegistrarEmpleado(Empleado datos, Direcciones direcciones, Poblacion poblacion)
        {
            int validaciones = 0;

            if (ValidarCedula(datos.Cedula))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarNombre(datos.Nombre))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarNumeroSeguroSocial(datos.NumSegSocial))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarDireccion(direcciones.Direccion))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarTelefono(direcciones.Telefono))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarProvincia(direcciones.Provincia))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarCodigoPostal(direcciones.CodigoPostal))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidartipoEmpleado(datos.Tipo))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarDescripcionPoblacion(poblacion.Descripcion))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (validaciones == 9)
            {
                objDatos.RegistroEmpleado(datos);
                objDatos.RegistroDireccion(direcciones);
                objDatos.RegistroPoblacion(poblacion);
            }
            else
            {
                return 0;
            }

            return 0;
        }

        //Validacion de datos entidad MEDICO
        public bool ValidarTipoMedico(string tipo)
        {
            string[] tipoMedico = { "Titular", "Interino", "Sustituto" };

            return tipoMedico.Contains(tipo);
        }

        public bool ValidarFechasSutituto(string tipo, string fechaA, string fechaB)
        {
            if (tipo == "Sustituto")
                return fechaA.Length > 0 && fechaB.Length > 0;

            return true; ;
        }

        public bool ValidarNumColegiado(string numCol)
        {
            return numCol.Length == 9;
        }
        //Función de validación de datos MEDICO
        public int RegistrarMedico(Medico datos, Direcciones direcciones, Poblacion poblacion)
        {
            int validaciones = 0;

            if (ValidarCedula(datos.Cedula))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarNombre(datos.Nombre))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarNumeroSeguroSocial(datos.NumSegSocial))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarDireccion(direcciones.Direccion))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }
            if (ValidarTelefono(direcciones.Telefono))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarProvincia(direcciones.Provincia))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarCodigoPostal(direcciones.CodigoPostal))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarTipoMedico(datos.Tipo))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarFechasSutituto(datos.Tipo, datos.FechaA, datos.FechaB))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarNumColegiado(datos.NumColegiado))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarNombre(datos.Nombre))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarNumeroSeguroSocial(datos.NumSegSocial))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarDireccion(direcciones.Direccion))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarTelefono(direcciones.Telefono))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarProvincia(direcciones.Provincia))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarCodigoPostal(direcciones.CodigoPostal))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidartipoEmpleado(datos.Tipo))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarDescripcionPoblacion(poblacion.Descripcion))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (validaciones == 18)
            {
                objDatos.RegistroMedico(datos);
                objDatos.RegistroDireccion(direcciones);
                objDatos.RegistroPoblacion(poblacion);
            }
            else
            {
                return 0;
            }

            return 0;
        }

        //Función de validación de datos PACIENTE
        public int RegistrarPaciente(Paciente datos, Direcciones direcciones)
        {
            int validaciones = 0;

            if (ValidarCedula(datos.Cedula))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarNombre(datos.Nombre))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarNumeroSeguroSocial(datos.NumSegSocial))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarCedula(datos.Medico))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarDireccion(direcciones.Direccion))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarTelefono(direcciones.Telefono))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarProvincia(direcciones.Provincia))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarCodigoPostal(direcciones.CodigoPostal))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (validaciones == 8)
            {
                objDatos.RegistroPaciente(datos);
                objDatos.RegistroDireccion(direcciones);
            }
            else
            {
                return 0;
            }

            return 0;
        }

    }
}