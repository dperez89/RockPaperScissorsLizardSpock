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
        string roundWinner;

        //constructor
        public Game()
        {

        }

        //methods
        public void PlayRound(Player player1, Player player2, UI userInterface)

        {
            player1Move = GetResolvedMoveChoices(player1.SelectMove(userInterface));
            player2Move = GetResolvedMoveChoices(player2.SelectMove(userInterface));
            userInterface.DisplayPlayerMoves(player1Move, player2Move);
            roundWinner = GetRoundWinner(player1Move, player2Move, player1, player2, roundWinner);
            SetWinnerScore(roundWinner, player1, player2);
            Console.WriteLine(roundWinner + " wins!");
            userInterface.DisplayPlayerScores(player1, player2);
            PlayRound(player1, player2, userInterface);
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
                PlayRound(player1, player2, userInterface);
            }
            else if (userInput == "computer")
            {
                player1 = new Human(0, "Player 1");
                player2 = new Computer(0, "The Computah");
                PlayRound(player1, player2, userInterface);
            }

        }
        private string GetResolvedMoveChoices(string playerMove)
        {
            switch(playerMove)
            {
                case "q":
                    playerMove = "Rock";
                    break;

                case "w":
                    playerMove = "Paper";
                    break;

                case "e":
                    playerMove = "Scissors";
                    break;

                case "r":
                    playerMove = "Lizard";
                    break;

                case "t":
                    playerMove = "Spock";
                    break;
            }
            return playerMove;
        }
        private string GetRoundWinner(string player1Move, string player2Move, Player player1, Player player2, string roundWinner)
        {

            if (player1Move == player2Move)
            {
                roundWinner = "Tie";
                return roundWinner;
            }
            else if (player1Move == "Rock")
            {
                if (player2Move == "Lizard" || player2Move == "Scissors")
                {
                    roundWinner = player1.name;
                    return roundWinner;   
                }
            }
            else if (player1Move == "Paper")
            {
                if (player2Move == "Rock" || player2Move == "Spock")
                {
                    roundWinner = player1.name;
                    return roundWinner;
                }
            }
            else if (player1Move == "Scissors")
            {
                if (player2Move == "Paper" || player2Move == "Lizard")
                {
                    roundWinner = player1.name;
                    return roundWinner;
                }
            }
            else if (player1Move == "Lizard")
            {
                if (player2Move == "Paper" || player2Move == "Spock")
                {
                    roundWinner = player1.name;
                    return roundWinner;
                }
            }
            else if (player1Move == "Spock")
            {
                if (player2Move == "Scissors" || player2Move == "Rock")
                {
                    roundWinner = player1.name;
                    return roundWinner;
                }
            }           
            roundWinner = player2.name;
            return roundWinner;                       
        }
        private void SetWinnerScore(string roundWinner, Player player1, Player player2)
        {
            if(roundWinner == player1.name)
            {
                player1.score += 1;
            }
            else if(roundWinner == player2.name)
            {
                player2.score += 1;
            }
            else if(roundWinner == "Tie")
            {

            }
        }
    }
}
