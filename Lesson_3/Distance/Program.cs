namespace Distance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distance;
            Console.Write("Enter distance in cm: ");
            // distance = Convert.ToInt32(Console.ReadLine());
            distance = int.Parse(Console.ReadLine());

            Console.WriteLine($"Distance in m: {distance/100}");
        }
    }
}