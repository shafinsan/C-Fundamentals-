using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("elias", 25, "student");
            human1.Display();
          
        }
    }
    interface Ianimal
    {
        void Display();

    }
    public class Human : Ianimal
    {
        string job;
        string name;
        int age;
        public Human(string name, int age, string job)
        {
            this.name = name;
            this.age = age;
            this.job = job;

        }
        //This is method over riding
        public void Display()
        {
            Console.WriteLine($"This is Animal class and name " +
                $"of the animal is {this.name} and age is {this.age}");
        }
    }
}
