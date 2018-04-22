using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    /// <summary>
    /// Calculate the minimum number of coins that will be enough to make change 
    /// </summary>
    public class MinimumCoinChangeProblemSolver
    {
        /// <summary>
        /// Calculates the minimum number of coins that will be enough to make change 
        /// </summary>
        /// <param name="amount">amount of money to change</param>
        /// <param name="coins">collection of coins</param>
        /// <returns>Minimum number of coins to change the <param name="amount">amount</param> of money</returns>
        public static int GetMinNumberOfCoinsToChange(int amount, IEnumerable<int> coins)
        {
            var cache = new int[amount + 1];
            return GetMinNumberOfCoinsToChange(cache, amount, coins);
        }

        /// <summary>
        /// Set default result as the maximum value.
        /// For each coin in the collection of coins, we calculate the difference between total amount and subtracted coin.
        /// if the difference is more than 0 we repeat the operation until the difference will be reduced to 0;
        /// The crux of the method is to select such coins that require the minimum number of recursive operations.
        /// </summary>
        /// <param name="amount">amount of money to change</param>
        /// <param name="coins">collection of coins</param>
        /// <returns>Minimum number of coins to change the <param name="amount">amount</param> of money</returns>
        private static int GetMinNumberOfCoinsToChange(int[] cache, int amount, IEnumerable<int> coins)
        {
            if (cache[amount] != 0)
                return cache[amount];

            if (amount == 0)
                return 0;

            var result = Int32.MaxValue;
            foreach (var coin in coins)
            {
                var rest = amount - coin;
                if (rest >= 0)
                {
                    var curMin = GetMinNumberOfCoinsToChange(rest, coins);
                    result = Math.Min(curMin, result);
                }
            }            
            cache[amount] = result + 1;
            return cache[amount];
        }
    }
}
