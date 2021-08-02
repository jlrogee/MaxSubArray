using System.Linq;

namespace MaxSubArray
{
    public class MaxSubArray
    {
        public static int[] GetMaxSubArray(int[] array)
        {
            int[] max = {array[0]};
            int[] currMax = {array[0]};

            for (var i = 1; i < array.Length; i++)
            {
                currMax = GetMax(new[] {array[i]}, currMax.Concat(new[] {array[i]}).ToArray());
                if (currMax.Sum() > max.Sum())
                    max = currMax;
            }

            return max;
        }

        private static int[] GetMax(int[] first, int[] second)
        {
            return first.Sum() > second.Sum() ? first : second;
        }
    }
}