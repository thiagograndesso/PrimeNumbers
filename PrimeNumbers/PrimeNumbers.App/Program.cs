using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeNumbers.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrintHeaderTitle();
            var inputFromConsole = ReadInputFromConsole();
            var maxNumber = ParseToNumber(inputFromConsole);

            var calculator = new PrimeCalculator();
            var primes = calculator.FindPrimes(maxNumber).ToList();
            
            PrintResults(primes);
        }

        private static void PrintResults(IList<int> primes)
        {
            if (primes.Any())
            {
                var outputString = string.Join(", ", primes);
                Console.WriteLine(outputString);
                return;
            }
            
            Console.WriteLine($"Could not find any primes");
        }

        private static string ReadInputFromConsole()
        {
            Console.Write("Max number: ");
            return Console.ReadLine();
        }

        private static void PrintHeaderTitle()
        {
            Console.WriteLine(new string('*', 100));
            Console.WriteLine("Primes Calculator");
            Console.WriteLine(new string('*', 100));
        }

        private static int ParseToNumber(string value)
        {
            int.TryParse(value, out var number);
            return number;
        }
    }
}