using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RockPaperScissors
{
    public class Write
    {
       
        
        public void writeTextToDocument(string one) 
        {
          
           File.AppendAllText (@"c:\users\joseph\desktop\rockpaperscissors\rockpaperscissorsrepo\highscores.txt",one + Environment.NewLine);

        }
        
    }
}
 