namespace Number
{
    internal class Program
    {
        static int Parse(string input)
        {
            //int result = int.Parse(input);
            //return result;

            return int.Parse(input);
        }

        static void Main(string[] args)
        {
            //int x = 5, y = 5;
            //if (x == y)
            //{
            //    return;
            //}

            Console.Write("Enter number: ");
            int number = Parse(Console.ReadLine());
            int number2 = Parse("56");

            int digit1 = number / 10;
            int digit2 = number % 10;
            int sum = digit1 + digit2;
            int mult = digit1 * digit2;

            Console.WriteLine($"Digit1 = {digit1}");
            Console.WriteLine($"Digit2 = {digit2}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Mult = {mult}");
        }


    }
}