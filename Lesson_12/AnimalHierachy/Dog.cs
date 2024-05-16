using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierachy
{
    internal class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, string breed) : base(name)
        {
            this.Breed = breed;
        }

        //public new void MakeSound()
        //{
        //    Console.WriteLine("Dog makes sound");
        //}

        public override void MakeSound()
        {
            //base.MakeSound();
            Console.WriteLine("Dog is barking");
        }
    }
}
