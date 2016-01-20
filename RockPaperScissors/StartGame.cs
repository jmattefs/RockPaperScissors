using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class StartGame
    {
        string playerOneName;
        string playerTwoName;

        public StartGame(string playerOneName, string playerTwoName)
        {
            this.playerOneName = playerOneName;
            this.playerTwoName = playerTwoName;
        }
        
        public void start()
        {
            Console.WriteLine("How many people are playing? 1 or 2 ");
            string players = Console.ReadLine();
            if (players == "1")
            {
                setupOne();
            } else if (players == "2")
            {
                setupTwo();
            }

        }
        public void setupOne()
        {
            Console.WriteLine("What is your name?");
            playerOneName = Console.ReadLine();

        
        }
        public void setupTwo()
        {
            Console.WriteLine("What is player one's name?");
            playerOneName = Console.ReadLine();
            Console.WriteLine("What is player two's name?");
            playerTwoName = Console.ReadLine();
        }
    }
}
