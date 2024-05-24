using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IDraw
    {
        public void Draw();
        public void DrawWithColor()
        {
            Console.WriteLine("Draw with color");
        }
    }
}
