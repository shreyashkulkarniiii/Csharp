using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    using System;
    public abstract class Animal
    {
        public abstract void MakeSound();
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog Barks!");
        }
    }
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat says Meow!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            Console.WriteLine("Dog Sound:");
            dog.MakeSound();

            Console.WriteLine();

            Animal cat = new Cat();
            Console.WriteLine("Cat Sound:");
            cat.MakeSound();
        }
    }
}
