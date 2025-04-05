using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    //* Implmenta operações aritméticas */
   
    internal static class Aritmetica
    {

       

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

        /// <summary>
        /// Operação de multiplicação
        /// </summary>
        /// <returns>Retorna o resultado da multiplicação.</returns>
      public static int Multiplicar(int x, int y)
        {
            return x * y;
        }

    }
}
