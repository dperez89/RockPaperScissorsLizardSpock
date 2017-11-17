using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Human : Player
    {
        //member variables
        //constructor
        public Human(int score, string name)
        {
            
        }
        //member methods
        public override string SelectMove(UI userInterface)
        {
            move = userInterface.DisplayPlayerMoveChoices();
            return move;
        }
    }
}
