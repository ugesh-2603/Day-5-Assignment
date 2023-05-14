namespace Day_5_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of times to flip the coin:");
            int n = Convert.ToInt32(Console.ReadLine());

            int heads = 0, tails = 0;

            Random Flip = new Random();
            for (int i = 0; i < n; i++)
            {
                if (Flip.NextDouble() < 0.5)
                {
                    tails++;
                }
                else
                {
                    heads++;
                }
            }

            double headsPercentage = ((double)heads / n) * 100;
            double tailsPercentage = ((double)tails / n) * 100;

            Console.WriteLine("Heads: " + headsPercentage.ToString("0.00") + "%");
            Console.WriteLine("Tails: " + tailsPercentage.ToString("0.00") + "%");
        }
    }
}