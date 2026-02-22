using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Part02
{
    internal struct SeatLocation
    {
        public char rowChar;
        public int rowInt;

        public SeatLocation()
        {
            rowChar = 'A';
            rowInt = 1;
        }
        public override string ToString()
        {
            return $"{rowChar} - {rowInt}";
        }
    }
}
