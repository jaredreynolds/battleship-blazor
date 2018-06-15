using System;
using System.Linq;
using Battleship.Services;
using Microsoft.AspNetCore.Blazor.Services;
using Microsoft.AspNetCore.WebUtilities;

namespace Battleship 
{
    public class Pacman
    {
        private PacmanBoard pacmanBoard;

        public int XPosition { get; set; } = 1;
        public int YPosition { get; set; } = 1;

        public Pacman()
        {
            pacmanBoard = new PacmanBoard();
            Center();
        }

        private void Center()
        {
            XPosition = pacmanBoard.MaxColumns / 2;
            YPosition = pacmanBoard.MaxRows / 2;
        }

        public void MoveUp()
        {
            if (pacmanBoard.IsNotTopBoundary(YPosition))
            {
                YPosition++;
            }
            else
            {
                YPosition = 1;
            }
        }

        public void MoveDown()
        {
            if (pacmanBoard.IsNotBottomBoundary(YPosition))
            {
                YPosition--;
            }
            else
            {
                YPosition = pacmanBoard.MaxRows;
            }
        }

        public void MoveRight()
        {
            if (pacmanBoard.IsNotRightBoundary(XPosition))
            {
                XPosition++;
            }
            else
            {
                XPosition = 1;
            }
        }

        public void MoveLeft()
        {
            if (pacmanBoard.IsNotLeftBoundary(XPosition))
            {
                XPosition--;
            }
            else
            {
                XPosition = pacmanBoard.MaxColumns;
            }
        }
    }
}
