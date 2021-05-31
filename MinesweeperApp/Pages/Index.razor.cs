using ImTools;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
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
        static int clicks;
        bool IsDisabled = false;
        bool onrightClick = false;
        private string gameEnd;
        

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
       
        void HandleClick(Cell cell)
        {
            clicks++;
            int x = cell.Rows;
            int y = cell.Columns;

            if (cell.IsLive)
            {
                
                board.RevealAllMines();
                IsDisabled = true;
                gameEnd = "Game Over!";
                aTimer.Stop();
                aTimer.Dispose();
                //return;
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

        protected override void OnAfterRender(bool firstRender)
        {
            if (board.isAllRevealed(cells))
            {
                Console.WriteLine("all revealed");
            }
            base.OnAfterRender(firstRender);
        }


       void flagBtn(Cell cell)
        {
            board.RightClicked(cell);
            
        }

        private void Refresh()
        {
            NavigationManager.NavigateTo("/", true);
        }
    }
}
