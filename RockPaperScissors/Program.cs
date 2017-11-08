using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game of Rock Paper Scissors");


            Console.WriteLine("Please Enter Your Name: ");
            string input = Console.ReadLine();
            HumanPlayer user = new HumanPlayer(input);

            Player opponent = SelectOpponent();
            bool repeat = true;

            while (repeat)
            { 
            
                Roshambo userPick = user.GenerateRoshambo();
                Roshambo oppPick = opponent.GenerateRoshambo();

                string result = GetWinner(userPick, oppPick);

                Console.WriteLine($"{user._Name}: {userPick}\n{opponent._Name}: {oppPick}\n{result}");
                
            }
           

        }

        public static Player SelectOpponent()
        {
            Console.WriteLine("\nWould you like to play against RoRo or Randy? (1 or 2)?");
            int opponentNum;
            bool success = int.TryParse(Console.ReadLine().ToUpper(), out opponentNum);
            while (!success || opponentNum < 1 || opponentNum > 2)
            {
                Console.Write("Not a valid selection. Please try again: ");
                int.TryParse(Console.ReadLine(), out opponentNum);
                break;

            }


            if (opponentNum == 1)
            {
                Player opponent = new RandPlayer("Randy");
                return opponent;
            }
            else
            {
                Player opponent2 = new RockPlayer("RoRO");
                return opponent2;
            }
        }

        public static string GetWinner(Roshambo user, Roshambo opponenent)
        {

            if(user == Roshambo.rock)
            {
                if(opponenent == Roshambo.rock)
                {
                    return "Draw!";
                }
                else if (opponenent == Roshambo.paper)
                {
                    return "You lose!";
                }
                else if(opponenent == Roshambo.scissors)
                {
                    return "You Win!";
                }
                               
            }

            if (user == Roshambo.paper)
            {
                if(opponenent == Roshambo.rock)
                {
                    return "You Win!";
                }

                else if (opponenent == Roshambo.paper)
                {
                    return "Draw!";
                }

                if(opponenent == Roshambo.scissors)
                {
                    return "You lose!";
                }
            }

            if (user == Roshambo.scissors)
            {
                if(opponenent == Roshambo.rock)
                {
                    return "You lose!";

                }
                else if(opponenent == Roshambo.paper)
                {
                    return "You win!";
                }
                else if (opponenent == Roshambo.scissors)
                {
                    return "Draw!";
                }
                
            }
            return "";
            


        }

    }
}

