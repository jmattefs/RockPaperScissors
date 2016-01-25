using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RockPaperScissors
{
    public class Program
    {
        public static void Main(string[] args)
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
                   
                    tie = game.winCheck.winCheckerAI(humanResult, aiResult);

                   string outcome = game.results.resultCheckAI(humanResult, aiResult);

                    game.readWrite.writeTextToDocument(outcome);

                    Console.WriteLine();


                }
                else if (type == "2")
                {
                    string humanResult = game.humanInput.humanChoice();
                    Console.Clear();
                    string humanResultTwo = game.humanInputTwo.humanChoiceTwo();
                    tie = game.winCheck.winCheckerH2H(humanResult, humanResultTwo);
                    string outcome = game.results.resultCheckAI(humanResult, humanResultTwo);

                    game.readWrite.writeTextToDocument(outcome);

                }
                else if (type == "3")
                {
                    game.startGame.start();
                }
            }
            


        }
    }
}
