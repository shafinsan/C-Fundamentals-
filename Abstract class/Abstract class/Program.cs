using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal human = new Human("Jaber", 27, "Student");
            human.Display();
        }
    }
    public abstract class Animal
    {
        protected string name;
        protected int age;
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public abstract void Display();
       
    }
    public class Human : Animal
    {
        string job;
        public Human(string name, int age, string job) : base(name, age)
        {
            this.job = job;
        }
        public override void Display()
        {
            Console.WriteLine($"This is Human class and name " +
                $"of the human is {this.name} and age is {this.age}");
        }
    }
}
