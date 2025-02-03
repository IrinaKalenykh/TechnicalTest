
namespace TechnicalTest.Problems
{
    public static class SingleNumberSearch
    {
        public static int? GetSingleNumberViaDictionary(int[] nums)
        {
            var numsDictionary = new Dictionary<int, int>
            {
                { nums[0], 0 }
            };

            for (var i = 1; i < nums.Length; i++)
            {
                if (numsDictionary.TryGetValue(nums[i], out _))
                    numsDictionary.Remove(nums[i]);
                else
                    numsDictionary.Add(nums[i], i);
            }

            return numsDictionary.Count == 0 || numsDictionary.Count > 1 ? null : 
                numsDictionary.Keys.ElementAt(0);
        }

        public static int GetSingleNumberViaXor(int[] nums)
        {
            var result = nums[0];
            var iterationsCount = (nums.Length - 1)/2;

            for (var i = 1; i <= iterationsCount; i++)
            {
                result ^= nums[i] ^ nums[^i];
            }

            return result;
        }
    }
}