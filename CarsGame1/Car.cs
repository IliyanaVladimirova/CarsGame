using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsGame1
{
    class Car : CarPrototype
    {
        private ConsoleColor Color;
        public ConsoleColor color 
        { 
            get;
            set;
        }

        public Car(string symbol, IPositionalRenderer renderer, Directions direction, Coordinates position,ConsoleColor color = ConsoleColor.Blue)
            : base(symbol, renderer, direction, position)
        {
            this.Color = color;
        }
        public Car(string symbol, IPositionalRenderer renderer, Coordinates position, ConsoleColor color = ConsoleColor.DarkMagenta)
        :base(symbol,renderer,position)
        {

        }

    }
}
