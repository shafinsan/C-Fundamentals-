using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToString_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal human = new Human("Jaber", 27, "Student");
            Console.WriteLine(human);
        }
    }
    public class Animal
    {
        protected string name;
        protected int age;
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

    }
    public class Human : Animal
    {
        string job;
        public Human(string name, int age, string job) : base(name, age)
        {
            this.job = job;
        }
        public override string ToString()
        {
            return $"This is Animal class and name " +
                  $"of the animal is {this.name} and age is {this.age}";
        }
    }
}
