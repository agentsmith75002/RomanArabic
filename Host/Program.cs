using Logic;
using System;
using System.Diagnostics;
using System.Linq;

namespace Host
{
    class Program
    {
        public static void Main(string[] args)
        {
            if( args == null || args.Length != 1)
            {
                Console.WriteLine("You must provide one roman number");
                if (Debugger.IsAttached) Debugger.Break();
                Environment.Exit(1);
            }

            Engine engine = new Engine();
            if(!args[0].ToArray().All(c=>engine.Evaluate(c) != -1))
            {
                Console.WriteLine("You must provide a valid roman number");
                if (Debugger.IsAttached) Debugger.Break();
                Environment.Exit(2);
            }

            string roman = args[0];
            Console.WriteLine($"'{roman}' = {engine.ComputeRomanToDecimal(roman)}");

            if(Debugger.IsAttached) Debugger.Break();
        }
    }
}
