namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicite casting
            int intNum = 300;
            byte byteNum = (byte)intNum;

            Console.WriteLine(byteNum);

            double doubleNum = 12345.67;
            int num = (int)doubleNum;

            Console.WriteLine(num);

            int a = 5;
            int b = 2;

            // 1 case
            float c = (float) a / b;
            Console.WriteLine(c);

            // 2 case
            float d = (float)a / (float)b;
            Console.WriteLine(d);

            // 3 case
            float e = 5 / 2f;
            Console.WriteLine(e);

            // 4 case
            double f = 5 / 2.0;
            Console.WriteLine(f);


            Console.ReadKey();
        }
    }
}