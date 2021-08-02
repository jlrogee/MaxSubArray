using System;

namespace MaxSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new[] {10, -3, -12, 8, 42, 1, -7, 0, 3};
            var result = MaxSubArray.GetMaxSubArray(array);

            Console.WriteLine("[{0}]", string.Join(", ", result));
        }
    }
}