using System;
using System.Collections.Generic;

namespace Battleship
{
    public class Ship
    {
        private ShipClass _shipClass;
        private List<Coordinate> _position;

        //TODO: This would be better off living somewhere else, such as in Game or another singleton
        private Dictionary<Direction,Tuple<int,int>> _directionIncrements = new Dictionary<Direction,Tuple<int,int>>
        {
            {Direction.North, new Tuple<int,int>(0,1)}, 
            {Direction.East, new Tuple<int,int>(1,0)}, 
            {Direction.South, new Tuple<int,int>(0,-1)}, 
            {Direction.West, new Tuple<int,int>(-1,0)}
        };

        public Ship(ShipClass shipClass, Direction direction, Coordinate startingLocation){
            _shipClass = shipClass;
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