using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool value = true;
            double a, b;
            do
            {
                Console.Write("Enter your first number :");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter your second number :");
                b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Option a : addition");
                Console.WriteLine("Option b : subtraction");
                Console.WriteLine("Option c : multiplication");
                Console.WriteLine("Option d : division");
                Console.WriteLine("Option s :stop");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "a":
                        {
                            Console.WriteLine("addition : " + (a + b));
                            break;
                        }
                    case "b":
                        {
                            Console.WriteLine("substraction : " + (a - b));
                            break;
                        }
                    case "c":
                        {
                            Console.WriteLine("multiplication : " + (a * b));
                            break;
                        }
                    case "d":
                        {
                            Console.WriteLine("divition : " + (a / b));
                            break;
                        }
                    case "s":
                        {
                            value = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Enter the correction option");
                            break;
                        }
                }
            }while (value);
        }
    }
}
