namespace Battleship
{
    public class Player
    {
        public int PlayerId;
        
        public GridSquare[][] squares { get{
            return new []{
                new []{
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Hit, Ship = new Ship(ShipClass.Destroyer)},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Miss},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown}
                },
                new []{
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown}
                },
                new []{
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown}
                },
                new []{
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown}
                },
                new []{
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown}
                },
                new []{
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown}
                },
                new []{
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown}
                },
                new []{
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown}
                },
                new []{
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown}
                },
                new []{
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown}
                },
                new []{
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown}
                }
            };
        }}
    }
}