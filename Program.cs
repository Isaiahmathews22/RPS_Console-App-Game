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
            Random random = new Random();
            int IsaiahScore = 0;
            int RonaldoScore = 0;

            Console.WriteLine("Welcome to the game of Rock, Paper, or Scissors");
        

            while (IsaiahScore != 3 && RonaldoScore != 3)
            {
                Console.WriteLine("IsaiahScore - " + IsaiahScore + " RonaldoScore " + RonaldoScore);
                Console.WriteLine("Please press 'R' for Rock, 'P' fpr Paper, and 'S' for Scissors");
                string IsaiahChoice = Console.ReadLine();

                int RonaldoChoice = random.Next(0, 3);

                if (RonaldoChoice == 0)
                {
                    Console.WriteLine("Ronaldo chooses rock.");

                    switch(IsaiahChoice)
                    {
                        case "r":
                            Console.WriteLine("Tie!");
                            break;

                        case "p":
                            Console.WriteLine("Isaiah wins this round!");
                            IsaiahScore++;
                            break;

                        case "s":
                            Console.WriteLine("Ronaldo wins this round");
                            RonaldoScore++;
                            break;
                        
                    }
                }

                else if (RonaldoChoice == 1)
                {
                    Console.WriteLine("Ronaldo chooses paper.");

                    switch(IsaiahChoice)
                    {
                        case "r":
                            Console.WriteLine("Ronaldo wins this round!");
                            RonaldoScore++;
                            break;

                        case "p":
                            Console.WriteLine("Tie!");
                            break;

                        case "s":
                            Console.WriteLine("Isaiah wins this round!");
                            IsaiahScore++;
                            break;

                    }
                }
                else if (RonaldoChoice == 2)
                {
                    Console.WriteLine("Ronaldo chooses scissors.");

                    switch(IsaiahChoice)
                    {
                        case "r":
                            Console.WriteLine("Isaiah wins this round!");
                            IsaiahScore++;
                            break;

                        case "p":
                            Console.WriteLine("Ronadlo wins this round!");
                            RonaldoScore++;
                            break;

                        case "s":
                            Console.WriteLine("Tie!");
                            break;
                    }
                }

            }

            if (IsaiahScore == 3)

            {
                Console.WriteLine("You win the game!");
            }

            else
            {
                Console.WriteLine("You lose the game!");
            }
        }
           
    }
}