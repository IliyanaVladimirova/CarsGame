using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsGame1
{
     interface IPositionalRenderer
    {
       void WriteAtPosition(Coordinates coordinate, object input);
    }
}
