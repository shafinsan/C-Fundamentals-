using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human p1 = new Human();
            p1.setUsername("elias",25);
            Console.WriteLine("get method called :" + p1.getUserName());
            p1.display();
        }
    }
    class Human
    {
        public string userName;
        public int age;

        public void setUsername(string userName,int age)
        {
            this.userName = userName;
            this.age = age;
        }
        public string getUserName() { return this.userName; }
        public void display()
        {
            Console.WriteLine("your name is " + this.userName);
            Console.WriteLine("your age is " + this.age);
        }
    }
}
