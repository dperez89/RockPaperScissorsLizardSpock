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
            GetMainMenuSelection();
        }
        private void GetMainMenuSelection()
        {
            userInput = GetUserInput();
            if(userInput == "start")
            {
                game1.GetNumberOfPlayers(this, game1);
            }
            else if (userInput == "exit")
            {
                DisplayExitMessage();
            }
            else
            {
                Console.WriteLine("Command not recognized, please try again!");
                Console.WriteLine("Press any key to continue..");
                Console.ReadKey();
                Console.Clear();
                DisplayMainMenu();
            }

        }
        public string GetUserInput()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("What do you choose?:");
            userInput = Console.ReadLine().ToLower();
            Console.WriteLine(Environment.NewLine);
            return userInput;

        }
        public void DisplayRoundWinner(string roundWinner)
        {
            Console.WriteLine(roundWinner + " wins!");
        }
        public string DisplayPlayerSelectionChoice(string userInput)
        {
            Console.Clear();
            if (userInput == "friend")
            {
                Console.WriteLine("Alright, glad to see you brought a friend with you today!");
                Console.WriteLine(Environment.NewLine);
                return userInput;
            }
            else if (userInput == "computer")
            {
                Console.WriteLine("Got it, the computer is all set to play with you today!");
                Console.WriteLine(Environment.NewLine);
                return userInput;
            }
            else
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("You have made an invalid option, please try again!");
                Console.WriteLine("Press any key to continue..");
                Console.ReadKey();
                userInput = "error";
                return userInput;
            }

        }
        public void DisplayPlayerScores(Player player1, Player player2)
        {
            Console.WriteLine("Player 1's score is now " + player1.score + "!");
            Console.WriteLine("Player 2's score is now " + player2.score + "!");
        }
        public void DisplayPlayerMoves(string player1Move, string player2Move)
        {
            Console.WriteLine("ROUND RESULTS");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Player 1 rolled a " + player1Move + "!");
            Console.WriteLine("Player 2 rolled a " + player2Move + "!");
        }
        public void DisplayNumberOfPlayersRequest()
        {
            Console.Clear();
            Console.WriteLine("Will you be playing against the COMPUTER or did you bring a FRIEND today?");
        }
        public void DisplayPlayerMoveChoices(string currentPlayerName)
        {
            Console.WriteLine(currentPlayerName + "'s Turn");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Choose a move!");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("(Q) Rock");
            Console.WriteLine("(W) Paper");
            Console.WriteLine("(E) Scissors");
            Console.WriteLine("(R) Lizard");
            Console.WriteLine("(T) Spock");            
        }
        public void DisplayGameWinner(string gameWinner)
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Congratulations to " + gameWinner + "! You are today's winner!");
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
            Console.Clear();
            DisplayMainMenu();

        }
        private void DisplayExitMessage()
        {
            Console.WriteLine("Come back soon!");
        }
    }
}
