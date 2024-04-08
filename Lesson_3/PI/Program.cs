namespace PI
{
    internal class Program
    {
        // Вивести на екран число π різними способами.

        static void Main(string[] args)
        {
            // l = 2 pi * R
            //const double PI = Math.PI;

            double PI = Math.Acos(-1); 
            Console.WriteLine(PI);
        }
    }
}