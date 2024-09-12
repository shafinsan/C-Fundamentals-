using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] my_array= new int[2,2,2];
            for (int i = 0; i < my_array.GetLength(0); i++)
            {
                for(int j = 0; j < my_array.GetLength(1); j++)
                {
                    for(int k = 0; k < my_array.GetLength(2); k++)
                    {
                        Console.Write($"Enter the arr[{i}][{j}][{k}] :");
                        my_array[i,j,k] =Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            foreach(int x in my_array)
            {
                        Console.Write(x +", ");
        
            }

        }
    }
}
