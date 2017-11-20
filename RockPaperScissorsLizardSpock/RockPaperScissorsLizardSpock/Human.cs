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
        bool isChoiceValid;
        //constructor
        public Human(int score, string name)
        {
            this.name = name;
        }
        //member methods
        public override void SelectMove(UI userInterface, Game game1)
        {
            userInterface.DisplayPlayerMoveChoices(name);
            move = userInterface.GetUserInput();
            isChoiceValid = game1.ValidatePlayerMoveChoice(move, isChoiceValid, userInterface);
            if (!isChoiceValid) 
            {
                SelectMove(userInterface, game1);
            }
            Console.Clear();
        }
    }
}
