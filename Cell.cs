using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardModel
{
    public class Cell
    {
        public int RowNumber { get; set; }
        public int ColumnNuber { get; set; }
        public bool CurrentOccupided { get; set; }
        public bool LegalNextMove { get; set; }

        // constructor that will initalized row and colums

        public Cell(int x, int y)
        {
            RowNumber = x;
            ColumnNuber = y;

        }
    }
}
