using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarsGame1
{
    class Program
    { 

        static void Main(string[] args)
        {
            Console.BufferWidth = Console.WindowWidth = Constants.ConsoleWidth;
            Console.BufferHeight = Console.WindowHeight = Constants.ConsoleHeight;
            Console.CursorVisible = false;
         
            IPositionalRenderer renderer = new ConsoleRenderer();
            IGameEngine carsEngine = new CarsEngine(renderer);

            carsEngine.StartGame();
          
        }
        
       
    }
}
