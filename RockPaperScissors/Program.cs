using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            string type = game.startGame.start();
            bool tie  = false;

            while (!tie)
            {
                if (type == "1")
                {
                    string humanResult = game.humanInput.humanChoice();
                    string aiResult = game.aiInput.getCompChoice();
                    tie = game.checkWinner.checkWinnerAi(humanResult, aiResult);
                }
                else if (type == "2")
                {
                    string humanResult = game.humanInput.humanChoice();
                    string humanResultTwo = game.humanInputTwo.humanChoiceTwo();
                    tie = game.checkWinner.checkWinnerH2H(humanResult, humanResultTwo);

                }
                else if (type == "3")
                {
                    game.startGame.start();
                }
            }
            


        }
    }
}
