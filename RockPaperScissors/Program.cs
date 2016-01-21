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
            if(type == "1")
            {
                string humanResult = game.humanInput.humanChoice();
                string aiResult = game.aiInput.getCompChoice();
                game.checkWinner.checkWinnerAi(humanResult, aiResult);
            } else if (type == "2")
            {
                string humanResult = game.humanInput.humanChoice();
                string humanResultTwo = game.humanInputTwo.humanChoiceTwo();
                game.checkWinner.checkWinnerAi(humanResult, humanResultTwo);

            } else if (type == "3")
            {
                game.startGame.start();
            }

            


        }
    }
}
