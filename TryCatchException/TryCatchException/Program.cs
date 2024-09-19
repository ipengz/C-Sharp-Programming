namespace TryCatchException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age: ");
            GetUserAge(Console.ReadLine());
            
            Console.ReadKey();

        }

        static int GetUserAge(string input)
        {
            int age;

            if (!int.TryParse(input, out age))
            {
                throw new Exception("Please enter a valid age");
            }
            if (age < 0 || age >= 120)
            {
                throw new Exception("Please enter age between 0 and 119");
            }
            return age;
        }


    }
}
