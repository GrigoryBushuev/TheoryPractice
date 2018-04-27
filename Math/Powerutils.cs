using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    public static class PowerUtils
    {
        /// <summary>
        /// The function takes as input integers P and Q and returns P to
        /// the power of Q. Note any assumptions you make and the complexity of the
        /// algorithm. We expect you to do better than O(Q).
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public static int PowerOfQ(int p, uint q)
        {
            if (q == 0)
                return 1;

            var result = PowerOfQ(p, q >> 1);
            var product = result * result;
            return (q % 2 == 0) ? product : p * product;
        }


    }
}
