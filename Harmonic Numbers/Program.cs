namespace Harmonic_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n; // n is number of terms
            double s = 0; // sum of series intialized with 0.

            Console.Write("\n\n");
            Console.WriteLine("Calculate the Harmonic Numbers:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");

            Console.WriteLine("Input the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");
            for (i = 1; i <= n; i++) //// it will print 1/i current value of the loop.
            {
                Console.Write("1/{0} + ", i);
                s += 1 / (float)i; // sum is calculated when converting i to s.
            }
            Console.WriteLine("\nSum of Series upto {0} terms : {1} \n", n, s);
        }
    }
}