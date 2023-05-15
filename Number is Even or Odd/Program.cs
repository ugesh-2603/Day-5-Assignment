namespace Number_is_Even_or_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number1, Remainder1;
            Console.Write("\n\n");
            Console.WriteLine("Check whether a number is even or odd :\n");
            Console.WriteLine("---------------------------------------");
            Console.Write("\n\n");
            Console.WriteLine("Input an integer : ");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Remainder1 = Number1 % 2;
            if (Remainder1 == 0)
                Console.WriteLine("{0} is an even integer.\n", Number1);
            else
                Console.WriteLine("{0} is an odd integer.\n", Number1);
        }
    }
}