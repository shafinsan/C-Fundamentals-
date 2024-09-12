using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged_array = new int[4][];
            jagged_array[0]= new int[2];
            jagged_array[1]= new int[3];
            jagged_array[2]= new int[1];
            jagged_array[3]= new int[3];

            for (int i = 0; i < jagged_array.Length; i++)
            {
                for(int j = 0; j < jagged_array[i].Length; j++)
                {
                    Console.Write($"arr[{i}][{j}] :");
                    jagged_array[i][j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < jagged_array.Length; i++)
            {
                for (int j = 0; j < jagged_array[i].Length; j++)
                {
                    Console.Write(jagged_array[i][j] + " ");
                }
                Console.WriteLine();
            }
            
            for(int i = 0; i < jagged_array.Length; i++)
            {
                Console.WriteLine("max : "+jagged_array[i].Max());
            }
        }
    }
}
