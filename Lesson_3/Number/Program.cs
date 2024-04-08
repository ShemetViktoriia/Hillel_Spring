namespace Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

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