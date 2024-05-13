namespace ExceptionHandling
{
    internal class Program
    {
        public static void Test1()
        {
            Test2();
            Console.WriteLine("Method Test1");
        }

        public static void Test2()
        {
            Test3();
            Console.WriteLine("Method Test2");
        }

        public static void Test3()
        {
            int[] array = { 1, 2, 3 };
            array[3] = 6;           
            Console.WriteLine("Method Test3");
        }

        static void Main(string[] args)
        {
            // Обробка виключень Exception

            // try - catch
            // try - catch - finally
            try
            {

                string input = "11111111111111111111111111111111111111111111111111111111111111";
                int age = int.Parse(input);
                if (age < 0 || age > 100)
                {
                    throw new FormatException("Age is negative");
                }

                Test1();


                //string input = null;

                //if (input.Length > 0)
                //{
                //    Console.WriteLine("there are symbols");
                //}


                //int[] array = { 1, 2, 3 };
                //array[3] = 6;  
            }
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("IndexOutOfRangeException");
            //}
            //catch (NullReferenceException)
            //{
            //    Console.WriteLine("NullReferenceException");
            //}
            catch (FormatException ex)
            {
                // логування
                // закрити підключення до БД, до файлу
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.Source);
            }
            finally
            {

                Console.WriteLine("Finally");
                //try
                //{
                //    int[] array = { 1, 2, 3 };
                //    array[3] = 6;
                //}
                //catch (Exception)
                //{
                //    // логування
                //    // закрити підключення до БД, до файлу
                //    Console.WriteLine("Exception hapenned");
                //}
            }
        }
    }
}