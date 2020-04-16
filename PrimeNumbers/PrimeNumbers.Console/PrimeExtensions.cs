using System.Linq;

namespace PrimeNumbers.Console
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
            var investigatedNumbers = Enumerable.Range(PrimeConstants.FirstPrime, enumerableCount);
            return investigatedNumbers.All(investigatedNumber => naturalNumber % investigatedNumber != 0);
        }
    }
}