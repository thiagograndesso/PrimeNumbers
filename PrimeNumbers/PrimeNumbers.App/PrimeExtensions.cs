using System.Collections.Generic;
using System.Linq;

namespace PrimeNumbers.App
{
    public static class PrimeExtensions
    {
        public static bool IsPrime(this int naturalNumber)
        {
            var primeFactors = new List<int>();
            for (int candidateFactor = 2; naturalNumber > 1; candidateFactor++)
            {
                while (naturalNumber % candidateFactor == 0)
                {
                    primeFactors.Add(candidateFactor);
                    naturalNumber /= candidateFactor;
                }
            }
            return primeFactors.Count() == 1;
        }
    }
}