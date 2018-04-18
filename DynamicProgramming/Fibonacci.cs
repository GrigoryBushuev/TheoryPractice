using System.Collections.Generic;

namespace DynamicProgramming
{
    public static class Fibonacci
    {
        public static int GetNth(int n)
        {
            if (n < 2)
                return 1;
            var a = 1;
            var b = 1;
            var c = 2;

            for (var i = 2; i < n; i++) {
                a = b;
                b = c;
                c = a + b;
            }
            return c;
        }

        public static IEnumerable<int> GetFibonacciSequence(int n)
        {
            yield return 1;
            if (n == 0)
                yield break;
                     
            var a = 1;
            var b = 1;
            var c = 2;

            yield return 1;
            if (n == 1)
                yield break;

            yield return c;

            for (var i = 2; i < n; i++)
            {
                a = b;
                b = c;
                c = a + b;
                yield return c;
            }
        }

    }
}
