using System;

namespace PrimeNumbers.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(new string('*', 100));
            System.Console.Write("Input the max number to which all primes will be calculated to: ");
            var inputNumber = System.Console.ReadLine();
            int.TryParse(inputNumber, out var maxNumber);
            System.Console.WriteLine(new string('*', 100));
            System.Console.WriteLine("");
            System.Console.WriteLine("Finding all primes...");
            var calculator = new PrimeCalculator();
            var primes = calculator.FindPrimes(maxNumber);
            var outputString = string.Join(", ", primes);
            System.Console.WriteLine(outputString);
        }
    }
}