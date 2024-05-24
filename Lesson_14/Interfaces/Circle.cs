using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Circle : Figure, IDraw, IDraw2
    {
        void IDraw.Draw()
        {
            Console.WriteLine("Draw Circle with help IDraw");
        }

        void IDraw2.Draw()
        {
            Console.WriteLine("Draw Circle with help IDraw2");
        }
    }
}
