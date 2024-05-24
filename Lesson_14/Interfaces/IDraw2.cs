using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IDraw2
    {
        public void Draw();

        public void DrawDefault()
        {
            Console.WriteLine("Default implementation of Draw");
        }
    }
}
