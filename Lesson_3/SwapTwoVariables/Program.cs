namespace SwapTwoVariables
{
    internal class Program
    {
        // Поміняти місцями значення двох змінних? Чи можна це зробити без ще однієї тимчасової змінної.
        static void Main(string[] args)
        {
            // a = 10; b = 20 => a = 20; b = 10;

            // read num1 from Console
            // read num2 from Console
            
            int num1, num2;
            Console.Write("Enter num1: ");
            string? input1 = Console.ReadLine();
            Console.Write("Enter num2: ");
            string? input2 = Console.ReadLine();
            // 325 => "325"

            // Parse
            num1 = int.Parse(input1);
 
            // Convert
            num2 = Convert.ToInt32(input2);

            // 1 approach
            //int buffer = num1; // num1
            //num1 = num2; // num2
            //num2 = buffer; // num1

            // 2 approach
            num1 = num1 + num2; // 10 + 20 = 30
            num2 = num1 - num2; // 30 - 20 = 10
            num1 = num1 - num2; // 30 - 10 = 20 


            Console.WriteLine($"num1 = {num1}");
            Console.WriteLine($"num2 = {num2}");

            Console.ReadKey();
        }
    }
}