namespace Battleship
{
    public class Ship
    {
        public static ShipClass ShipClass {get; set;}   

        public ShipLocation Position {get; set;}

        public bool[] ShipDamage = new bool[ShipClass];
    }

    public struct ShipLocation
    {
        public int[] Coordinates;
        public Direction Orientation;
    }

    public Dictionary<ShipClass,int> ShipSize = new Dictionary<ShipClass,int>
    {
        {Destroyer, 2}
    };

    public enum Direction
    {
        North = 0,
        East = 1,
        South = 2,
        West = 3
    }
}