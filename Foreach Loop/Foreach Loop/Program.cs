using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 3, 4, 5, 6, 7, 8 };
            foreach(int i in x)
            {
                Console.WriteLine(i);
            }
        }
       
    }
}
