using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] value1 = { "Elias", "Jaber", "Shafin" };
            foreach(string s in value1)
            {
                Console.WriteLine(s);
            }
            string[] value2 = new string[3] { "elias", "jaber", "shafin" };
            foreach (string s in value2)
            {
                Console.WriteLine(s);
            }
            string[] value3 = new string[4];
            value3[0] = "a";
            value3[1] = "b";
            value3[2] = "c";
            value3[3] = "d";
            foreach (string s in value3)
            {
                Console.WriteLine(s);
            }

        }
    }
}
