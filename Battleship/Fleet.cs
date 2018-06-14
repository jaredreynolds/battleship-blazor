using System.Collections.Generic;

namespace Battleship
{
    public class Fleet 
    {
        public Fleet ()
        {
            Ships = new List<Ship>
            {
                new Ship(ShipClass.Destroyer)
                new Ship(ShipClass.Submarine)
                new Ship(ShipClass.Cruiser)
                new Ship(ShipClass.Battleship)
                new Ship(ShipClass.Carrier)
            };
        }

        public List<Ship> Ships {get; set;}
    }
}