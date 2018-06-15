namespace Battleship {
    public class GridSquare
    {
        public SquareStatus Status { get; set; }
        public Ship Ship { get; set; }
        public Coordinate Location {get; set; }
    }
}