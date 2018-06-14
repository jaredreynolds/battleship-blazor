namespace Battleship
{
    public class Ship
    {
        private ShipClass _shipClass;

        public Ship(ShipClass shipClass){
            _shipClass = shipClass;
            ShipDamage = new bool[ShipClassSize.ShipSize[shipClass]];
        }

        public ShipClass ShipClass {
            get { return _shipClass; }
            set { _shipClass = value; }
        }   

        public ShipLocation Position {get; set;}

        public bool[] ShipDamage;
    }

    public struct ShipLocation
    {
        public int[] Coordinates;
        public Direction Orientation;
    }

    public enum Direction
    {
        North = 0,
        East = 1,
        South = 2,
        West = 3
    }
}