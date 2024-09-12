using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            nameFuc("Elias", 25);
        }
        static void nameFuc(string name, int age)
        {
            Console.WriteLine($"Your name is : {name}");
            Console.WriteLine($"Your name is : {age}");
        }
    }
}
