using System.Collections.Generic;
using System.Collections;

namespace Collections
{
    // Коллекції - структура даних для зберігання обєктів однієї природи

    // Масиви - фіксований розмір
    // потрібно бути уважним при доступі за індексом
    // складність змінювати масив (додавання, видалення)

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}";
        }
    }

    internal class Program
    {
        static void PrintList(List<int> list)
        {
            Console.WriteLine("-------------");
            foreach (int i in list) { Console.WriteLine(i); }
        }

        static void PrintArray(int[] intArray)
        {
            foreach (int i in intArray) { Console.WriteLine(i); }
        }
        static void Main(string[] args)
        {
            // Array
            int[] intsArray = new int[] { 1, 2, 3 };

            // List<T>
            List<int> ints = new List<int>() { 1, 2, 3 };

            //Console.WriteLine(sizeof(int));

            List<int> intList = new List<int>() { 1, 2, 3, 4};
            intList.Add(25);
            intList.AddRange(new int[] {4, 5});

            intList[3] = 8;  // can change by index
            // intList[6] = 100; can't add new elements by index
            foreach (var elem in intList)
            {
                Console.WriteLine(elem);
            }

            List<int> intsDefault = new List<int>();
            Console.WriteLine(intsDefault.Capacity);
            intsDefault.Add(0);
            Console.WriteLine(intsDefault.Capacity);

            Console.WriteLine("-------------");
            intList.Sort();
            PrintList(intList);

            Console.WriteLine("-------------");
            Console.WriteLine(intList.BinarySearch(100));

            int[] intsToCopy = new int[intList.Count];
            intList.CopyTo(intsToCopy, 0);

            Console.WriteLine("-------------");
            PrintArray(intsToCopy);

            List<int> intsDividedByTwo = intList.FindAll(elem => elem % 2 == 0);
            PrintList(intsDividedByTwo);

            Console.WriteLine(intList.Contains(2));

            intList.InsertRange(3, new int[] { 4, 101, 102 });
            PrintList(intList);


            // ArrayList
            ArrayList arrayList = new ArrayList() { 1, "string", true, 'c', new Person(1, "Alex")};
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }


            // Queue<T> - FIFO - first in first out
            Queue<string> queue = new Queue<string>(4);
            if (queue.Count > 0)
            {
                Console.WriteLine(queue.Peek());
            }
            else
            {
                Console.WriteLine("Queue is empty");
            }

            bool isExist = queue.TryPeek(out var result);
            Console.WriteLine(isExist ? result : "Queue is empty");

            queue.Enqueue("a"); // Додає елемент в чергу
            queue.Enqueue("adfsfsf"); // Додає елемент в чергу
            Console.WriteLine(queue.Peek());

            isExist = queue.TryPeek(out var result2);
            Console.WriteLine(isExist ? result2 : "Queue is empty");

            Console.WriteLine("-------------");
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }


            // Stack<T> - LIFO - last in first out
            // 1, 4 , 5  => 5, 4, 1
            // (4 + 5) * 6 * (5 - 9  + 6 

            Stack<char> stack = new Stack<char>(new List<char>() {'a', 'b', 'v'});

            Console.WriteLine("-------------");
            Console.WriteLine(stack.Peek());
            stack.Push('w');
            Console.WriteLine(stack.Peek());

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }


            // Dictionary<K, V>  ,  K = Key , V = Value
            Dictionary<int, string> dictUsers = new Dictionary<int, string>()
            {
                {1, "Alex" },
                {2, "Oleg" },
                {3, "Volodymyr" }
            };

            Dictionary<string, string> dictUsers2 = new Dictionary<string, string>()
            {
                ["a"] = "a",
                ["b"] = "b",
                ["c"] = "c"
            };
            dictUsers2["d"] = "d";
            Console.WriteLine("-------------");


            foreach (var item in dictUsers2)
            {
                Console.WriteLine($"Key = {item.Key}, Value = {item.Value}");
            }



            dictUsers[4] = "Pavlo";
            dictUsers[1] = "Elena";

            foreach (var item in dictUsers)
            {
                Console.WriteLine($"Key = {item.Key}, Value = {item.Value}");
            }

            dictUsers.Remove(4);
            Console.WriteLine("-------------");
            foreach (var item in dictUsers)
            {
                Console.WriteLine($"Key = {item.Key}, Value = {item.Value}");
            }

            dictUsers.Add(4, "Olga");



            Console.WriteLine("-------------");
            foreach (var item in dictUsers)
            {
                Console.WriteLine($"Key = {item.Key}, Value = {item.Value}");
            }


            Dictionary<int, int> dictInts = new Dictionary<int, int>()
            {
                {1, 1 },
                {2, 2 },
                {3, 3 }
            };
            dictInts[100] = 500;
            Console.WriteLine(dictInts.GetValueOrDefault(100));

            Console.WriteLine(dictInts[100]);

            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);


            // Напишіть програму, яка підраховує частоту кожного слова у рядку за допомогою Dictionary<string, int>.

            Console.WriteLine("-------------");
            string input = "Hello word hello world I am here am";
            string[] inputString = input.ToLower().Split(' ');

            var dictWords = new Dictionary<string, int>();
            foreach (var word in inputString)
            {
                if (dictWords.ContainsKey(word))
                {
                    dictWords[word] += 1;
                }
                else 
                {
                    dictWords[word] = 1;
                }
            }

            foreach (var item in dictWords)
            {
                Console.WriteLine($"Word - {item.Key}, Count - {item.Value}");
            }
        }
    }
}