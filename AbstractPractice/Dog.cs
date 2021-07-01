using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPractice
{
    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("A Dog is created .");
        }
        public override void Eat()  // abstract method therefore used "override"
        {
            Console.WriteLine("A Dog is eating .");
        }
        public new void Walking()  //alreadey there in base class so for encapsulation "new" used
        {
            Console.WriteLine("A Dog is walking .");
        }
        public void Ruff()
        {
            Console.WriteLine("The dog says ruff .");
        }
    }
}
