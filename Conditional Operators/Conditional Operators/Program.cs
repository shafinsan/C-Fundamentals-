using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age :");
            int age=Convert.ToInt32(Console.ReadLine());
            string message=(age > 15) ? "you are older then 15" : "you are younger the 15";
            Console.WriteLine(message);
        }
    }
}
