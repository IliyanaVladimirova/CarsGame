using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarsGame1
{
    class Directions
    {
        public DirectionsNames direction;

        public Coordinates MoveToNewPostition(Coordinates position)
        {
            Coordinates returnedPosition = new Coordinates(position.X, position.Y);
            switch (direction)
            {
                case DirectionsNames.Right:
                    returnedPosition.X++;
                    if (returnedPosition.X -1 >= Constants.Playfieldsize)
                    {
                        returnedPosition.X--;
                    }
                    break;
                case DirectionsNames.Left:
                    returnedPosition.X--;
                    if (returnedPosition.X + 1 <= 0)
                    {
                        returnedPosition.X++;
                    }
                    break;
                default:
                    break;
            }
            return returnedPosition;
        }

        public void ChangeDIrection(DirectionsNames direction)
        {
            this.direction = direction;
        }
    }
}
