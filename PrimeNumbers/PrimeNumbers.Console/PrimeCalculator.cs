using System.Collections.Generic;
using System.Linq;

namespace PrimeNumbers.Console
{
    public class PrimeCalculator
    {
        public IEnumerable<int> FindPrimes(int maxNaturalNumber)
        {
            if (maxNaturalNumber < PrimeConstants.FirstPrime)
            {
                return Enumerable.Empty<int>();
            }

            var enumerableCount = maxNaturalNumber - PrimeConstants.FirstPrime;
            var naturalNumbers = Enumerable.Range(PrimeConstants.FirstPrime, enumerableCount);
            var primes = naturalNumbers.Where(naturalNumber => naturalNumber.IsPrime());
            return primes;
        }
    }
}