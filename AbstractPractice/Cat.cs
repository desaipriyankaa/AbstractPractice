using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPractice
{
    internal class Cat : Animal
    {
        public Cat()
        {            
            Console.WriteLine("A Cat is created .");
        }
        public override void Eat()
        {
            Console.WriteLine("A Cat is eating .");
        }
        public void Meow()
        {
            Console.WriteLine("The cat says meow .");
        }
    }
}
