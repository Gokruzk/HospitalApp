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

        string[] errores = { "Cédula no valida.",
                             "Nombre invalido, recuerde que debe ingresar el nombre sin dígitos o caracteres especiales.",
                             "Número de seguro social invalido.",
                             "Error, por favor ingrese correctamente la dirección.",
                             "Número de teléfono invalido, recuerde que el número de teléfono tiene que contener la cantidad correcta de dígitos al igual que registrarlo sin el código de país.",
                             "La provincia ingresada no existe, por favor ingresar una de las 24 provincias del país.",
                             "Código postal invalido, recuerde que debe contener la cantidad correcta de dígitos.",
                             "Tipo de empleado inexistente.",
                             "Descripción requerida.",
                             "Tipo de medico inexistente.",
                             "El medico tiene que ser sustituto para registrar fecha de alta y baja.",
                             "Número de colegiado invalido, recuerde ingresar la cantidad correcta de dígitos.",
                             "Día de la semana inexistente.",
                             "El dato de finalización no puede ser mayor al de inicio.",
                             "Estado invalido, recuerde ingresar si el estado de las vacaciones es Planificada o Realizada."
        };

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
            if (nombre == "" || nombre.Any(char.IsDigit) || Regex.IsMatch(nombre, @"^[a-zA-Z\s]+$"))
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
            if (numeroSeguroSocial.Length != 11)
                return false;
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
            if (codigoPostal.Length != 5)
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
        private bool ValidarTipoMedico(string tipo)
        {
            string[] tipoMedico = { "Médico Titular", "Médico Interino", "Médico Sustituto" };

            return tipoMedico.Contains(tipo);
        }

        private bool ValidarFechasSutituto(string tipo, DateTime fechaA, DateTime fechaB)
        {
            if (tipo == "Sustituto")
                return DateTime.Compare(fechaA, fechaB) < 0;

            return true;
        }

        private bool ValidarNumColegiado(string numCol)
        {
            return numCol.Length == 9;
        }

        private int ValidarTodoMedico(Medico datos)
        {
            int validaciones = 0;

            if (ValidarCedula(datos.Cedula))
                validaciones++;
            else
                return 1;

            if (ValidarNombre(datos.Nombre))
                validaciones++;
            else
                return 2;

            if (ValidarNumeroSeguroSocial(datos.NumSegSocial))
                validaciones++;
            else
                return 3;

            if (ValidarDireccion(datos.Direccion))
                validaciones++;
            else
                return 4;

            if (ValidarTipoMedico(datos.Tipo))
                validaciones++;
            else
                return 5;

            if (ValidarFechasSutituto(datos.Tipo, datos.FechaA, datos.FechaB))
                validaciones++;
            else
                return 6;

            if (ValidarNumColegiado(datos.NumColegiado))
                validaciones++;
            else
                return 7;

            if (ValidarNombre(datos.Nombre))
                validaciones++;
            else
                return 8;

            if (ValidarNumeroSeguroSocial(datos.NumSegSocial))
                validaciones++;
            else
                return 9;

            if (ValidartipoEmpleado(datos.Tipo))
                validaciones++;
            else
                return 10;

            return validaciones;
        }

        //Función de validación de datos MEDICO
        public int RegistrarMedico(Medico datos)
        {
            if (ValidarTodoMedico(datos) == 10)
            {
                objDatos.RegistroMedico(datos);
            }
            else
                return 111;

            return -121;
        }

        public int ActualizarMedico(Medico datos)
        {
            if (ValidarTodoMedico(datos) == 10)
                objDatos.UpdateMedico(datos);
            else
                return 222;

            return -1290;
        }

        //Función de validación de datos PACIENTE
        public int RegistrarPaciente(Paciente datos)
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

            if (ValidarDireccion(datos.Direccion))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            return 0;
        }

        //Validación de datos entidad HORARIOS
        public bool ValidarDia(string dia)
        {
            string[] diaSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Sábado", "Viernes", "Domingo" };

            return diaSemana.Contains(dia);
        }

        public bool ValidarHoras(DateTime horaI, DateTime horaF)
        {
            return DateTime.Compare(horaI, horaF) < 0;
        }

        //Función de validación de datos Horario
        public int RegistrarHorario(Horarios datos)
        {
            int validaciones = 0;

            if (ValidarCedula(datos.CedulaMedico))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarDia(datos.DiaSemana))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarHoras(datos.HoraInicio, datos.HoraFin))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (validaciones == 3)
            {
                objDatos.RegistroHorario(datos);
            }
            return 0;
        }

        //Validación de datos entidad VACACIONES
        public bool ValidarEstado(string estado)
        {
            string[] estadosVa = { "Planificadas", "Realizadas" };

            return estadosVa.Contains(estado);
        }


        //Función de validación de datos Horario
        public int RegistrarVacacion(Vacaciones datos)
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

            if (ValidarEstado(datos.Estado))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }

            if (ValidarHoras(datos.FechaInicio, datos.FechaFin))
            {
                validaciones++;
            }
            else
            {
                return 0;
            }


            if (validaciones == 3)
            {
                //objDatos.RegistroHorario(datos);
            }
            return 0;
        }
    }
}