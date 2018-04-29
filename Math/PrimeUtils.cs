using System;

namespace MathUtils
{
    public static class PrimeUtils
    {
        /// <summary>
        /// Check whether the integer isPrime 
        /// </summary>
        /// <returns></returns>
        public static bool IsPrime(this int n)
        {
            if (n < 2)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;

            var upperLimit = Math.Sqrt(n);
            for (var i = 3; i <= upperLimit; i += 2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
