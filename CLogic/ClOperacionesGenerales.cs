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
    public class ClOperacionesGenerales
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
    }
}