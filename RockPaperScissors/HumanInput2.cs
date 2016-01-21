using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class HumanInput2
    {
        public string humanChoiceTwo()
        {
            string result = null;
            Console.WriteLine("Rock, paper, or scissors?");
            string input = Console.ReadLine();

            if ((input == "rock") || (input == "Rock"))
            {
                result = "rock";
            }
            else if ((input == "paper") || (input == "Paper"))
            {
                result = "paper";
            }
            else if ((input == "scissors") || (input == "Scissors"))
            {
                result = "scissors";
            }
            return result;
        }

    }
}
