using Test;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            Console.WriteLine(rect.CalculateArea());
            rect.Width = double.Parse(Console.ReadLine());
            rect.Height = double.Parse(Console.ReadLine());
            Console.WriteLine(rect.CalculateArea());

        }
    }
}