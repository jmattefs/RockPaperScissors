using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors;

namespace RockPaperScissors
{
    public class Game
    {
        public StartGame startGame;
        public HumanInput humanInput;
        public AIInput aiInput;
        
        public HumanInputTwo humanInputTwo;
        public WinCheck winCheck;
      
        

        public Game()
        {
            startGame = new StartGame();
            humanInput = new HumanInput();
            
            aiInput = new AIInput();
            
            winCheck = new WinCheck();
            

            humanInputTwo = new HumanInputTwo();

            
           
        }
    }
}
