namespace Power_of_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number, power;
            int result;
            Console.WriteLine("\n\n Recursion : Calculate power of any number :\n");
            Console.WriteLine("------------------------------------------------\n");

            Console.WriteLine(" Input the base  value : ");
            Number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Input the exponent : ");
            power = Convert.ToInt32(Console.ReadLine());

            result = CalOfPower(Number, power);//called the function CalOfPower

            Console.WriteLine(" The value of {0} to the power of {1} is : {2} \n\n", Number, power, result);
        }

        public static int CalOfPower(int x, int y)
        {
            if (y == 0)
                return 1;
            else
                return x * CalOfPower(x, y - 1);
        }
    }
    
}