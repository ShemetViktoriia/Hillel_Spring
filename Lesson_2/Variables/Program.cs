namespace Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Alex";


            int age = 0;
            //Console.WriteLine(age);
            age = 17;

            //Console.WriteLine($"Name = {firstName}, age = {age}");

            string message = String.Format("Name = {0}, age = {1}", firstName, age);
            Console.WriteLine(message);

            const int count = 100;
            age = count;

            char symbol = '$';
            Console.WriteLine(symbol);

            System.Boolean isPositive = false;



            Console.WriteLine("fkjshdkfjsh\t\t\tdlkfjsdlkfjsdlkf sfdsfsdfdsfdfdsf dfdfdfdfdf dfdf\nldjlfjd");
            Console.ReadKey();
        }
    }
}