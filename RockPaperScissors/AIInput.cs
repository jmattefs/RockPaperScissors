using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class AIInput
    {
        Random random = new Random();
        public static string result;
        public string getCompChoice()
        {
            int choice = random.Next(1, 6);
            string result = "";
            if (choice == 1)
            {
                result = "rock";
            } else if (choice == 2)
            {
                result = "paper";
            } else if (choice == 3)
            {
                result = "scissors";
            } else if (choice == 4)
            {
                result = "lizard";
            } else if (choice == 5)
            {
                result = "Spock";
            }
            return result;
            
        }
    }
}
