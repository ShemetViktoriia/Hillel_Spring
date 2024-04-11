using System.Diagnostics;

namespace TernaryOperator
{
    internal class Program
    {
        // check if number is even
        static void Main(string[] args)
        {
            // generate random number between 0 and 1000
            int randomNumber = GenerateRandomNumber(1001);

            // check if number is even
            bool checkResult = IsEven(randomNumber);

            // Print
            PrintResultOfCheck(randomNumber, checkResult);
        }

        private static void PrintResultOfCheck(int randomNumber, bool checkResult)
        {
            Console.WriteLine($"Is Number {randomNumber} even - {checkResult}");
        }

        private static bool IsEven(int randomNumber)
        {
            // 1. 
            //if (randomNumber % 2 == 0) 
            //{ 
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            //2.
            //if (randomNumber % 2 == 0)
            //{
            //    return true;
            //}
            //return false;

            //3.
            //bool res = (randomNumber % 2 == 0) ? true : false;
            //return res;

            //4.
            //return (randomNumber % 2 == 0) ? true : false;

            //5.
            return randomNumber % 2 == 0;
        }

        private static int GenerateRandomNumber(int limit)
        {
            Random rand = new Random();
            return rand.Next(limit);
        }
    }
}