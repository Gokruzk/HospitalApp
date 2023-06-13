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
        public string[] errores =
        {
            "Cédula no válida.", //0
            "Nombre inválido, recuerde que debe ingresar el nombre sin dígitos o caracteres especiales.", //1
            "Número de seguro social inválido.", //2
            "Error, por favor ingrese correctamente la dirección.", //3
            "Número de teléfono invalido, recuerde que el número de teléfono tiene que contener la cantidad correcta de dígitos al igual que registrarlo sin el código de país.", //4
            "La provincia ingresada no existe, por favor ingresar una de las 24 provincias del país.", //5
            "Estado inválido, recuerde ingresar si el estado de la persona es Habilitado o No habilitado", //6
            "Tipo de empleado inexistente.",//7
            "Descripción requerida.",//8
            "Tipo de medico inexistente.",//9
            "El medico tiene que ser sustituto para registrar fecha de alta y baja.", //10
            "Número de colegiado inválido, recuerde ingresar la cantidad correcta de dígitos.", //11
            "Día de la semana inexistente.", //12
            "El dato de finalización no puede ser mayor al de inicio.", //13
            "Estado inválido, recuerde ingresar si el estado de las vacaciones es Planificada o Realizada.", //14
            "CORRECTO", //15
            "La cédula digitada ya se encuentra en la base de datos", //16
            "El empleado no puede ser menor de edad", //17
            "La población ingresada es inválida", //18
            "No se puede ingresar 2 veces la misma cédula"//19
        };
    }
}