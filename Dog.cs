using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPractice
{
    internal class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog Barks!!!");
        }

        public override void Legs()
        {
            Console.WriteLine("Dog has four legs");
        }

        //
    }
}
