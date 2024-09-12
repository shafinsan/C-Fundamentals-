using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 15;
            Console.Write("Enter Your Age : ");
            int userValue=Convert.ToInt32(Console.ReadLine());
            if (userValue > x)
            {
                Console.WriteLine("You are older then " + x);
            }
            else if(userValue < x)
            {
                Console.WriteLine("You are younder then " + x);
            }
            else
            {
                Console.WriteLine("Your age is " + x);
            }
        }
    }
}
