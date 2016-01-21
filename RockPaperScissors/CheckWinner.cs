using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors;


namespace RockPaperScissors
{
    public class CheckWinner
    {

        public void checkWinnerAi(string humanChoice, string computerChoice)
        {
            string human = StartGame.playerOneName;
            
            if(((humanChoice == "rock") && (computerChoice == "scissors")) || ((humanChoice == "paper") && (computerChoice == "rock")) || ((humanChoice == "scissors") && (computerChoice == "paper")))
            {
                Console.WriteLine(human + " wins.");
            } else if (((humanChoice == "rock") && (computerChoice == "paper"))||((humanChoice == "paper") && (computerChoice == "scissors")) || ((humanChoice == "scissors") && (computerChoice == "rock")))
            {
                Console.WriteLine("The computer wins.");
            } else if (humanChoice == computerChoice)
            {
                Console.WriteLine("Tie game. Reshoot.");
            }
        }
        public void checkWinnerH2H(string humanChoice, string humanTwoChoice)
        {
            string human = StartGame.playerOneName;
            string humanTwo = StartGame.playerTwoName;

            if (((humanChoice == "rock") && (humanTwoChoice == "scissors")) || ((humanChoice == "paper") && (humanTwoChoice == "rock")) || ((humanChoice == "scissors") && (humanTwoChoice == "paper")))
            {
                Console.WriteLine(human + " wins.");
            }
            else if (((humanChoice == "rock") && (humanTwoChoice == "paper")) || ((humanChoice == "paper") && (humanTwoChoice == "scissors")) || ((humanChoice == "scissors") && (humanTwoChoice == "rock")))
            {
                Console.WriteLine(humanTwo + " wins.");
            }
            else if (humanChoice == humanTwoChoice)
            {
                Console.WriteLine("Tie game. Reshoot.");
            }
        }
    }
}
