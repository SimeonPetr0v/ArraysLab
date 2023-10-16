namespace Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] num = Console.ReadLine()
             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();
            int[] round = new int[num.Length];
            for(int i = 0; i < num.Length; i++)
            {
                round[i] = (int)(Math.Round(num[i], MidpointRounding.AwayFromZero));
                Console.WriteLine($"{Convert.ToDecimal(num[i])} => {Convert.ToDecimal(round[i])} ");
            }
        }
    }
}