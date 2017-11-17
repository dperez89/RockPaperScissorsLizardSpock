using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        //member variable
        //Player player1 = new Player();
        //Player player2 = new Player();
        Player player1;
        Player player2;
        string userInput;

        //constructor
        public Game()
        {

        }

        //methods
        public void StartGame(UI userInterface)
        {

        }
        public void EndGame()
        {

        }
        public void GetNumberOfPlayers(UI userInterface)
        {
            userInput = userInterface.DisplayNumberOfPlayersRequest();
            if(userInput == "friend")
            {
                Console.WriteLine("You have chosen friend!");
                GeneratePlayers(userInput);
            }
            else if(userInput == "computer")
            {
                Console.WriteLine("You have chosen computer!");
                GeneratePlayers(userInput);
            }
            else
            {
                Console.WriteLine("You have made an invalid option, please try again!");
                GetNumberOfPlayers(userInterface);
            }
        }
        private void GeneratePlayers(string userInput)
        {
            if (userInput == "friend")
            {
                player1 = new Human();
                player2 = new Human();
            }
            else if (userInput == "computer")
            {
                player1 = new Human();
                player2 = new Computer();
            }

        }
        private void EvaluateRolls()
        {

        }
        private void KeepScore()
        {

        }
    }
}
