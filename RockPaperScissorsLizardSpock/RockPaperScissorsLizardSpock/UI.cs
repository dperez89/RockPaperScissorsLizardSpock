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
        public string DisplayNumberOfPlayersRequest()
        {
            Console.WriteLine("Will you be playing against the COMPUTER or did you bring a FRIEND today?");
            userInput = GetUserInput();
            return userInput;
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
