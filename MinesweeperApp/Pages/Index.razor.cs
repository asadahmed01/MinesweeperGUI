using ImTools;
using MinesweeperApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinesweeperApp.Pages
{
    public partial class Index
    {
        static Board board = new Board(8);
        static Cell cell;
        static List<Cell> cells = new List<Cell>();

        private string message;
        protected override Task OnInitializedAsync()
        {
            
            LoadCells();
            return base.OnInitializedAsync();
        }
        public bool IsTaskRunning { get; set; }
        

        void Name(Cell cell)
        {
            //IsTaskRunning = true;
            int x = cell.Rows;
            int y = cell.Columns;

            if (cell.IsLive)
            {
                message = "You Lost!";
                board.RevealAllMines();
                return;
            }
            board.Floodfill(x, y);
            
        }

        private void LoadCells()
        {
            board.SetupLiveNeihbors();
            for (int i = 0; i < board.Size; i++)
            {
                for (int j = 0; j < board.Size; j++)
                {
                    int x = i;
                    int y = j;
                    cell = board.Grid[x, y];
                    board.CalculateLiveNeighbors(cell);
                    cells.Add(cell);
                }
            }
        }


        
    }
}
