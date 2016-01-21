using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class CheckWinner
    {

        public void checkWinnerAi(string humanChoice, string computerChoice)
        {
            if((humanChoice == "rock" && computerChoice == "scissors") || (humanChoice == "paper" && computerChoice == "rock") || (humanChoice == "scissors" && computerChoice == "paper"))
            {
                Console.WriteLine("The human wins.");
            } else if ((humanChoice == "rock" && computerChoice == "paper")||(humanChoice == "paper" && computerChoice == "scissors") || (humanChoice == "scissors" && computerChoice == "rock"))
            {
                Console.WriteLine("The computer wins.");
            } else if (humanChoice == computerChoice)
            {
                Console.WriteLine("Tie game. Reshoot.");
            }
        }
    }
}
