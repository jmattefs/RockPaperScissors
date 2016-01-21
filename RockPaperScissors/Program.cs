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
            game.startGame.start();
            string humanResult = game.humanInput.humanChoice();
            string aiResult = game.aiInput.getCompChoice();
            game.checkWinner.checkWinnerAi(humanResult, aiResult);


        }
    }
}
