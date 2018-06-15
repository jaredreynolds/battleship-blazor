using System.Collections.Generic;

namespace Battleship
{
    public class Fleet 
    {
        public Fleet ()
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

        public List<Ship> Ships {get; set;}
    }
}