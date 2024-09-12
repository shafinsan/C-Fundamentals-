using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloaded_Constractors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human p1 = new Human("elias", 26);
            Human p2 = new Human("elias", 27, true);
            p2.Display();
        }
    }
    class Human
    {
        public string userName;
        public int age;
        public bool gf;
        public Human(string userName, int age)
        {
            this.userName = userName;
            this.age = age;
        }
        public Human(string userName, int age, bool gf)
        {
            this.userName = userName;
            this.age = age;
            this.gf = gf;
        }
        public void Display()
        {
            Console.WriteLine("your name is " + this.userName);
            Console.WriteLine("your age is " + this.age);
            Console.WriteLine("your gf is " + this.gf);
        }
    }
}
