using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgAdventure.Utilities
{
    public struct PrintCoordinates
    {
        public PrintCoordinates(int outputRow, int outputCol)
        {
            this.OutputRow = outputRow;
            this.OutputCol = outputCol;
        }

        public int OutputRow { get; set; }
        public int OutputCol { get; set; }
    }
}
