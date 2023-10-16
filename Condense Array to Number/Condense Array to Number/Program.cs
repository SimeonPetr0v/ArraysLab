namespace Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int count = nums.Length;
            while (count > 1)
            {
                int[] cond = new int[nums.Length - 1];
                for(int i = 0; i < cond.Length; i++)
                {
                    cond[1] = nums[i] + nums[i + 1];
                }
                nums =cond;
                count--;
            }
            Console.WriteLine(nums[0]);
        }
    }
}