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
        Player player1;
        Player player2;
        string userInput;
        string player1Move;
        string player2Move;

        //constructor
        public Game()
        {

        }

        //methods
        public void StartGame(Player player1, Player player2, UI userInterface)
        {
            player1Move = player1.SelectMove(userInterface);
            player2Move = player2.SelectMove(userInterface);

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
                GeneratePlayers(userInput, userInterface);
            }
            else if(userInput == "computer")
            {
                Console.WriteLine("You have chosen computer!");
                GeneratePlayers(userInput, userInterface);
            }
            else
            {
                Console.WriteLine("You have made an invalid option, please try again!");
                GetNumberOfPlayers(userInterface);
            }
        }
        private void GeneratePlayers(string userInput, UI userInterface)
        {
            if (userInput == "friend")
            {
                player1 = new Human(0, "Player 1");
                player2 = new Human(0, "Player 2");
                StartGame(player1, player2, userInterface);
            }
            else if (userInput == "computer")
            {
                player1 = new Human(0, "Player 1");
                player2 = new Computer(0, "The Computah");
                StartGame(player1, player2, userInterface);
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
