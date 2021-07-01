using System;

namespace AbstractPractice
{
    abstract class Animal
    {
        public Animal()
        {
            Console.WriteLine("An Animal has been created .");
        }

        public abstract void Eat();
        

        public void Walking()
        {
            Console.WriteLine("An Animal is walking .");
        }
        static void Main(string[] args)
        {
            Cat c = new Cat();
            Dog d = new Dog();
            Console.WriteLine();
            c.Eat();
            c.Walking(); //cat walking is not implemented therefore, animal class method runs.
            c.Meow();
            Console.WriteLine();
            d.Eat();
            
            d.Walking();
            d.Ruff();
        }
    }
}
