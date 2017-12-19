using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsGame1
{
    public class DrawPlayfield
    {
        private Coordinates position;

        internal DrawPlayfield(IPositionalRenderer renderer,Coordinates position)
        {
            this.Position = position;
        }

        internal Coordinates Position
        {
            get;
            set;
        }

        internal void Drawing(IPositionalRenderer renderer)
        {
            Coordinates drawLine = new Coordinates(Position.X, Position.Y);

            for (int i = 0; i < Console.BufferHeight ; i++)
                renderer.WriteAtPosition(new Coordinates(Constants.Playfieldsize, drawLine.Y++), '|');
          
        }

    }
}
