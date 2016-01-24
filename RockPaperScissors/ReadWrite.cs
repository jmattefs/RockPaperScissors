using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RockPaperScissors
{
    public class ReadWrite
    {
        public void writeTextToDocument() 
        {
            string [] names = { StartGame.playerOneName, StartGame.playerTwoName };

           File.AppendAllLines (@"c:\users\joseph\desktop\rockpaperscissors\rockpaperscissorsrepo\highscores.txt", names);

            int [] score = {}
           

        }
    }
}
 