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
        /// <summary>
        /// Conversão de temperaturas
        /// </summary>
        /// <param name="conversao">Conversão a efetuar</param>
        /// <param name="temperatura">Temperatura a converter</param>
        /// <returns>Retorna o resultado da conversão.</returns>

        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }
        
        /// <summary>
        /// Tipo de conversão de distâncias.
        /// </summary>
        public enum ConversaoDistancia
        {
            Nulo = 0,
            MetrosMilhas,
            MilhasMetros
        }
                
        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
                return temperatura * 1.8 + 32;
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
                return (temperatura - 32) / 1.8;

            return -1;
        }

        /// <summary>
        /// Conversão de distâncias
        /// </summary>
        /// <param name="conversao">A conversão a efetuar;</param>
        /// <param name="distancia">Distância a converter.</param>
        /// <returns>O resultado da conversão da distância.</returns>
        public static double ConverterDistancias(ConversaoDistancia conversao, double distancia)
        {
            if (conversao == ConversaoDistancia.MetrosMilhas)
            {
                return distancia * 0.0006213712;
            }else if (conversao == ConversaoDistancia.MilhasMetros)
            {
                return distancia * 1609.344;
            }

            return -1;
        }

    }
}
