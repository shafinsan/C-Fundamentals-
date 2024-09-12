using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name : ");
            string name=Console.ReadLine();
            Console.Write("Enter Your age : ");
            int age=Convert.ToInt32(Console.ReadLine());
            if(age>15 && name=="elias jaber")
            {
                Console.WriteLine("Your name is :" + name + " and you age is :" + age);
            }
            else if( age == 15 || name=="elias jaber")
            {
                Console.WriteLine("Your name is :" + name + " and you are younger and your age is :" + age);
            }
            else
            {
                Console.WriteLine("you are not shafin");
            }

        }
    }
}
