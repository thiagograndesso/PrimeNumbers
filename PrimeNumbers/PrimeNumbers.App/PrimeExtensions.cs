using System.Linq;

namespace PrimeNumbers.App
{
    public static class PrimeExtensions
    {
        public static bool IsPrime(this int naturalNumber)
        {
            if (naturalNumber < PrimeConstants.FirstPrime)
            {
                return false;
            }

            var enumerableCount = naturalNumber - PrimeConstants.FirstPrime;
            var candidateFactors = Enumerable.Range(PrimeConstants.FirstPrime, enumerableCount);
            return candidateFactors.All(candidateFactor => naturalNumber % candidateFactor != 0);
        }
    }
}