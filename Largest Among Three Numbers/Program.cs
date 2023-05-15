namespace Largest_Among_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number1, Number2, Number3;

            Console.WriteLine("Enter the first number: ");
            Number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            Number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            Number3 = int.Parse(Console.ReadLine());

            if (Number1 > Number2 && Number1 > Number3)
            {
                Console.WriteLine("The largest number is: " + Number1);
            }
            else if (Number2 > Number1 && Number2 > Number3)
            {
                Console.WriteLine("The largest number is: " + Number2);
            }
            else
            {
                Console.WriteLine("The largest number is: " + Number3);
            }

            Console.ReadKey();
        }
    }
}