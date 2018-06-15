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
    }
}