namespace Battleship
{
    public class Ship
    {
        public ShipClass ShipClassThis {get; set;}   

        public bool[] ShipDamage;

        public Ship(ShipClass shipClass){
            ShipDamage = new bool[Fleet.ShipSize[shipClass]];
        }
    }
}