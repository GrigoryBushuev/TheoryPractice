namespace BitwiseOperations
{
    public static class BitwiseUtils
    {
        /// <summary>
        /// Swap two numbers without using a temporary variable
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void Swap(ref int a, ref int b)
        {
            b = a ^ b;
            a = a ^ b;
            b = a ^ b;
        }
    }
}
