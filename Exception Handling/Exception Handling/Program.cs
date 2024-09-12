using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first number :");
            int x=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your second number :");
            int y=Convert.ToInt32(Console.ReadLine());
            int z;
            try
            {
                z = (x / y);
                Console.WriteLine(z);
            }
            catch (Exception e)
            {
                Console.WriteLine("infinity");
            }
            finally {
                Console.WriteLine("Thank you bby");
            }
        }
    }
}
