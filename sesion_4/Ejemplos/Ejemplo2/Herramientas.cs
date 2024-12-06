using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    static class Herramientas
    {
        public static int estado = 1;
        private static readonly string[] Unidades = { "", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
        private static readonly string[] Decenas = { "", "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };
        private static readonly string[] DiezY = { "diez", "once", "doce", "trece", "catorce", "quince", "dieciséis", "diecisiete", "dieciocho", "diecinueve" };
        private static readonly string[] Centenas = { "", "ciento", "doscientos", "trescientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos" };

        public enum EstadoEstudiante{ 
            Inscrito =1,
            Inactivo = 2,
            Cerrado = 3,
            Archivado = 4,
        }

        public static string Convertir(double numero)
        {
            if (numero == 0)
                return "cero";

            if (numero < 0)
                return "menos " + Convertir(Math.Abs(numero));

            StringBuilder resultado = new StringBuilder();

            long entero = (long)numero;
            int decimales = (int)Math.Round((numero - entero) * 100);

            resultado.Append(ConvertirEntero(entero));

            if (decimales > 0)
            {
                resultado.Append(" con ");
                resultado.Append(ConvertirEntero(decimales));
                resultado.Append(" centavos");
            }

            return resultado.ToString().Trim();
        }

        public static string ConvertirEntero(long numero)
        {
            if (numero == 0)
                return "";

            if (numero >= 1_000_000_000)
                return ConvertirEntero(numero / 1_000_000_000) + " mil millones " + ConvertirEntero(numero % 1_000_000_000);

            if (numero >= 1_000_000)
                return ConvertirEntero(numero / 1_000_000) + " millones " + ConvertirEntero(numero % 1_000_000);

            if (numero >= 1_000)
                return ConvertirEntero(numero / 1_000) + " mil " + ConvertirEntero(numero % 1_000);

            if (numero >= 100)
                return Centenas[numero / 100] + " " + ConvertirEntero(numero % 100);

            if (numero >= 20)
                return Decenas[numero / 10] + (numero % 10 > 0 ? " y " + Unidades[numero % 10] : "");

            if (numero >= 10)
                return DiezY[numero - 10];

            return Unidades[numero];
        }


    }
}
