using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your age : ");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Age is : "+ value);
        }
    }
}
