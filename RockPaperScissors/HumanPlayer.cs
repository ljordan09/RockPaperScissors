using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class HumanPlayer : Player
    {
        

        public HumanPlayer(string _name)
            : base(_name) { }

        public override Roshambo GenerateRoshambo()
        {
            
                Console.WriteLine("Select Rock Paper or Scissors (R/P/S)?");
                string input2 = Console.ReadLine().ToUpper();

                if (input2 == "R")
                {
                    return Roshambo.rock;
                }
                else if (input2 == "P")
                {
                    return Roshambo.paper;
                }
                else if (input2 == "S")
                {
                    return Roshambo.scissors;
                }
                else
                {
                    Console.Write("I'm sorry, that was not a valid input. Please try again. (R / P / S)\n");
                    
                    return GenerateRoshambo();
                   
                }

            

        }
        
    }
}
