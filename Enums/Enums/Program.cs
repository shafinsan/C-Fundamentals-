using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Day.Friday} is number {(int)Day.Friday}");
        }
    }
    enum Day
    {
        Friday = 0,
        Saturday = 1,
        Sunday = 2,
        Monday = 3,
        Tuesday = 4,
        Wednesday = 5,
        Thursday = 6

    }
}
