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

            if (((humanChoice == "rock") && (computerChoice == "scissors")) || ((humanChoice == "paper") && (computerChoice == "rock")) || ((humanChoice == "scissors") && (computerChoice == "paper")) || ((humanChoice == "rock") && (computerChoice == "lizard")) || ((humanChoice == "paper") && (computerChoice == "Spock")) || ((humanChoice == "scissors") && (computerChoice == "lizard")) || ((humanChoice == "lizard") && (computerChoice == "Spock")) || ((humanChoice == "lizard") && (computerChoice == "paper")) || ((humanChoice == "Spock") && (computerChoice == "scissors")) || ((humanChoice == "Spock") && (computerChoice == "rock")))
            {
                Console.WriteLine(human + " wins.");
            }
            else if (((humanChoice == "rock") && (computerChoice == "paper")) || ((humanChoice == "paper") && (computerChoice == "scissors")) || ((humanChoice == "scissors") && (computerChoice == "rock")) || ((humanChoice == "lizard") && (computerChoice == "rock")) || ((humanChoice == "Spock") && (computerChoice == "paper")) || ((humanChoice == "lizard") && (computerChoice == "scissors")) || ((humanChoice == "Spock") && (computerChoice == "lizard")) || ((humanChoice == "paper") && (computerChoice == "lizard")) || ((humanChoice == "scissors") && (computerChoice == "Spock")) || ((humanChoice == "rock") && (computerChoice == "Spock")))
            {
                Console.WriteLine("The computer wins.");
            }
            else if (humanChoice == computerChoice)
            {
                Console.WriteLine("Tie game. Reshoot.");
            }
        }
        public void checkWinnerH2H(string humanChoice, string humanTwoChoice)
        {
            string human = StartGame.playerOneName;
            string humanTwo = StartGame.playerTwoName;

            if (((humanChoice == "rock") && (humanTwoChoice == "scissors")) || ((humanChoice == "paper") && (humanTwoChoice == "rock")) || ((humanChoice == "scissors") && (humanTwoChoice == "paper")) || ((humanChoice == "rock") && (humanTwoChoice == "lizard")) || ((humanChoice == "paper") && (humanTwoChoice == "Spock")) || ((humanChoice == "scissors") && (humanTwoChoice == "lizard")) || ((humanChoice == "lizard") && (humanTwoChoice == "Spock")) || ((humanChoice == "lizard") && (humanTwoChoice == "paper")) || ((humanChoice == "Spock") && (humanTwoChoice == "scissors")) || ((humanChoice == "Spock") && (humanTwoChoice == "rock"))) 
            {
                Console.WriteLine(human + " wins.");
            }
            else if (((humanChoice == "rock") && (humanTwoChoice == "paper")) || ((humanChoice == "paper") && (humanTwoChoice == "scissors")) || ((humanChoice == "scissors") && (humanTwoChoice == "rock")) || ((humanChoice == "lizard") && (humanTwoChoice =="rock")) || ((humanChoice == "Spock") && (humanTwoChoice=="paper")) || ((humanChoice == "lizard") && (humanTwoChoice== "scissors")) || ((humanChoice == "Spock") && (humanTwoChoice=="lizard")) || ((humanChoice == "paper") && (humanTwoChoice=="lizard")) || ((humanChoice == "scissors") && (humanTwoChoice== "Spock")) || ((humanChoice == "rock") && (humanTwoChoice == "Spock")))
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
