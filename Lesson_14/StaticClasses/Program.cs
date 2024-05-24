using System.Runtime.CompilerServices;

namespace StaticClasses
{
    class TestClass
    {
        public string name;
        public static string staticName;
        public TestClass()
        {
            Console.WriteLine("Instance Ctor");
        }

        public TestClass(string name)
        {
            Console.WriteLine("Instance Ctor with parameter");
            this.name = name;
            Console.WriteLine(staticName);
        }

        static TestClass()
        {
            staticName = "Path to log file in the system";
            Console.WriteLine("Static Ctor");
            //Console.WriteLine(name); -- compile error
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //TestClass test = new TestClass();

            //TestClass.staticName = "New path to log file";


            //TestClass test = new TestClass();

            TestClass test2 = new TestClass("Test2");
            //Console.WriteLine(test2.name);

            //TestClass test3 = new TestClass("Test3");
            //Console.WriteLine(test3.name);
        }
    }
}