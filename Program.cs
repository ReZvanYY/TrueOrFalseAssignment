namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the first number, please!");
            var numberOne = Console.ReadLine();

            Console.WriteLine("Give me the second number, please!");
            var numberTwo = Console.ReadLine();

            bool isEqual = true;

            if (numberOne == numberTwo)
            {
                isEqual = true;
                Console.WriteLine("Equal numbers.");
            }
            else if (numberOne != numberTwo)
            {
                isEqual = false;
                Console.WriteLine("Unequal numbers.");
            }


        }
    }
}