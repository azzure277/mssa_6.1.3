namespace mssa_6._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 0, 3, 12 };
            MoveZeroes(nums);

            Console.WriteLine(string.Join(",", nums)); // Output: 1,3,12,0,0
        }

        static void MoveZeroes(int[] nums)
        {
            int insertPos = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[insertPos++] = nums[i];
                }
            }
            while (insertPos < nums.Length)
            {
                nums[insertPos++] = 0;
            }
        }
    }
}
