using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random=new Random();
            bool value = true;
           
            while (value)
            {
                int number=random.Next(0,11);
                Console.Write("Enter your number (0-10):");
                int guessing_number=Convert.ToInt32(Console.ReadLine());
                if (number == guessing_number)
                {
                    Console.WriteLine("Congratulation,you guess correct number...");
                    Console.WriteLine("If you stop the game you can press 's' or else press 'a' :");
                    string stop = Console.ReadLine();
                    if (stop == "s")
                    {
                        value = false;
                    }
                    else
                    {
                        value=true;
                    }
                }
                else
                {
                    Console.WriteLine("gussing number is : " + number);
                    Console.WriteLine("your number is :" + guessing_number);
                }
                
            }
        }
    }
}
