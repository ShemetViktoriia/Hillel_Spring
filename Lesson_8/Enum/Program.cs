namespace Calculator
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            var dayOfWeek = System.DayOfWeek.Monday;


            //var d = DayOfWeek.Sunday; 
            //var d1 = DateTime.Now;
            //Console.WriteLine(d1);


            //Status status = Status.Rejected;
            //Console.WriteLine(status);

            //int statusRejected = (int)Status.Rejected;
            //Console.WriteLine(statusRejected);

            //int statusDraft = (int)Status.Draft;
            //Console.WriteLine(statusDraft);

            //int a;
            //byte b = 255;
            //a = b;

            // Логічні операції
            //int x = 5 , y = 6, a = 7, b = 8;
            //while(x>y & b>a)  // (x>y && b>a)
            //{
            //    Console.WriteLine("Test");
            //}

            //while (y > x | b > a)  // (y > x || b > a)
            //{
            //    Console.WriteLine("Test");
            //}

            // Калькулятор
            // a, b - операнди, операції  +, -, *, /  Add 1, Subtract 2, Multiply 3, Divide 4

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            double oper1, oper2, result;
            Operation operation;
            // 1. отримання першого числа
            //bool res = double.TryParse(Console.ReadLine(), out oper1);
            oper1 = GetNumber("Введіть перший операнд: ");

            // 2. отримання другого числа
            oper2 = GetNumber("Введіть другий операнд: ");
            
            // 3. отримання операції (Введіть операцію 1 (+), 2 (-), 3 (*), 4 (/))
            Console.Write("Введіть операцію 1 (+), 2 (-), 3 (*), 4 (/):  ");

            while (!Enum.TryParse(Console.ReadLine(), out operation) || !Enum.IsDefined(typeof(Operation), operation))
            {
                Console.Write("Невірний ввід. Спробуй ще: ");
            }

            //bool res = Enum.TryParse(Console.ReadLine(), out operation);
            //bool isDefinedInEnum = Enum.IsDefined(typeof(Operation), operation);
            //Console.WriteLine($"res of parsing={res}");
            //Console.WriteLine($"operation={operation}");
            //Console.WriteLine($"isDefinedInEnum={isDefinedInEnum}");


            // 4. отримання результату
            result = Calculate(oper1, oper2, operation);


            // 5. вивід результату в консоль 
            Console.WriteLine("{0} {1} {2} = {3}", oper1, operation, oper2, result);
        }

        /// <summary>
        /// Method which clear last line on the Console
        /// </summary>
        public static void ClearLastLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.WriteLine();
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

        private static double GetNumber(string message)
        {
            double oper;
            Console.Write(message);
            while (!double.TryParse(Console.ReadLine(), out oper))
            {
                ClearLastLine();
                Console.Write("Невірний ввід. Спробуй ще: ");
            }

            return oper;
        }

        private static double Calculate(double oper1, double oper2, Operation operation)
        {
            double result;
            switch (operation)
            {
                case Operation.Add:
                    result = oper1 + oper2;
                    break;
                case Operation.Subtract:
                    result = oper1 - oper2;
                    break;
                case Operation.Multiply:
                    result = oper1 * oper2;
                    break;
                case Operation.Divide:
                    result = (oper2 != 0) ? oper1 / oper2 : double.NaN;                   
                    break;
                default:
                    result = double.NaN;
                    break;
            }
            return result;
        }
    }
}