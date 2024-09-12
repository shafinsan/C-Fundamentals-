using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double p = 3.1416;
            Console.WriteLine("you can not change your value,because we are declare and initialize " +
                "our value as constant...the value is :" + p);
        }
    }
}
