using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsGame1
{
    class Constants
    {
        public static readonly int ConsoleWidth = 63;
        public static readonly int ConsoleHeight = 45;
        public static readonly string Symbol = "@";
        public static readonly string OtherCarsSymbol = "#";
        public static readonly int Playfieldsize = 30;
        public static readonly Coordinates StartingPosition =  new Coordinates((Playfieldsize /2 ) ,ConsoleHeight-1);
    }
}
