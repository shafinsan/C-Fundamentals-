using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] store = { "rock", "paper", "scissors" };
            Random random=new Random();
            bool value = true;
            while (value)
            {
                Console.WriteLine("1.rock 2.paper 3.scissors");
                Console.Write("Enter the number you selected :");
                string p1 = store[Convert.ToInt32(Console.ReadLine())-1];
                string computer = store[random.Next(0, 4)];
                if ((p1=="paper" && computer=="rock") || (p1=="scissors" && computer=="paper") || (p1=="rock" && computer == "scissors"))
                {
                    Console.WriteLine("You win");
                }
                else if((p1 == "rock" && computer == "paper") || (p1 == "paper" && computer == "scissors") || (p1 == "scissors" && computer == "rock"))
                {
                    Console.WriteLine("Computer win");
                }
                else
                {
                    Console.WriteLine("Match Draw");
                }
                Console.Write("if you want to continue the game press 's' or stop the game press 'a' :");
                string decision=Console.ReadLine();
                if (decision == "s")
                {
                    value = false;
                }
                else
                {
                    value=true;
                }
            }
        }
    }
}
