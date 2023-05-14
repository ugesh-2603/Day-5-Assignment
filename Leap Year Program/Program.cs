namespace Leap_Year_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Please enter a year : ");
            int Leapyear = Convert.ToInt32(Console.ReadLine());

            if (Leapyear < 1000 || Leapyear > 9999)
            {
                Console.WriteLine("Invalid year. Please enter a 4-digit year.");
            }
            else if ((Leapyear % 4 == 0 && Leapyear % 100 != 0) || Leapyear % 400 == 0)
            {
                Console.WriteLine("{0} is a leap year.", Leapyear);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year.", Leapyear);
            }

            Console.ReadLine();
        }
    }
}