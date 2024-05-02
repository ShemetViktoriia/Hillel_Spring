using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Rectangle
    {
        /*private*/
        //private double width;
        //public double Width
        //{
        //    set 
        //    { 
        //        if (value <= 0 ) 
        //        {
        //            Console.WriteLine("Not valid value");
        //        }
        //        else
        //        {
        //        width = value;
        //        }
        //    }
        //    get { return width; }
        //}


        ///*private*/
        //private double height;
        //public double Height
        //{
        //    get { return height; }
        //    set { height = value; }
        //}

        public double Width { get; set; } = 5;
        public double Height { get; set; } = 5;

        private void SecretActions()
        {
            Console.WriteLine("SecretActions");
        }
        public double CalculateArea()
        {
            SecretActions();
            return Width * Height;
        }
    }
}
