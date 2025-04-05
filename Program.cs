using System;


namespace Calculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicação Cálculos");

            Console.WriteLine($"4 + 2 = {Aritmetica.Somar(4,2)}");
            Console.WriteLine($"4 - 2 = {Aritmetica.Subtrair(4, 2)}");

            double t1 = Conversoes.ConverterTemperatura(Conversoes.ConversaoTemperatura.CelsiusFahrenheit, 36);
            double t2 = Conversoes.ConverterTemperatura(Conversoes.ConversaoTemperatura.CelsiusFahrenheit, 100);

            Console.WriteLine($"36 º Celsius = {t1}º Fareinheit");
            Console.WriteLine($"100 º Fareinheit = {t2}º Celsius");

            Console.ReadKey();
        }
    }
}
