﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    //* Implmenta operações aritméticas */
   
    internal static class Aritmetica
    {

        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }

        /// <summary>
        /// Operação Soma
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Retorna soma de dois números</returns>
        public static int Somar (int x, int y)
        {
            return x+y;
        }
    /// <summary>
    /// Operação de subtrair
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>Retorna o resultado da subtração de dois números </returns>

    public  static int Subtrair (int x, int y)
        {
            return x-y;
        }

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
