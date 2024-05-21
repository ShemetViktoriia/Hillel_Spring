namespace AbstractClasses
{
    internal class Rectange : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectange(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * ( Width + Height);
        }

        public override string ToString()
        {
            return $"Rectangle with Width = {Width} and Height = {Height}, Area = {this.CalculateArea()}, Perimeter = {this.CalculatePerimeter()}";
        }

    }
}
