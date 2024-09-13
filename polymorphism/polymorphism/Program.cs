using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an array of Animal references
            Animal[] animals = new Animal[3];

            // Assign different types of Animal
            animals[0] = new Dog("dog",7);
            animals[1] = new Cat("cat",8);
           
            // Call the Speak method on each one (Run-time polymorphism)
            foreach (Animal animal in animals)
            {
                animal.Speak();
            }
        }
    }

    // Base class Animal
    public abstract class Animal
    {
        protected string name;
        protected int age;
        public Animal(string name, int age)
        {
            this.name = name;  
            this.age = age;
        }
        public virtual void Speak()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    // Derived class Dog
    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }
        public override void Speak()
        {
            Console.WriteLine($"The dog barks. this dog name is {this.name} and age is {this.age}");
        }
    }

    // Derived class Cat
    public class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }
        public override void Speak()
        {
            Console.WriteLine($"The cat meaow. this cat name is {this.name} and age is {this.age}");
        }
    }
}
