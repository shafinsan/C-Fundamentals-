using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x;
            Console.Write("Enter the day : ");
            x = Console.ReadLine().ToLower();
            switch (x)
            {
                case "sunday":
                    {
                        Console.WriteLine("it's sunday");
                        break;
                    }
                case "monday":
                    {
                        Console.WriteLine("it's monday");
                        break;
                    }
                case "tuesday":
                    {
                        Console.WriteLine("it's tuesday");
                        break;
                    }
                case "wednesday": {
                        Console.WriteLine("it's wednesday");
                        break;
                    }
                case "thursday":
                    {
                        Console.WriteLine("it's thursday");
                        break;
                    }
                case "friday":
                    {
                        Console.WriteLine("it's friday");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter only day name..plz");
                        break;
                    }
            }
        }
    }
}
