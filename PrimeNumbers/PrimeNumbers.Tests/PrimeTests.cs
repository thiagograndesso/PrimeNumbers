using System.Linq;
using PrimeNumbers.Console;
using Xunit;

namespace PrimeNumbers.Tests
{
    public class PrimeTests
    {
        /*
         * 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97,
         * 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, etc.
         */

        [Theory]
        [InlineData(5, new[] { 2, 3 })]
        [InlineData(20, new[] { 2, 3, 5, 7, 11, 13, 17, 19 })]
        [InlineData(50, new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47 })]
        [InlineData(70, new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67 })]
        [InlineData(100, new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 })]
        public void FindPrimes_WhenMaxNumberIsEqualOrGreaterThanFirstPrime_ReturnsPrimeNumbers(int maxNaturalNumber, int[] expectedResult)
        {
            var calculator = new PrimeCalculator();
            var primes = calculator.FindPrimes(maxNaturalNumber);
                
            Assert.Equal(primes, expectedResult);
        }
        
        [Theory]
        [InlineData(1)]
        [InlineData(0)]
        [InlineData(-10)]
        public void FindPrimes_WhenMaxNumberIsLessThanFirstPrime_ReturnsEmptyList(int lessThanFirstPrimeNumber)
        {
            var calculator = new PrimeCalculator();
            var primes = calculator.FindPrimes(lessThanFirstPrimeNumber);
                
            Assert.Equal(primes, Enumerable.Empty<int>());
        }
    }
}