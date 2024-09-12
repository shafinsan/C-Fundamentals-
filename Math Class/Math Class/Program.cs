using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double db_number = Math.Floor(3.145);
            Console.WriteLine("Floor : " + db_number);
            db_number = Math.Ceiling(3.45);
            Console.WriteLine("Celling : " + db_number);
            double max = Math.Max(1, 2);
            Console.WriteLine("Max : " + max);
            double min = Math.Min(1, 2);
            Console.WriteLine("Min : " + min);
            db_number = Math.Pow(2, db_number);
            Console.WriteLine("Power : " + db_number);
            db_number = Math.Sqrt(db_number);
            Console.WriteLine("Sqrt : " + db_number);
            db_number = Math.Round(db_number);
            Console.WriteLine("Round : " + db_number);
            int negative = -5;
            negative = Math.Abs(negative);
            Console.WriteLine("Abs + " + negative);
        }
    }
}
