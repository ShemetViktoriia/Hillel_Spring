namespace AnimalHierachy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog("Rex", "Taksa");
            Animal cat = new Cat("Kissa");

            dog.MakeSound();
            cat.MakeSound();

        }
    }
}