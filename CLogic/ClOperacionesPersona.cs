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

        public bool ValidarEstado(int estado)
        {
            int[] tipo = { 1, 2 };

            return tipo.Contains(estado);
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
            if (!Regex.IsMatch(numeroSeguroSocial, "^(?!666|000|9\\d{2})\\d{3}-(?!00)\\d{2}-(?!0{4})\\d{4}$")) {
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
