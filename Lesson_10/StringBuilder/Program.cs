using System.Text;

namespace StringBuilderTask
{
    internal class Program
    {
        //Напишіть програму, яка об'єднує всі елементи масиву строк у один рядок, розділяючи їх комами.
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Введіть текст: ");
            string[] inputArray = Console.ReadLine().Split(' ');

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < inputArray.Length; i++)
            {
                sb.Append(inputArray[i]);
                if(i < inputArray.Length - 1)
                {
                    sb.Append(", ");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}