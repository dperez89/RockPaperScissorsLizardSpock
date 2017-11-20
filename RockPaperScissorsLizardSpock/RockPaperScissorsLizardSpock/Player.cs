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
        public int score = 0;
        public string name;
        public string move;

        //constructor
        public Player()
        {

        }

        //methods
        public virtual void SelectMove(UI userInterface, Game game1)
        {
            userInterface.DisplayPlayerMoveChoices(name);
        }
    }
}
