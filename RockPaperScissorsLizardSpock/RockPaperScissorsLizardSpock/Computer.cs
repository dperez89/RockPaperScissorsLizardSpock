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
        Random random = new Random();
        private int randomNumber;

        //constructor
        public Computer(int score, string name)
        {
            this.name = name;
                
        }
        //member methods
        public override void SelectMove(UI userInterface, Game game1)
        {
            DisplayComputerIsChoosing();
            randomNumber = random.Next(0, 5);
            switch (randomNumber)
            {
                case 0:
                    move = "q";
                    break;

                case 1:
                    move = "w";
                    break;

                case 2:
                    move = "e";
                    break;

                case 3:
                    move = "r";
                    break;

                case 4:
                    move = "t";
                    break;

            }
        }
        private void DisplayComputerIsChoosing()
        {
            Console.Clear();
            Console.WriteLine("The computer will now make its selection. Good luck!");
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
