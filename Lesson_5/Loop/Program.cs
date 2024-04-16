namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // неявно типізована змінна
            var varVariable = 2;

            var rand = new Random();

            //varVariable = "string";  compile error

            var varVariableBool = false;
            bool boolVariable = true;

            int a = 100, b = 200; 
            int c = a + b;

            var x = rand.Next(256);


            // 1. Виведемо всі парні числа від 0 до 100 (різні способи)

            // 1.
            //for (int i = 0; i < 101; i++) 
            //{
            //    if (i%2 == 0)
            //    {
            //        Console.Write(i + "\t"); //0 2 4 6810
            //    }
            //}

            // 2.
            //for (int i = 0; i < 101; i += 2)
            //{
            //    Console.Write(i + "\t");
            //}

            // 3.
            //int i = 0;
            //while (i < 101)
            //{
            //    Console.Write(i + "\t");
            //    i += 2;
            //}


            // 4.
            //int i = 0;
            //while (true)
            //{
            //    Console.Write(i + "\t");
            //    i += 2;
            //    if(i>100)
            //    {
            //        break;
            //    }
            //}

            // 2. Виведемо всі парні числа від 100 до 0
            //for (int i = 100; i>-1; i -=2)
            //{
            //    Console.Write(i + "\t");
            //}

            // 0 + 1 + 2 + 3 +... + 98 + 99 + 100 = 50 * 100 + 50 = 50 * 101
            // 3. Знайти суму, добуток чисел від 0 до 100  0*1*...= 0
            //int sum = 0; int mult = 1; 
            //for (int i = 0; i < 101; i++)
            //{
            //    sum += i;
            //    mult *= i;
            //}
            //Console.WriteLine($"Sum = {sum}");
            //Console.WriteLine($"Mult = {mult}");


            // Таблиця множення
            //for (int i = 1;i <= 10; i++) // 1*1=1
            //{
            //    for (int j = 1; j <=10; j++)
            //    {
            //        Console.WriteLine($"{i} * {j} = {i*j}");
            //    }
            //}


            // У гусей та кроликів разом 64 лапи. Скільки може бути кроликів та гусей (вказати всі поєднання)?
            //for (int i = 0; i <= 32; i++)
            //{
            //    for (int j = 0; j <= 16; j++)
            //    {
            //        if (i *2 + j *4 == 64)
            //        {
            //            Console.WriteLine($"{i} - {j}");
            //        }
            //    }
            //}

            // Кількість цифр числа
            // 56892555
            int randomValue = rand.Next();
            int i = 0;
            Console.WriteLine($"randomValue = {randomValue}");

            //while (randomValue > 0)
            //{
            //    randomValue /= 10;
            //    i++;
            //}

            do
            {
                i++;
                randomValue /= 10;
            } while (randomValue > 0);

            Console.WriteLine($"Number of Digits = {i}");

        }
    }
}