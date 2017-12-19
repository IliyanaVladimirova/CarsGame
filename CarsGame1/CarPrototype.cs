using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsGame1
{
    class CarPrototype 
    {
        public IPositionalRenderer renderer;

        public CarPrototype(string symbol,IPositionalRenderer renderer,Directions direction,Coordinates position)
        {   
            this.Symbol = symbol;
            this.renderer = renderer;
            this.Position = position;
            this.Direction = direction;
        }

        public CarPrototype(string symbol, IPositionalRenderer renderer, Coordinates position)
        {
            this.Symbol = symbol;
            this.renderer = renderer;
            this.Position = position;
        }
        public Coordinates Position
        {
            get;
            set;
        }
        public string Symbol
        {
            get;
            set;
        }
        public Directions Direction
        { 
            get;
            set;
        }
        public void Move()
        {
            this.Position = this.Direction.MoveToNewPostition(this.Position);
        }
        public void ChangeDirection(DirectionsNames direction)
        {
            this.Direction.ChangeDIrection(direction);
        }

        public void Print()
        {
            renderer.WriteAtPosition(this.Position, this.Symbol);
        }

    }
}
