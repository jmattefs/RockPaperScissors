using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class HumanInput
    {
        static public string result;
        public string humanChoice()
        {
            string human = StartGame.playerOneName;
            string result = "";
            Console.WriteLine(human + "... rock, paper, or scissors?");
            string input = Console.ReadLine();

            if ((input == "rock")||(input == "Rock")){
                result = "rock";
            } else if ((input == "paper")||(input == "Paper"))
            {
                result = "paper";
            } else if ((input == "scissors")||(input == "Scissors"))
            {
                result = "scissors";
            }
            return result;
        }
        
    }
}
