using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Computer : Player
    {
        //member variables

        //constructor
        public Computer(int score, string name)
        {
       
        }
        //member methods
        public override string SelectMove(UI userInterface)
        {
            Console.WriteLine("The computer is selecting a move!");
            //move = userinterface.displayplayermovechoices();
            //if (move == "false")
            //{
            //    selectmove(userinterface);
            //}
            //return move;
            return move;
        }
    }
}
