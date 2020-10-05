using Logic;
using System;

namespace Host
{
    class Program
    {
        public static void Main(string[] args)
        {
            Engine engine = new Engine();

            // Pas de vérification de nombre valide
            string roman = "MCMIV";
            Console.WriteLine($"'{roman}' = {engine.ComputeRomanToDecimal(roman)}");
            Console.ReadLine();
        }
    }
}
