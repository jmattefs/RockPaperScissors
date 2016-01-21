using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class AIInput
    {
        Random random = new Random();

        public string getCompChoice()
        {
            int choice = random.Next(1, 4);
            string result = null;
            if (choice == 1)
            {
                result = "rock";
            } else if (choice == 2)
            {
                result = "paper";
            } else if (choice == 3)
            {
                result = "scissors";
            }
            return result;
            
        }
    }
}
