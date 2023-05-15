namespace Compute_Quotient_and_Remainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
          //declare and initialize character variable

           int a = 8, b = 2;
           int q, r;

          //find the quotient

           q = a / b;

          //find the remainder

           r = a % b;

          // display result

           Console.WriteLine("When " + a + " is divided by " + b + ", quotient is " + q + " and remainder is " + r + ".");

          // wait for user to press any key

           Console.ReadKey();
            
        }
    }
}
    
