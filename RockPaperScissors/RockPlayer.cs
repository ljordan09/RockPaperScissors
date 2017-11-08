using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RockPlayer: Player
    {

        public RockPlayer(string _name)
            : base(_name) { }

        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.rock;
        }
    }
}
