using System;

namespace PrimeNumbers.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('*', 100));
            Console.Write("Input the max number to which all primes will be calculated to: ");
            
            var inputNumber = Console.ReadLine();
            int.TryParse(inputNumber, out var maxNumber);
            
            Console.WriteLine(new string('*', 100));
            Console.WriteLine("\n");
            Console.WriteLine("Finding all primes...");
            
            var calculator = new PrimeCalculator();
            var primes = calculator.FindPrimes(maxNumber);
            
            var outputString = string.Join(", ", primes);
            Console.WriteLine(outputString);
        }
    }
}