using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações de conversão
    /// </summary>
    internal static class Conversoes
    {
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }
        /// <summary>
        /// Conversão de temperaturas
        /// </summary>
        /// <param name="conversao">Conversão a efetuar</param>
        /// <param name="temperatura">Temperatura a converter</param>
        /// <returns>Retorna o resultado da conversão.</returns>
        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
                return temperatura * 1.8 + 32;
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
                return (temperatura - 32) / 1.8;

            return -1;
        }

    }
}
