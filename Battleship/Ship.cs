using System;
using System.Collections.Generic;

namespace Battleship
{
    public class Ship
    {
        private ShipClass _shipClass;
        private List<Coordinate> _position;

        private Dictionary<Direction,Tuple<int,int>> _directionIncrements = new Dictionary<Direction,Tuple<int,int>>();

        public Ship(ShipClass shipClass, Direction direction, Coordinate startingLocation, Dictionary<Direction,Tuple<int,int>> directionIncrements)
        {
            _shipClass = shipClass;
            _directionIncrements = directionIncrements;
            DeployShip(startingLocation, direction);
            ShipDamage = new bool[ShipClassSize.ShipSize[shipClass]];
        }

        public ShipClass ShipClass {
            get { return _shipClass; }
            set { _shipClass = value; }
        }   

        public List<Coordinate> Position {
            get { return _position;}
        }

        public bool[] ShipDamage;

        public void DeployShip (Coordinate sternCoordinate, Direction orientation)
        {
            _position = new List<Coordinate>();

            for (var shipCell = 0; shipCell < ShipClassSize.ShipSize[_shipClass]; shipCell++)
            {
                _position.Add(new Coordinate(sternCoordinate.xAxis + (shipCell * _directionIncrements[orientation].Item1), 
                                            sternCoordinate.yAxis + (shipCell * _directionIncrements[orientation].Item2)));
            }
        }
    }
}