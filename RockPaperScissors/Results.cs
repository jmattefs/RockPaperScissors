using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Results
    {
        public string resultCheckAI(string human, string ai)
        {
            string player = StartGame.playerOneName;
            string computer = "The Computer ";

            if (human == "rock" && ai == "scissors")
            {
                string resultAIw;
                resultAIw = player + " beat " + computer;
                return resultAIw;

            }
            else if (human == "rock" && ai == "paper")
            {
                string resultAIl;
                resultAIl = computer + " beat " + player;
                return resultAIl;
            }
            else if (human == "rock" && ai == "lizard")
            {
                string resultAIw;
                resultAIw = player + " beat " + computer;
                return resultAIw;
            }
            else if (human == "rock" && ai == "Spock")
            {
                string resultAIl;
                resultAIl = computer + " beat " + player;
                return resultAIl;
            }
            else if (human == "paper" && ai == "rock")
            {
                string resultAIw;
                resultAIw = player + " beat " + computer;
                return resultAIw;
            }
            else if (human == "paper" && ai == "scissors")
            {
                string resultAIl;
                resultAIl = computer + " beat " + player;
                return resultAIl;
            }
            else if (human == "paper" && ai == "lizard")
            {
                string resultAIl;
                resultAIl = computer + " beat " + player;
                return resultAIl;
            }
            else if (human == "paper" && ai == "Spock")
            {
                string resultAIw;
                resultAIw = player + " beat " + computer;
                return resultAIw;
            }
            else if (human == "scissors" && ai == "rock")
            {
                string resultAIl;
                resultAIl = computer + " beat " + player;
                return resultAIl;
            }
            else if (human == "scissors" && ai == "paper")
            {
                string resultAIw;
                resultAIw = player + " beat " + computer;
                return resultAIw;
            }
            else if (human == "scissors" && ai == "lizard")
            {
                string resultAIw;
                resultAIw = player + " beat " + computer;
                return resultAIw;
            }
            else if (human == "scissors" && ai == "Spock")
            {
                string resultAIl;
                resultAIl = computer + " beat " + player;
                return resultAIl;
            }
            else if (human == "lizard" && ai == "rock")
            {
                string resultAIl;
                resultAIl = computer + " beat " + player;
                return resultAIl;
            }
            else if (human == "lizard" && ai == "paper")
            {
                string resultAIw;
                resultAIw = player + " beat " + computer;
                return resultAIw;
            }
            else if (human == "lizard" && ai == "scissors")
            {
                string resultAIl;
                resultAIl = computer + " beat " + player;
                return resultAIl;
            }
            else if (human == "lizard" && ai == "Spock")
            {
                string resultAIw;
                resultAIw = player + " beat " + computer;
                return resultAIw;
            }
            else if (human == "Spock" && ai == "rock")
            {
                string resultAIw;
                resultAIw = player + " beat " + computer;
                return resultAIw;
            }
            else if (human == "Spock" && ai == "paper")
            {
                string resultAIl;
                resultAIl = computer + " beat " + player;
                return resultAIl;
            }
            else if (human == "Spock" && ai == "scissors")
            {
                string resultAIw;
                resultAIw = player + " beat " + computer;
                return resultAIw;
            }
            else if (human == "Spock" && ai == "lizard")
            {
                string resultAIl;
                resultAIl = computer + " beat " + player;
                return resultAIl;
            }
            else
            {
                return "";
            }
        }
        public string resultCheckH2H(string human, string humantwo)
        {
            string player = StartGame.playerOneName;
            string playerTwo = StartGame.playerTwoName;

            if (human == "rock" && humantwo == "scissors")
            {
                string resultP1w;
                resultP1w = player + " beat " + playerTwo;
                return resultP1w;

            }
            else if (human == "rock" && humantwo == "paper")
            {
                string resultAIl;
                resultAIl = playerTwo + " beat " + player;
                return resultAIl;
            }
            else if (human == "rock" && humantwo == "lizard")
            {
                string resultP1w;
                resultP1w = player + " beat " + playerTwo;
                return resultP1w;
            }
            else if (human == "rock" && humantwo == "Spock")
            {
                string resultAIl;
                resultAIl = playerTwo + " beat " + player;
                return resultAIl;
            }
            else if (human == "paper" && humantwo == "rock")
            {
                string resultP1w;
                resultP1w = player + " beat " + playerTwo;
                return resultP1w;
            }
            else if (human == "paper" && humantwo == "scissors")
            {
                string resultAIl;
                resultAIl = playerTwo + " beat " + player;
                return resultAIl;
            }
            else if (human == "paper" && humantwo == "lizard")
            {
                string resultAIl;
                resultAIl = playerTwo + " beat " + player;
                return resultAIl;
            }
            else if (human == "paper" && humantwo == "Spock")
            {
                string resultP1w;
               resultP1w = player + " beat " + playerTwo;
                return resultP1w;
            }
            else if (human == "scissors" && humantwo == "rock")
            {
                string resultAIl;
                resultAIl = playerTwo + " beat " + player;
                return resultAIl;
            }
            else if (human == "scissors" && humantwo == "paper")
            {
                string resultP1w;
                resultP1w = player + " beat " + playerTwo;
                return resultP1w;
            }
            else if (human == "scissors" && humantwo == "lizard")
            {
                string resultP1w;
                resultP1w = player + " beat " + playerTwo;
                return resultP1w;
            }
            else if (human == "scissors" && humantwo == "Spock")
            {
                string resultAIl;
                resultAIl = playerTwo + " beat " + player;
                return resultAIl;
            }
            else if (human == "lizard" && humantwo == "rock")
            {
                string resultAIl;
                resultAIl = playerTwo + " beat " + player;
                return resultAIl;
            }
            else if (human == "lizard" && humantwo == "paper")
            {
                string resultP1w;
                resultP1w = player + " beat " + playerTwo;
                return resultP1w;
            }
            else if (human == "lizard" && humantwo == "scissors")
            {
                string resultAIl;
                resultAIl = playerTwo + " beat " + player;
                return resultAIl;
            }
            else if (human == "lizard" && humantwo == "Spock")
            {
                string resultP1w;
                resultP1w = player + " beat " + playerTwo;
                return resultP1w;
            }
            else if (human == "Spock" && humantwo == "rock")
            {
                string resultP1w;
                resultP1w = player + " beat " + playerTwo;
                return resultP1w;
            }
            else if (human == "Spock" && humantwo == "paper")
            {
                string resultAIl;
                resultAIl = playerTwo + " beat " + player;
                return resultAIl;
            }
            else if (human == "Spock" && humantwo == "scissors")
            {
                string resultP1w;
                resultP1w = player + " beat " + playerTwo;
                return resultP1w;
            }
            else if (human == "Spock" && humantwo == "lizard")
            {
                string resultAIl;
                resultAIl = playerTwo + " beat " + player;
                return resultAIl;
            }
            else
            {
                return "";
            }
        }
    }
}
