namespace AbstractClasses
{
    internal class Square : Shape
    {
        public double Width { get; set; }
        public Square(double width)
        {
            Width = width;
        }

        public override double CalculateArea()
        {
            return Width * Width;
        }

        public override double CalculatePerimeter()
        {
            return 4 * Width;
        }

        public override string ToString()
        {
            return $"Square with Width = {Width}, Area = {this.CalculateArea()}, Perimeter = {this.CalculatePerimeter()}";
        }

    }
}
