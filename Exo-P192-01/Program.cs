using System.Collections.Generic;

namespace Exo_P192_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("######################################");
            Console.WriteLine("Convertion C to F");
            Celsius celsius = new Celsius();
            celsius.temperature = 42;
            Console.WriteLine(celsius.converter());
            Console.WriteLine("######################################");
            Console.WriteLine("Convertion F to C");
            Fahrenheit fahrenheit = new Fahrenheit();
            fahrenheit.temperature = 107.6;
            Console.WriteLine(fahrenheit.converter());
        }


        public struct Celsius
        {
            public double temperature;
            public double converter()
            {
                //The formula to convert Celsius to Fahrenheit is given by: °F = °C × (9/5) + 32. By using this formula, we can convert any given temperature from Celsius to Fahrenheit (C to F)
                double res = (temperature * 9 / 5) + 32;
                return res;
            }
        }

        public struct Fahrenheit
        {
            public double temperature;
            public double converter()
            {
                //First, you need the formula for converting Fahrenheit (F) to Celsius(C): C = 5 / 9 x(F - 32)
                double res = (temperature - 32) * 5 / 9;
                return res;
            }
        }
    }
}