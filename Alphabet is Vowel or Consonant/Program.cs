namespace Alphabet_is_Vowel_or_Consonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an alphabet:");
            char i = Convert.ToChar(Console.ReadLine().ToLower()); // convert to lowercase 

            if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u')
            {
                Console.WriteLine("The alphabet is a vowel.");
            }
            else
            {
                Console.WriteLine("The alphabet is a consonant.");
            }

            Console.ReadLine(); // pause at the end of the program
        }
    }
}