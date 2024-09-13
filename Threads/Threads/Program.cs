using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread ctThread = Thread.CurrentThread;
            ctThread.Name = "Elias";
            Console.WriteLine("Main threads name is " +ctThread.Name);
            Thread thread1 = new Thread(coundDown);
            Thread thread2 = new Thread(CountUp);
            thread1.Start();
            thread2.Start();
        }
        public static void CountUp()
        {
            int x = 0;
            while (x < 10) {
                Console.WriteLine("count Up "+x);
                x++;
                Thread.Sleep(1000);
            }
        }
        public static void coundDown()
        {
            int x = 10;
            while (x >= 0)
            {
                Console.WriteLine("count Down " + x);
                x--;
                Thread.Sleep(1000);
            }
        }
    }
}
