using System;
using System.Linq;
using Battleship.Services;
using Microsoft.AspNetCore.Blazor.Services;
using Microsoft.AspNetCore.WebUtilities;

namespace Battleship 
{
    public class PacmanBoard
    {
        public int MaxRows { get; set; } = 9;
        public int MaxColumns { get; set; } = 11;

        public PacmanBoard()
        {
        }

        public bool IsNotTopBoundary(int y)
        {
            if (y < MaxRows)
            {
                return true;
            }
            
            return false;
        }

        public bool IsNotBottomBoundary(int y)
        {
            if (y > 1)
            {
                return true;
            }
            
            return false;
        }


        public bool IsNotLeftBoundary(int x)
        {
            if (x > 1)
            {
                return true;
            }

            return false;
        }

        public bool IsNotRightBoundary(int x)
        {
            if (x < MaxColumns)
            {
                return true;
            }

            return false;
        }

        private bool IsTopWall(int x, int y)
        {
            if (y == MaxRows)
            {
                return true;
            }
            
            return false;
        }

        private bool IsRightWall(int x, int y)
        {
            if (x == MaxColumns)
            {
                return true;
            }

            return false;
        }

        private bool IsBottomWall(int x, int y)
        {
            if (y == 1)
            {
                return true;
            }

            return false;
        }

        private bool IsLeftWall(int x, int y)
        {
            if (x == 1)
            {
                return true;
            }

            return false;
        }
        public bool IsWall(int x, int y)
        {
            if (y == 5)
            {
                if (x == 2 
                    || x == 3 
                    || x == 4 
                    || x == 6
                    || x == 7
                    || x == 8
                    || x == 10
                    || x == 11)
                {
                    return true;
                }
            }

            if (IsTopWall(x,y) || IsBottomWall(x,y) || IsLeftWall(x,y) || IsRightWall(x,y)) 
            {
                return true;
            }
            
            return false;
        }
    }
}