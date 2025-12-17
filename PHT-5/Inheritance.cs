using System;

namespace Inheritance
{
    class Animal
    {
        public string Name;

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Dog d = new Dog();

            a.MakeSound();   // Animal makes a sound
            d.MakeSound();   // Woof! Woof!
        }
    }
}
