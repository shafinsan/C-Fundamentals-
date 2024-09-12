using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params_Keywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] x2 = { 1, 2, 3, 4 };
            int addition1 = sumFunc(x1);
            int addition2 = sumFunc(x2);
            Console.WriteLine("addition :"+addition1);
            Console.WriteLine("addition :"+addition2);

        }
        static int sumFunc(params int[] x)
        {
            int z = 0;
            for (int i = 0; i < x.Length; i++)
            {
                z += x[i];
            }
            return z;
        }
    }
}
