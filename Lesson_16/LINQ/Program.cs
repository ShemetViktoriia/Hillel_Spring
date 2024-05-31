namespace LINQ
{
    // Методи розширення 
    // Додати новий метод для string, який обчислює кількість слів у реченні

    public static class StringExtension
    { 
        public static int CountWordsInString(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }
            return str.Split(new char[] { ',', ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Count();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string example = "Hello,,   how are you today,?";
            int count = example.CountWordsInString();
            Console.WriteLine(count);


            // негайне та відкладене виконання LINQ запитів
            // виконання LINQ запитів відбувається в момент або перебору в циклі foreach
            // або в момент виклику методів ToList(), ToDictionary(), To.., Count(), …
            

            //1 відкладене виконання
            List<string> listNames = new List<string>() {"Pavlo", "Vlad", "Alex"};

            var resultOrdered = listNames.OrderBy(n => n);

            listNames.Add("Mykola");

            Console.WriteLine("--------------------");
            foreach (var item in resultOrdered)
            {
                Console.WriteLine(item);
            }


            //2 негайне
            List<string> listNames2 = new List<string>() { "Pavlo", "Vlad", "Alex" };

            var resultOrdered2 = listNames2.OrderBy(n => n).ToList(); // Матеріалізація

            listNames2.Add("Mykola");

            Console.WriteLine("--------------------");
            foreach (var item in resultOrdered2)
            {
                Console.WriteLine(item);
            }



            //Знайдіть всі числа в масиві data, які діляться на 3 або 5:
            int[] data = { 15, 9, 7, 30, 45, 21, 10 };

            var result = data.Where(x => x % 3 == 0 || x % 5 == 0).ToList();
            Console.WriteLine("--------------------");
            Console.WriteLine(string.Join(',', result));

            // Знайдіть всі слова в списку words, які починаються на літеру "а" і закінчуються на "я":
            List<string> words = new List<string> { "автомобіля", "банан", "ананас", "комп'ютер", "аркуш", "" };
            var resWords = words.Where(w => w.StartsWith('а') && w.EndsWith('я'));
            Console.WriteLine("--------------------");
            Console.WriteLine(string.Join(',', resWords));


            //Знайдіть усі рядки у списку strings, які мають довжину менше ніж 6 символів та закінчуються на "це":
            List<string> strings = new List<string>
                {
                    "книга",
                    "стіл",
                    "картина",
                    "сонце",
                    "чайник"
                };
            var resStrings = strings.Where(s => s.Length < 6 && s.EndsWith("це"));
            Console.WriteLine("--------------------");
            Console.WriteLine(string.Join(',', resStrings));


            //Знайдіть всі числа в масиві numbers, які закінчуються на цифру 7:
            int[] nums = { 7, 17, 27, 35, 47, 78, 99, 123, 567 };
            var resNums = nums.Where(num => num % 10 == 7);
            Console.WriteLine("--------------------");
            Console.WriteLine(string.Join(',', resNums));


            //Знайдіть всі числа в масиві numbers, які є квадратами інших чисел:
            int[] num = { 1, 4, 9, 10, 16, 20, 25, 36, 49, 50 };
            var resNum = num.Where(num => Math.Sqrt(num) % 1 == 0);
            Console.WriteLine("--------------------");
            Console.WriteLine(string.Join(',', resNum));

            // Знайдіть найдовше слово в рядку sentence:
            string sentence = "Це речення має декілька слів, і ми шукаємо найдовше. яяяяяяяя";
            var maxLength = sentence.Split(new char[] { ',', ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries)
                                    .OrderByDescending(w => w.Length).FirstOrDefault()?.Length ?? 0;

            var resWord = sentence.Split(new char[] { ',', ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Where(w => w.Length == maxLength);
                                    
            Console.WriteLine("--------------------");
            Console.WriteLine(string.Join(',', resWord));

        }
    }
}