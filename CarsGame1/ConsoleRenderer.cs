using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsGame1
{
    class ConsoleRenderer : IPositionalRenderer
    {
        public void WriteAtPosition(Coordinates coordinate, object input)
        {
            Console.SetCursorPosition(coordinate.X, coordinate.Y);
            Console.Write(input);
        }
    }
}
