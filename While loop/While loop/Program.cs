using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Enter Your Name :");
            name = Console.ReadLine();
            while (name == "")
            {
                Console.Write("Enter Your Name :");
                name = Console.ReadLine();
            }
            Console.WriteLine("Your name is :" + name);
        }
    }
}
