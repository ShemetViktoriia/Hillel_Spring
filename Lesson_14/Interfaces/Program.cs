namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDraw[] arrayObj = { new Circle(), new Rectangle()};
            foreach (var obj in arrayObj) 
            {
                DrawObject(obj);
            }

            IDraw2 circle = new Circle();
            circle.Draw();
            circle.DrawDefault();

            Rectangle rectangle = new Rectangle();
            rectangle.CalculatePerimeter(10, 50);

            ((IDraw)rectangle).DrawWithColor();
            
        }

        static void DrawObject(IDraw obj)
        {
            obj.Draw();
            obj.DrawWithColor();
        }
    }
}