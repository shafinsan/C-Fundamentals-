using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string>list =new List< string > ();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            list.Add("5");
            list.Add("6");
            list.Add("7");
            foreach (string s in list)
            {
                Console.WriteLine (s);
            }
            list.Remove("6");
            Console.WriteLine("after deleting 6");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("constains 2 :"+list.Contains("2"));
            list.Insert(0,"elias");
            Console.WriteLine("After inserting elias in index 0");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
