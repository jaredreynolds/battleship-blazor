using System;
using System.Collections.Generic;

namespace Battleship
{
    public class Fleet 
    {
        private Random rndNumberGenerator = new Random();
        public Fleet ()
        {
            // AssignShipsDefault();
            AssignShipsRandom();
        }

        private void AssignShipsDefault()
        {
            Ships = new List<Ship>
            {
                new Ship(ShipClass.Destroyer, Direction.South, new Coordinate(0,0)),
                new Ship(ShipClass.Submarine, Direction.South, new Coordinate(0,0)),
                new Ship(ShipClass.Cruiser, Direction.South, new Coordinate(0,0)),
                new Ship(ShipClass.Battleship, Direction.South, new Coordinate(0,0)),
                new Ship(ShipClass.Carrier, Direction.South, new Coordinate(0,0))
            };
        }

        private void AssignShipsRandom()
        {
            Ships = new List<Ship>();

            for (var index = 1; index <= 5; index++)
            {
                var ship = new Ship((ShipClass)index, PickRandomDirection(), PickRandomCoordinates());
                Ships.Add(ship);
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

        public List<Ship> Ships {get; set;}
    }
}