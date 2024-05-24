using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Rectangle : IDraw
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int CalculatePerimeter(int width, int height)
        {
            return 2 * (Width + Height);
        }

        public void Draw()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }
}
