using System;
using System.Collections.Generic;

namespace Battleship
{
    public class Fleet 
    {
        private Dictionary<Direction,Tuple<int,int>> _directionIncrements = new Dictionary<Direction,Tuple<int,int>>
        {
            {Direction.North, new Tuple<int,int>(0,1)}, 
            {Direction.East, new Tuple<int,int>(1,0)}, 
            {Direction.South, new Tuple<int,int>(0,-1)}, 
            {Direction.West, new Tuple<int,int>(-1,0)}
        };

        private Random rndNumberGenerator = new Random();
        public Fleet ()
        {
            // AssignShipsDefault();
            AssignShipsRandom();
        }

        public List<Ship> Ships {get; set;}

        private void AssignShipsDefault()
        {
            Ships = new List<Ship>
            {
                new Ship(ShipClass.Destroyer, Direction.South, new Coordinate(0,0), _directionIncrements),
                new Ship(ShipClass.Submarine, Direction.South, new Coordinate(0,0), _directionIncrements),
                new Ship(ShipClass.Cruiser, Direction.South, new Coordinate(0,0), _directionIncrements),
                new Ship(ShipClass.Battleship, Direction.South, new Coordinate(0,0), _directionIncrements),
                new Ship(ShipClass.Carrier, Direction.South, new Coordinate(0,0), _directionIncrements)
            };
        }

        private void AssignShipsRandom()
        {
            Ships = new List<Ship>();

            for (var index = 1; index <= 5; index++)
            {
                var validShipPlacement = false;
                var direction = new Direction();
                var coordinates = new Coordinate(0,0);
                while (!validShipPlacement)
                {
                    direction = PickRandomDirection();
                    coordinates = PickRandomCoordinates();
                    validShipPlacement = ValidateShipPlacement((ShipClass)index, direction, coordinates);
                }
                Ships.Add(new Ship((ShipClass)index, direction, coordinates, _directionIncrements));
            }
        }

        private Direction PickRandomDirection()
        {
            var direction = rndNumberGenerator.Next(0,4);
            return (Direction)direction;
        }

        private Coordinate PickRandomCoordinates()
        {
            return new Coordinate(rndNumberGenerator.Next(0,10), rndNumberGenerator.Next(0,10));
        }

        private bool ValidateShipPlacement(ShipClass shipClass, Direction direction, Coordinate coordinates)
        {

            return VerifyEndpointWithinGrid(ShipClassSize.ShipSize[shipClass], direction, coordinates);
        }

        private bool VerifyEndpointWithinGrid(int length, Direction direction, Coordinate coordinates)
        {
            return (coordinates.xAxis + (length * _directionIncrements[direction].Item1) < 10)
                && (coordinates.yAxis + (length * _directionIncrements[direction].Item2) < 10);
        }
    }
}