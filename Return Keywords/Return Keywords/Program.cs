using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_Keywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };   
            int sum = sumFunc(array, array.Length);
            Console.WriteLine("sum :" + sum);
        }
      
        static int sumFunc(int[] x, int size)
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
