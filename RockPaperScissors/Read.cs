using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RockPaperScissors
{
    public class Read
    {
        public void readTextFromDocument()
        {
            string scores;
            using (StreamReader reader = new StreamReader(@"c:\users\joseph\desktop\rockpaperscissors\rockpaperscissorsrepo\highscores.txt"))
            {
                scores = reader.ReadToEnd();
                reader.Close();
                reader.Dispose();
                Console.WriteLine(scores);

            }
        }
    }
}
