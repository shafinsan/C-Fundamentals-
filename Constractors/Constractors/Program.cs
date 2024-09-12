using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constractors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human p1 = new Human("elias",26);
            p1.Display();
        }
    }
    class Human
    {
        public string userName;
        public int age;
        public Human(string userName,int age)
        {
            this.userName = userName;
            this.age = age;
        }
        public Human(string userName, int age,bool gf)
        {
            this.userName = userName;
            this.age = age;
        }
        public void Display()
        {
            Console.WriteLine("your name is " + this.userName);
            Console.WriteLine("your age is " + this.age);
        }

    }
}
