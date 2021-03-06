using System;
using System.Collections.Generic;
using System.Linq;

namespace Battleship
{
    public class Ship : IEquatable<Ship>
    {
        private int _hitPoints;
        private IDictionary<Coordinate, bool> _hitsByCoordinate = new Dictionary<Coordinate, bool>();
        private Dictionary<Direction, Tuple<int, int>> _directionIncrements = new Dictionary<Direction, Tuple<int, int>>();

        public Ship(ShipClass shipClass, Direction direction, Coordinate startingLocation, Dictionary<Direction, Tuple<int, int>> directionIncrements)
        {
            ShipClass = shipClass;
            _directionIncrements = directionIncrements;
            DeployShip(startingLocation, direction);
            _hitPoints = ShipClassSize.ShipSize[shipClass];
        }

        public ShipClass ShipClass { get; set; }

        public List<Coordinate> Position => _hitsByCoordinate.Keys.ToList();

        public bool IsSunk => _hitPoints == 0;

        public void DeployShip (Coordinate sternCoordinate, Direction orientation)
        {
            _hitsByCoordinate.Clear();
            
            for (var shipCell = 0; shipCell < ShipClassSize.ShipSize[ShipClass]; shipCell++)
            {
                var x = sternCoordinate.xAxis + (shipCell * _directionIncrements[orientation].Item1);
                var y = sternCoordinate.yAxis + (shipCell * _directionIncrements[orientation].Item2);
                _hitsByCoordinate.Add(new Coordinate(x, y), false);
            }
        }

        public void Hit(Coordinate shot)
        {
            if (_hitsByCoordinate.TryGetValue(shot, out var alreadyHit) && alreadyHit)
            {
                if (!alreadyHit)
                {
                    Console.WriteLine($"ERROR: {ShipClass} is not at {shot}");
                } else
                {
                    Console.WriteLine($"{ShipClass} was already hit at {shot}");
                }
                return;
            }

            Console.WriteLine($"{ShipClass} hit at {shot}");
            _hitsByCoordinate[shot] = true;
            _hitPoints = Math.Max(--_hitPoints, 0);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Ship);
        }

        public bool Equals(Ship other)
        {
            return other != null &&
                   ShipClass == other.ShipClass;
        }

        public override int GetHashCode()
        {
            return -965370420 + ShipClass.GetHashCode();
        }

        public override string ToString()
        {
            return ShipClass.ToString();
        }
    }
}