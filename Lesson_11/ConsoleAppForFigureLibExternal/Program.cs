using ClassLibraryFigure;

namespace ConsoleAppForFigureLibExternal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 2, "A");
            Point p2 = new Point(2, 3, "B");
            Point p3 = new Point(3, 5, "C");
            Point p4 = new Point(4, 7, "D");
            Point p5 = new Point(7, 11, "E");

            Figure figure1 = new Figure(p1, p2, p3, "Figure with 3 points");
            Figure figure2 = new Figure(p1, p2, p3, p4, "Figure with 4 points");
            Figure figure3 = new Figure(p1, p2, p3, p4, p5, "Figure with 5 points");

            Console.WriteLine($"{figure1.Name} - perimeter = {figure1.PerimeterCalculator()}");
            Console.WriteLine($"{figure2.Name} - perimeter = {figure2.PerimeterCalculator()}");
            Console.WriteLine($"{figure3.Name} - perimeter = {figure3.PerimeterCalculator()}");

            // обчислюємо модуль числа -10
            int a = Math.Abs(-10);
            // int countVowels = UkrainianStringUtils.CountVowels(input);
            // string allVowels = "яєо...";
            // string input = "воаліарліра";
            // allVowels.Contains(char); - true/false
        }
    }
}