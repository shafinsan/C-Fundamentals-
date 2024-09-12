using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int int_value = 5;
            double double_value = 6.1;
            float floating_value = 6.2f;
            bool bool_value = false;
            Console.WriteLine("int value :" + int_value);
            Console.WriteLine("double value :" + double_value);
            Console.WriteLine("floating value :" + floating_value);
            Console.WriteLine("bool value :" + bool_value);

            Console.WriteLine("******************************************");

            double new_double = Convert.ToDouble(int_value);
            double new_int = Convert.ToInt32(double_value);
            string new_string = Convert.ToString(int_value);
            Console.WriteLine("Type :" + new_double.GetType());
            Console.WriteLine("Type :" + new_int.GetType());
            Console.WriteLine("Type :" + new_string.GetType());



        }
    }
}
