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
        string gameWinner;
        int winningScore = 3;

        //constructor
        public Game()
        {

        }

        //methods
        public void PlayRound(Player player1, Player player2, UI userInterface, Game game1)
        {     
            player1.SelectMove(userInterface, game1);
            player1Move = GetResolvedMoveChoices(player1.move);
            player2.SelectMove(userInterface, game1);
            player2Move = GetResolvedMoveChoices(player2.move);
            userInterface.DisplayPlayerMoves(player1Move, player2Move);
            roundWinner = GetRoundWinner(player1Move, player2Move, player1, player2, roundWinner);
            SetWinnerScore(roundWinner, player1, player2);
            userInterface.DisplayRoundWinner(roundWinner);
            userInterface.DisplayPlayerScores(player1, player2);
            if(player1.score == winningScore || player2.score == winningScore)
            {
                Console.ReadKey();
                GetGameWinner(player1, player2, userInterface);
            }
            else
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Press any key to continue to the next round...");
                Console.ReadKey();
                Console.Clear();
                PlayRound(player1, player2, userInterface, game1);
            }
        }
        private void GetGameWinner(Player player1, Player player2, UI userInterface)
        {
            if (player1.score == winningScore)
            {
                gameWinner = player1.name;
            }
            else if (player2.score == winningScore)
            {
                gameWinner = player2.name;
            }
            userInterface.DisplayGameWinner(gameWinner);
        }
        public bool ValidatePlayerMoveChoice(string move, bool isChoiceValid, UI userInterface)
        {
            if (move == "q" || move == "w" || move == "e" || move == "r" || move == "t")
            {
                isChoiceValid = true;
                return isChoiceValid;
            }
            else
            {
                Console.WriteLine("Selection not recognized, please try again!");
                Console.ReadKey();
                isChoiceValid = false;
                return isChoiceValid;
            }
        }
        public void GetNumberOfPlayers(UI userInterface, Game game1)
        {
            userInterface.DisplayNumberOfPlayersRequest();
            userInput = userInterface.GetUserInput();
            userInput = userInterface.DisplayPlayerSelectionChoice(userInput);
            if(userInput == "error")
            {
                GetNumberOfPlayers(userInterface, game1);
            }
            else
            {
                GeneratePlayers(userInput, userInterface, game1);
            }            
        }
        public void GeneratePlayers(string userInput, UI userInterface, Game game1)
        {
            if (userInput == "friend")
            {
                player1 = new Human(0, "Player 1");
                player2 = new Human(0, "Player 2");
                PlayRound(player1, player2, userInterface, game1);
            }
            else if (userInput == "computer")
            {
                player1 = new Human(0, "Player 1");
                player2 = new Computer(0, "The Computah");
                PlayRound(player1, player2, userInterface, game1);
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
