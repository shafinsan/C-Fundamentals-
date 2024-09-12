using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            add(1, 2, 3);
            add(1, 2);
        }

  
        static void add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        static void add(int x, int y, int z)
        {
            Console.WriteLine(x + y + z);
        }
    }
}
