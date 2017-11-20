using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class UI
    {
        string userInput;
        char moveInput;
        Game game1 = new Game();

        public UI()
        {

        }

        public void DisplayMainMenu()
        {
            Console.WriteLine("Rock, Paper, Scissors, Lizard Spock");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Welcome to the game!");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("The name of the game is the game itself! You can engage in a friendly match");
            Console.WriteLine("against a friend or you can try your luck against the computer itself.");
            Console.WriteLine("All it takes to win is to defeat the other player three times.");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("You can make your selections by entering in the KEYWORDS when prompted,");
            Console.WriteLine("or you can press the keys shown to make your move selections during the game.");
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
        public char getPlayerMove()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Make your move:");
            moveInput = Console.ReadKey(true).KeyChar;
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Move selected! Press any key to continue..");
            Console.ReadKey();
            return moveInput;
        }
        public string ResolvePlayerMoveInput(char moveInput, string move)
        {
            move = moveInput.ToString();
            return move;
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
        public void DisplayComputerIsChoosing()
        {
            Console.Clear();
            Console.WriteLine("The computer will now make its selection. Good luck!");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
            Console.Clear();
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
            Console.WriteLine("Player 1 used the move " + player1Move + "!");
            Console.WriteLine("Player 2 used the move " + player2Move + "!");
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
            Console.WriteLine("Congratulations to " + gameWinner + "! You have won the game!");
            Console.WriteLine(Environment.NewLine);
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
