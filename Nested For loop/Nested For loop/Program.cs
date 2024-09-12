using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_For_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int r = 0; r < 4; r++)
            {
                for(int c = 0; c <= r; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
