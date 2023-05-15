namespace Prime_Factorization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("Please Enter the Number:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Factors:");
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}