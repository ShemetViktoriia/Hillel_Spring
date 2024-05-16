using System.Linq.Expressions;

namespace InheritanceLesson
{
    sealed public class A
    {
    }

    // наслідування не дозволено!!
    //class B : A
    //{
    //}




    class BaseClass
    {
        string name;
        // 
        public string Name { get; set; }

        public BaseClass()
        {
            name = string.Empty;
            Console.WriteLine("Constructor from Base Class");
        }

        public BaseClass(string name)
        {
            this.name = name;
            Console.WriteLine("Constructor from Base Class");
        }
    }

    class DerivedClass : BaseClass
    {
        public int number;
        public DerivedClass()
        {
            number = 0;
            Console.WriteLine("Constructor from Derived Class");
        }

        public DerivedClass(string name, int number) : base(name)
        {
            this.number = number;
            Console.WriteLine("Constructor from Derived Class");
        }
    }

    class DerivedClass2 : BaseClass
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dc = new DerivedClass("Test", 10);

            byte a = 255;
            int b = a; // неявне приведення

            byte c = (byte)b; // явне приведення


            DerivedClass derivedObj = new DerivedClass();
            BaseClass baseObj = derivedObj; //   - Upcast до базового классу   (DerivedClass : BaseClass)

            // baseObj.number - помилка, доступ до похідного класу втрачено

            DerivedClass derivedObj2 = (DerivedClass)baseObj; // Downcast, неможливий без попереднього Upcast

            derivedObj2.number = 1; // -помилки немає, доступ до похідного класу є

            // is, as
            // is дозволяє перевірити чи можливе приведення до типу
            // a is Type - true, false

            Exception exBasic = new Exception();
            InvalidCastException icEx = new InvalidCastException();

            //if (icEx is Math)
            //{
            //    exBasic = icEx;
            //    Console.WriteLine("Upcast is posible");
            //}
            //else
            //{
            //    exBasic = null;
            //    Console.WriteLine("Upcast is imposible");
            //}

            // as
            //Console.WriteLine(exBasic.GetType());
            //exBasic = icEx as Exception;

            //Console.WriteLine(exBasic.GetType());

            //Console.WriteLine(exBasic.GetHashCode());
            //Console.WriteLine(icEx.GetHashCode());


            BaseClass bc = new DerivedClass();
            DerivedClass drc = new DerivedClass();

            DerivedClass der = bc as DerivedClass;
            // DerivedClass der2 = drc as BaseClass;


        }
    }
}