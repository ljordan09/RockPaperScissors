using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RandPlayer : Player
    {
        Random rnd = new Random();

        public RandPlayer(string _name)
            : base(_name) { }

        public override Roshambo GenerateRoshambo()
        {
            int opp_move = rnd.Next(0,3);
            return (Roshambo)opp_move;

        }
    }
}
