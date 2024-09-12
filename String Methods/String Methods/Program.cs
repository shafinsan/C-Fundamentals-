using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //upper
            string name = "elias jaber shafin";
            Console.WriteLine(name.ToUpper());
            name = "ELIAS JABER SHAFIN";
            //lower
            Console.WriteLine(name.ToLower());
            //replace
            Console.WriteLine(name.Replace(" ","%"));
            //insert
            Console.WriteLine(name.Insert(0,"Mohammad "));
            //length
            Console.WriteLine(name.Length);
        }
    }
}
