using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeNumbers.App
{
    public class PrimeCalculator
    {
        public IEnumerable<int> FindPrimes(int maxNaturalNumber)
        {
            Console.WriteLine("Finding all primes...");
            
            if (maxNaturalNumber < PrimeConstants.FirstPrime)
            {
                return Enumerable.Empty<int>();
            }

            var enumerableCount = maxNaturalNumber - PrimeConstants.FirstPrime;
            var candidatePrimes = Enumerable.Range(PrimeConstants.FirstPrime, enumerableCount);
            var primes = candidatePrimes.Where(naturalNumber => naturalNumber.IsPrime());
            return primes;
        }
    }
}