using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random=new Random();
            int newValue1=random.Next(1,7);
            Console.WriteLine("int random number : "+newValue1);
            double newValue2 = random.NextDouble();
            Console.WriteLine("double random number : "+newValue2);
        }
    }
}
