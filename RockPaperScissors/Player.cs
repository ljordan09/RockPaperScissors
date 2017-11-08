using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    abstract class Player 
    {
        private string _name;
        private Roshambo _roRO;

        public Player(string _name)
        {
            this._name = _name;
        }
        public string _Name{ get { return _name; } set { _name = value; }}
        public Roshambo _RoRo{ get { return _roRO; }set { _roRO = value; }}

        public abstract Roshambo GenerateRoshambo();

        public override string ToString()
        {
            return $"{_name} has chosen {_roRO}";
        }
    }
}
