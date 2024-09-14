using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>();
            list1.Add("elias");
            list1.Add("jaber");
            list1.Add("shafin");
            List<string> list2 = new List<string>();
            list2.Add("a");
            list2.Add("b");
            list2.Add("c");
            Dictionary<int,List<String>>file = new Dictionary<int,List<String>>();
            file.Add(0, list1);
            file.Add(1, list2);
            for (int i = 0; i < file.Count; i++)
            {
                for (int j = 0; j < file[i].Count; j++)
                {
                    Console.Write(file[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
