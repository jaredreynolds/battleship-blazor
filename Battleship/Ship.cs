using System;
using System.Collections.Generic;

namespace Battleship
{
    public class Ship
    {
        private ShipClass _shipClass;

        //TODO: This would be better off living somewhere else, such as in Game or another singleton
        private Dictionary<Direction,Tuple<int,int>> _directionIncrements = new Dictionary<Direction,Tuple<int,int>>
        {
            {Direction.North, new Tuple<int,int>(0,1)}, 
            {Direction.East, new Tuple<int,int>(1,0)}, 
            {Direction.South, new Tuple<int,int>(0,-1)}, 
            {Direction.West, new Tuple<int,int>(-1,0)}
        };

        public Ship(ShipClass shipClass, Direction dir, Coordinate startingLocation){
            _shipClass = shipClass;
            ShipDamage = new bool[ShipClassSize.ShipSize[shipClass]];
        }

        public ShipClass ShipClass {
            get { return _shipClass; }
            set { _shipClass = value; }
        }   

        public List<Coordinate> Position {get; }

        public bool[] ShipDamage;

        public void DeployShip (Coordinate sternCoordinate, Direction orientation)
        {
            for (var shipCell = 0; shipCell < ShipClassSize.ShipSize[_shipClass]; shipCell++)
            {
                Position.Add(new Coordinate(sternCoordinate.xAxis + (shipCell * _directionIncrements[orientation].Item1), 
                                            sternCoordinate.yAxis + (shipCell * _directionIncrements[orientation].Item2)));
            }
        }
    }

    public enum Direction
    {
        North = 0,
        East = 1,
        South = 2,
        West = 3
    }
}