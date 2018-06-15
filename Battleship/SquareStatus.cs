namespace Battleship
{
    public enum SquareStatus
    {
        // opponent
        Unknown = 0,
        Hit = 1,
        Miss = 2,

        // me
        NoShip = 3,
        Ship = 4
    }
}
