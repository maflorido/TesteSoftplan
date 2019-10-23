using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi2.Extensions
{
    public static class DoubleExtensions
    {
        public static double Truncate(this double value, int casasDecimais)
        {
            decimal valor = Convert.ToDecimal(value);
            decimal fator = (decimal)Math.Pow(10d, casasDecimais);
            decimal valorTruncado = Math.Floor(valor * fator);
            return Convert.ToDouble(Math.Floor((Math.Round(valorTruncado, casasDecimais))) / fator);
        }
    }
}
