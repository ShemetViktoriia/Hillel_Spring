namespace AbstractClasses
{
    /*
    Абстрактні класи:
    Абстрактний клас - це клас, який не можна створити напряму, а тільки успадковувати від нього.
    Абстрактний клас може містити як абстрактні методи (без реалізації), так і звичайні методи (з реалізацією).
    Абстрактний клас використовується для визначення спільних характеристик і поведінки для похідних класів.
     
    Абстрактні методи:
    Абстрактний метод не має реалізації і повинен бути реалізований у похідному класі.
    Якщо клас містить хоча б один абстрактний метод, цей клас повинен бути оголошений як абстрактний.

    Конструктори в абстрактних класах:
    Абстрактний клас може мати конструктори.
    Конструктори абстрактного класу викликаються з конструкторів похідних класів.

    МОДИФІКАТОРИ абстрактних членів не може бути private!!
    Похідний клас повинен реалізувати всі абстрактні члени базового класу. Однак ми можемо відмовитися від реалізації, 
    але в цьому випадку похідний клас також має бути визначений як абстрактний.
     */

    abstract class A
    {
        public int Age { get; set; }
        public abstract string Name { get; set; }
        public A(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void Move(); // virtual - override ; abstract - override

        public virtual void Display()
        {
            Console.WriteLine(Name);
        }
    }

    class B : A
    {
        public B(string name, int age) : base(name, age)
        {
                
        }

        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Move()
        {
            throw new NotImplementedException();
        }

        public override void Display()
        {
            base.Display();
        }
    }

    abstract class C : A 
    {
        public C(string name, int age) : base(name, age)
        {

        }
    }


    internal class Program
    {
        /*
         Створіть абстрактний клас Shape, який представляє геометричну фігуру.
        У цьому класі повинні бути оголошені абстрактні методи CalculateArea() та CalculatePerimeter(), 
        які будуть обчислювати площу і периметр фігури відповідно. 
        Потім створіть конкретні класи Circle і Rectangle, які успадковують клас Shape і реалізують його абстрактні методи. */

               
        static void Main(string[] args)
        {
            // A a = new A();  - compile error 

            //Shape[] shapes =
            //{
            //    new Circle(2),
            //    new Square(10),
            //    new Rectange(10, 50)
            //};


            //foreach (var shape in shapes)
            //{
            //    Console.WriteLine(shape);
            //}


            Shape circle1 = new Circle(1); //1
            Shape circle2 = new Circle(2); //2
            Shape circle3 = new Circle(3); //3

            Console.WriteLine(Circle.Number);
        }
    }
}