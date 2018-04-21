using System;

namespace ArraysAndStrings
{
    public static class Factorial
    {
        public static long GetFactorial(int n)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException(nameof(n));

            long Fact(int val)
            {
                if (val == 0)
                    return 1;
                return val * Fact(val - 1);
            }

            return Fact(n);
        }

        public static long GetFactorialOf(int n)
        {
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
