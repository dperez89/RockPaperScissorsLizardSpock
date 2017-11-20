using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class UI
    {
        //member variable
        string userInput;
        Game game1 = new Game();

        //constructor
        public UI()
        {

        }

        //methods
        public void DisplayMainMenu()
        {
            Console.WriteLine("Rock, Paper, Scissors, Lizard Spock");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Welcome to the game!");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("START",Environment.NewLine);
            Console.WriteLine("EXIT",Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            GetUserInput();

            if (userInput == "start")
            {
                game1.GetNumberOfPlayers(this);
            }
            else if (userInput == "exit")
            {
                DisplayExitMessage();
            }
            else
            {
                Console.WriteLine("Command not recognized, please try again!");
                Console.Clear();
                DisplayMainMenu();
            }

        }
        public string GetUserInput()
        {
            Console.WriteLine("What do you choose?:");
            userInput = Console.ReadLine().ToLower();
            return userInput;

        }
        public void DisplayRoundWinner(string roundWinner)
        {
            Console.WriteLine(roundWinner + " wins!");
        }
        public void DisplayPlayerSelectionChoice(string userInput)
        {
            if (userInput == "friend")
            {
                Console.WriteLine("You have chosen friend!");
                game1.GeneratePlayers(userInput, this);
            }
            else if (userInput == "computer")
            {
                Console.WriteLine("You have chosen computer!");
                game1.GeneratePlayers(userInput, this);
            }
            else
            {
                Console.WriteLine("You have made an invalid option, please try again!");
                DisplayPlayerSelectionChoice(userInput);
            }

        }
        public void DisplayPlayerScores(Player player1, Player player2)
        {
            Console.WriteLine("Player 1's score is now " + player1.score + "!");
            Console.WriteLine("Player 2's score is now " + player2.score + "!");
        }

        public void DisplayPlayerMoves(string player1Move, string player2Move)
        {
            Console.WriteLine("Player 1 rolled a " + player1Move + "!");
            Console.WriteLine("Player 2 rolled a " + player2Move + "!");
        }
        public string DisplayNumberOfPlayersRequest()
        {
            Console.WriteLine("Will you be playing against the COMPUTER or did you bring a FRIEND today?");
            userInput = GetUserInput();
            return userInput;
        }
        public string DisplayPlayerMoveChoices()
        {
            Console.WriteLine("Choose a move!");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("(Q) Rock");
            Console.WriteLine("(W) Paper");
            Console.WriteLine("(E) Scissors");
            Console.WriteLine("(R) Lizard");
            Console.WriteLine("(T) Spock");
            Console.WriteLine(Environment.NewLine);
            userInput = GetUserInput();
            if(userInput == "q" || userInput == "w" || userInput == "e" || userInput == "r" || userInput == "t")
            {
                return userInput;
            }
            else
            {
                Console.WriteLine("Selection not recognized, please try again!");
                userInput = "false";
                return userInput;
            }

        }
        private void DisplayGameResults()
        {

        }
        private void DisplayPlayerScore()
        {

        }
        private void DisplayExitMessage()
        {
            Console.WriteLine("Come back soon!");
        }
    }
}
