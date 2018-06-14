using System.Collections.Generic;

namespace Battleship
{
    public class Fleet 
    {
        public static Dictionary<ShipClass,int> ShipSize = new Dictionary<ShipClass,int> 
        { 
            {ShipClass.Destroyer,2}, {ShipClass.Submarine,3}, {ShipClass.Cruiser,3}, {ShipClass.Battleship,4}, {ShipClass.Carrier,5}
        };
    }
}