using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name :");
            string name=Console.ReadLine();
            Console.Write("Enter your age :");
            int age = Convert.ToInt32(Console.ReadLine());
            string message = (age > 15) ? $"your name is {name} and you are older then 15" : 
                $"your name is {name} and you are younger the 15";
            Console.WriteLine(message);
        }
    }
}
