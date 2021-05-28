using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinesweeperApp.Models
{
    public class Cell
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public bool Visited { get; set; }
        public bool IsLive { get; set; }
        public int NumberOfNeighborsLve { get; set; }

        public Cell(int x, int y)
        {
            Rows = x;
            Columns = y;
        }
    }
}
