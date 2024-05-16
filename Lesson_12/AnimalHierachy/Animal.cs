using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierachy
{
    internal class Animal
    {
        protected string Name { get; set; }

        public Animal(string name)
        {
            this.Name = name;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes sound");
        }
    }
}
