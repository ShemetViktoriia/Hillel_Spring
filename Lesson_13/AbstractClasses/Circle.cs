namespace AbstractClasses
{
    internal class Circle : Shape
    {
        // readonly field

        public readonly int number = Number;
        public static int Number { get; set; }
        public int GetNumberAccount()
        {
            return Number;
        }

        public double Radius { get; set; }
        public Circle(double radius) 
        {
            Number++;
            number = Number;
            Radius = radius;
        }
        public override double CalculateArea()
        {
            //number = 5;
            return Math.PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            return $"Circle with Radius = {this.Radius}, Area = {this.CalculateArea()}, Length = {this.CalculatePerimeter()}";
        }
    }
}
