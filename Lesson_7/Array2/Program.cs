using System.Data;

namespace Array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            #region Заданий масив дійсних чисел розмірності 10х10. Знайти максимальний елемент головної діагоналі.
            const int length = 5;
            int[,] nums = new int[length, length];
            Fill(nums);
            int max = CalculateMax(nums);

            Print(nums);
            Console.WriteLine($"max = {max}");
            #endregion

            #region У масиві рядків (список прізвищ) визначте найдовше прізвище.
            
            string[] names = { "Примушко", "Пирогов", "Руссавський", "Кравченко" };
            int indexMax = 0;
            for (int i = 1; i < names.Length; i++)
            {
                if(names[i].Length > names[indexMax].Length)
                {
                    indexMax = i;
                }
            }
            Console.WriteLine($"Max name = {names[indexMax]}");
            #endregion

            #region Написати програму, в якій з масиву видаляється один елемент з позиції, яку вводить користувач.
            int[] numbers = new int[length];
            Fill(numbers);
            Print(numbers);
            Console.Write($"Введіть позицію для видалення (масив розмірністю {numbers.Length}): ");
            int position = int.Parse(Console.ReadLine());
            Array.Clear(numbers, position, 1);
            Print(numbers);
            #endregion

            #region Задано квадратну матрицю цілих чисел. Підрахуйте кількість негативних та позитивних елементів
            int[,] num = new int[length, length];
            Fill(num);
            Print(num);
            int[] counter = new int[2]; // 0 - counterPos, 1 - counterNeg 
            counter = CountResults(num);
            Console.WriteLine($"counterPos = {counter[0]}");
            Console.WriteLine($"counterNeg = {counter[1]}");
            #endregion
        }

        private static int[] CountResults(int[,] num)
        {
            int[] counterResults = new int[2];
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    _= Math.Sign(num[i, j]) == 1 ? counterResults[0]++ : counterResults[1]++;
                }
            }
            return counterResults;
        }

        private static void Print(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + "\t");
            }
            Console.WriteLine();
        }

        private static void Print(int[,] nums)
        {
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.Write(nums[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }

        private static int CalculateMax(int[,] nums)
        {
            int max = nums[0,0];
            for (int i = 1; i < nums.GetLength(0); i++)
            {
                if (nums[i,i] > max)
                {
                    max = nums[i, i];
                }
            }
            return max;
        }

        private static void Fill(int[] numbers)
        {
            var rand = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(-1, 2);
            }
        }

        private static void Fill(int[,] nums)
        {
            Random rand = new Random();
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    nums[i, j] = rand.Next(-100, 101);
                }
            }
        }
    }
}