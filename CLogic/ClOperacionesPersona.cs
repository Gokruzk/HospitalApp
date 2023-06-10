using CData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CLogic
{
    public class ClOperacionesPersona
    {
        //Validación de datos entidad PERSONA
        ClDatos objDatos = new ClDatos();
        public bool ValidarCedula(string cedula)
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

        public bool ValidarNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre) || nombre.Any(char.IsDigit) || !Regex.IsMatch(nombre, @"^[a-zA-Z\s]+$"))
            {
                return false;
            }

            return true;
        }

        public bool ValidarNumeroSeguroSocial(string numeroSeguroSocial)
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
            { 
                return false; 
            }
            return true;
        }
        public bool ValidarDireccion(string dirrecion)
        {
            if (string.IsNullOrWhiteSpace(dirrecion) && (!Regex.IsMatch(dirrecion, @"^[a-zA-Z0-9\s-]+$")))
            {
                return false;
            }

            return true;
        }
    }
}
