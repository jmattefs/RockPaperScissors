using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class HumanInputTwo
    {
        static public string resultTwo;
        public string humanChoiceTwo()
        {
            string humanTwo = StartGame.playerTwoName;
            string resultTwo = "";
            Console.WriteLine(humanTwo + "... rock, paper, scissors, lizard, or Spock?");
            string input = Console.ReadLine();

            if ((input == "rock") || (input == "Rock"))
            {
                resultTwo = "rock";
            }
            else if ((input == "paper") || (input == "Paper"))
            {
                resultTwo = "paper";
            }
            else if ((input == "scissors") || (input == "Scissors"))
            {
                resultTwo = "scissors";
            }
            else if ((input == "lizard") || (input == "Lizard"))
            {
                resultTwo = "lizard";
            }
            else if ((input == "spock") || (input == "Spock"))
            {
                resultTwo = "Spock";
            }
            return resultTwo;
        }
    }
}
