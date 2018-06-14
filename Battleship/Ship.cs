namespace Battleship
{
    public class Ship
    {
        public static ShipClass ShipClassThis {get; set;}   

        public bool[] ShipDamage = new bool[Fleet.ShipSize[ShipClassThis]];
    }
}