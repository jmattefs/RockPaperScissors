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
            string resultTwo = "";
            Console.WriteLine("Rock, paper, or scissors?");
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
            return resultTwo;
        }
    }
}
