﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmatic_Operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
            int x = 5;
            Console.WriteLine(x++);
            Console.WriteLine(x--);
            x += 2;
            Console.WriteLine(x);
            x -= 2;
            Console.WriteLine(x);

            x = x % 2;
            Console.WriteLine(x);
            x *= 2;
            Console.WriteLine(x);

        }
    }
}
