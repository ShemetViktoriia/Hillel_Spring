namespace EnumColors
{
    enum Colors
    {
        Red, Green, Blue, Pink, Yellow
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Colors[] col = {Colors.Red, Colors.Blue };

            var colors = (Colors[])Enum.GetValues(typeof(Colors));
            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}