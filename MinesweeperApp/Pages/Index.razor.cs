using ImTools;
using Microsoft.AspNetCore.Components;
using MinesweeperApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace MinesweeperApp.Pages
{
    public partial class Index
    {
        static Board board = new Board(8);
        static Cell cell;
        static List<Cell> cells = new List<Cell>();
        private static System.Timers.Timer aTimer { get; set; }
        static int seconds;
        static int minutes;
        protected override Task OnInitializedAsync()
        {
            
            LoadCells();

            aTimer = new System.Timers.Timer(1000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += TimerOnElapsed;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
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
                
                board.RevealAllMines();

                aTimer.Stop();
                aTimer.Dispose();
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


        private void TimerOnElapsed(Object source, ElapsedEventArgs e)
        {
            seconds++;
            if(seconds > 59)
            {
                minutes++;
                seconds = 0;
            }
            StateHasChanged();
        }
       
    }
}
