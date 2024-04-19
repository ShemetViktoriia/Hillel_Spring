using System.Reflection.Metadata;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int length = random.Next(1, 101);

            int[] nums = new int[length];
            
            Console.WriteLine($"Length array is {length}");

            // fill
            for (int i = 0; i < nums.Length; i+=2)
            {
                nums[i] = random.Next(101); // set
            }

            // Print
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + "\t");
            }

            Console.WriteLine();
            Console.WriteLine(nums);
            Console.WriteLine(random);


            foreach(var num in nums) // { 2, 5, 6, 8}  // тільки для get
            {
                if (num % 2 == 0)
                {
                    Console.Write(num + "\t");
                }
            }



            //string charArray = "Hello World";
            //for (int i = 0; i < charArray.Length; i++)
            //{
            //    Console.Write(charArray[i] + "\t");
            //}

            //User user = new User();
            //// set user
            //Console.WriteLine(user.ToString()); // Arrays.User


            Console.WriteLine();
            Console.WriteLine(nums.ToString());


            // Додати до масиву елемент у кінець
            int[] largerNums = new int[nums.Length + 1];
            // nums 100 - largerNums 101
            for (int i = 0; i < nums.Length; i++)
            {
                largerNums[i] = nums[i];
            }
            largerNums[largerNums.Length - 1] = 1000000;

            foreach (var item in largerNums)
            {
                Console.Write(item + "\t");
            }
        }
    }
}