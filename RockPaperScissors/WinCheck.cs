using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class WinCheck
    {
        Rock rock = new Rock();
        Paper paper = new Paper();
        Scissors scissors = new Scissors();
        Lizard lizard = new Lizard();
        Spock spock = new Spock();
        Score score = new Score();

        public bool winCheckerAI(string human, string ai)
        {
            string player = StartGame.playerOneName;

            if (human == "rock" && ai == "scissors")
            {
                rock.RockWinScissor();
                Console.WriteLine(player + " wins!");
                return true;
            }
            else if (human == "rock" && ai == "paper")
            {
                paper.PaperWinCover();
                Console.WriteLine(player + " loses!");
                return true;
            }
            else if (human == "rock" && ai == "lizard")
            {
                rock.RockWinLizard();
                Console.WriteLine(player + " wins!");
                return true;
            }
            else if (human == "rock" && ai == "Spock")
            {
                spock.SpockWinVapor();
                Console.WriteLine(player + " loses!");
                return true;
            }
            else if (human == "paper" && ai == "rock")
            {
                paper.PaperWinCover();
                Console.WriteLine(player + " wins!");
                return true;
            }
            else if (human == "paper" && ai == "scissors")
            {
                scissors.ScissorsWinCut();
                Console.WriteLine(player + " loses!");
                return true;
            }
            else if (human == "paper" && ai == "lizard")
            {
                lizard.LizardWinEat();
                Console.WriteLine(player + " loses!");
                return true;
            }
            else if (human == "paper" && ai == "Spock")
            {
                paper.PaperWinDisprove();
                Console.WriteLine(player + " wins!");
                return true;
            }
            else if (human == "scissors" && ai == "rock")
            {
                rock.RockWinScissor();
                Console.WriteLine(player + " loses!");
                return true;
            }
            else if (human == "scissors" && ai == "paper")
            {
                scissors.ScissorsWinCut();
                Console.WriteLine(player + " wins!");
                return true;
            }
            else if (human == "scissors" && ai == "lizard")
            {
                scissors.ScissorsWinDecap();
                Console.WriteLine(player + " wins!");
                return true;
            }
            else if (human == "scissors" && ai == "Spock")
            {
                spock.SpockWinSmash();
                Console.WriteLine(player + " loses!");
                return true;
            }
            else if (human == "lizard" && ai == "rock")
            {
                rock.RockWinLizard();
                Console.WriteLine(player + " loses!");
                return true;
            }
            else if (human == "lizard" && ai == "paper")
            {
                lizard.LizardWinEat();
                Console.WriteLine(player + " wins!");
                return true;
            }
            else if (human == "lizard" && ai == "scissors")
            {
                scissors.ScissorsWinDecap();
                Console.WriteLine(player + " loses!");
                return true;
            }
            else if (human == "lizard" && ai == "Spock")
            {
                lizard.LizardWinPoison();
                Console.WriteLine(player + " wins!");
                return true;
            }
            else if (human == "Spock" && ai == "rock")
            {
                spock.SpockWinVapor();
                Console.WriteLine(player + " wins!");
                return true;
            }
            else if (human == "Spock" && ai == "paper")
            {
                paper.PaperWinDisprove();
                Console.WriteLine(player + " loses!");
                return true;
            }
            else if (human == "Spock" && ai == "scissors")
            {
                spock.SpockWinSmash();
                Console.WriteLine(player + " wins!");
                return true;
            }
            else if (human == "Spock" && ai == "lizard")
            {
                lizard.LizardWinPoison();
                Console.WriteLine(player + " loses!");
                return true;
            }
            else
            {
                Console.WriteLine("Tie game. Reshoot");
                return false;
            }
        }


            public bool winCheckerH2H(string human, string humanTwo)
        {
            string player = StartGame.playerOneName;
            string playerTwo = StartGame.playerTwoName;

            if (human == "rock" && humanTwo == "scissors")
            {
                rock.RockWinScissor();
                Console.WriteLine(player + " wins!");
                return true;
            }
            else if (human == "rock" && humanTwo == "paper")
            {
                paper.PaperWinCover();
                Console.WriteLine(playerTwo + " wins!");
                return true;
            }
            else if (human == "rock" && humanTwo == "lizard")
            {
                rock.RockWinLizard();
                Console.WriteLine(player + " wins!");
                return true;
            }
            else if (human == "rock" && humanTwo == "Spock")
            {
                spock.SpockWinVapor();
                Console.WriteLine(playerTwo + " wins!");
                return true;
            }
            else if (human == "paper" && humanTwo == "rock")
            {
                paper.PaperWinCover();
                Console.WriteLine(player + " wins!");
                return true;
            }
            else if (human == "paper" && humanTwo == "scissors")
            {
                scissors.ScissorsWinCut();
                Console.WriteLine(playerTwo + " wins!");
                return true;
            }
            else if (human == "paper" && humanTwo == "lizard")
            {
                lizard.LizardWinEat();
                Console.WriteLine(playerTwo + " wins!");
                return true;
            }
            else if (human == "paper" && humanTwo == "Spock")
            {
                paper.PaperWinDisprove();
                Console.WriteLine(player + " wins!");
                return true;
            }
            else if (human == "scissors" && humanTwo == "rock")
            {
                rock.RockWinScissor();
                Console.WriteLine(playerTwo + " wins!");
                return true;
            }
            else if (human == "scissors" && humanTwo == "paper")
            {
                scissors.ScissorsWinCut();
                Console.WriteLine(player + " wins!");
                return true;
            }
            else if (human == "scissors" && humanTwo == "lizard")
            {
                scissors.ScissorsWinDecap();
                Console.WriteLine(player + " wins!");
                return true;
            }
            else if (human == "scissors" && humanTwo == "Spock")
            {
                spock.SpockWinSmash();
                Console.WriteLine(playerTwo + " wins!");
                return true;
            }
            else if (human == "lizard" && humanTwo == "rock")
            {
                rock.RockWinLizard();
                Console.WriteLine(playerTwo + " wins!");
                return true;
            }
            else if (human == "lizard" && humanTwo == "paper")
            {
                lizard.LizardWinEat();
                Console.WriteLine(player + " wins!");
                return true;
            }
            else if (human == "lizard" && humanTwo == "scissors")
            {
                scissors.ScissorsWinDecap();
                Console.WriteLine(playerTwo + " wins!");
                return true;
            }
            else if (human == "lizard" && humanTwo == "Spock")
            {
                lizard.LizardWinPoison();
                Console.WriteLine(player + " wins!");
                return true;
            }
            else if (human == "Spock" && humanTwo == "rock")
            {
                spock.SpockWinVapor();
                Console.WriteLine(player + " wins!");
                return true;
            }
            else if (human == "Spock" && humanTwo == "paper")
            {
                paper.PaperWinDisprove();
                Console.WriteLine(playerTwo + " wins!");
                return true;
            }
            else if (human == "Spock" && humanTwo == "scissors")
            {
                spock.SpockWinSmash();
                Console.WriteLine(player + " wins!");
                return true;
            }
            else if (human == "Spock" && humanTwo == "lizard")
            {
                lizard.LizardWinPoison();
                Console.WriteLine(playerTwo + " wins!");
                return true;
            }
            else
            {
                Console.WriteLine("Tie game. Reshoot");
                return false;
            }


        } 
    }
}
