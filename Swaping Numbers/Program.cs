namespace Swaping_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number1, Number2, Swaping_Numbers; // Inputs variables;
            Console.WriteLine("\nInput the First Number : ");
            Number1 = int.Parse(Console.ReadLine());  // parse converting string to integer;
            Console.WriteLine("\nInput the Second Number : ");
            Number2 = int.Parse(Console.ReadLine());
            Swaping_Numbers = Number1;
            Number1 = Number2;
            Number2 = Swaping_Numbers;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + Number1);
            Console.Write("\nSecond Number : " + Number2);
            Console.Read();
        }
    }
}