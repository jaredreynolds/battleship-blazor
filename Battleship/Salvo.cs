using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Battleship
{
    public class Salvo
    {
        public static IReadOnlyList<Ship> Fire(Player opponent, IEnumerable<Coordinate> shots)
        {
            var sunkShips = new HashSet<Ship>();
            foreach (var shot in shots)
            {
                var square = opponent.SquaresByCoordinate[shot];
                var ship = square.Ship;
                if (ship == null)
                {
                    square.Status = SquareStatus.Miss;
                    Console.WriteLine($"No ship found at {shot}");
                    continue;
                }

                ship.Hit(shot);
                square.Status = SquareStatus.Hit;
                if (ship.IsSunk)
                {
                    sunkShips.Add(ship);
                }
            }
            return new ReadOnlyCollection<Ship>(sunkShips.ToList());
        }
    }
}
