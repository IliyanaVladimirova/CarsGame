using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsGame1
{
    class Coordinates : IEquatable<Coordinates>
    {
        public Coordinates(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X
        {
            get;
            set;
        }
        public int Y
        {
            get;
            set;
        }

        public bool Equals(Coordinates other)
        {
            if (other.X == this.X && other.Y == this.Y)
            {
                return true;
            }
            return false;
        }
    }
}
