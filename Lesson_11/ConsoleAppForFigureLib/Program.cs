using MyFigureLib;

namespace ConsoleAppForFigureLib
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

            Console.WriteLine(figure1);
            Console.WriteLine(figure2);
            Console.WriteLine(figure3);
        }
    }
}