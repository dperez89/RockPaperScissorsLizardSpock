using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
   class Player
    {
        //member variable
        protected int score = 0;
        protected string name;
        protected string move;

        //constructor
        public Player()
        {

        }

        //methods
        public virtual string SelectMove(UI userInterface)
        {
            userInterface.DisplayPlayerMoveChoices();


            return move;
        }
    }
}
