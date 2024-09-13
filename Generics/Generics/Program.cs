using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] st = { "elias", "jaber", "shafin" };
            int[] num= { 1, 2,  3 };
            display(num);
            Console.WriteLine("**************************");
            display(st);
        }
        public static void display<T>(T[]array)
        {
            foreach (T t in array) {
                Console.WriteLine("value :"+t);
            }
        }
    }

}
