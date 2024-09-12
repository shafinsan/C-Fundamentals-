using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("elias");
            Car c2 = new Car("Jaber");
            Car c3 = new Car("shafin");
            c1.dispaly();
            c2.dispaly();
            c3.dispaly();
            Console.WriteLine($"Number of car is {Car.number}");
        }
    }
    class Car
    {
        public string name;
        public static int number = 0;
        public Car(string name)
        {
            this.name = name;
            number += 1;
        }
        public void dispaly()
        {
            Console.WriteLine("name of the car is :" + this.name);
        }
    }
}
