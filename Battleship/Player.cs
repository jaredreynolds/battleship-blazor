using Battleship.Services;

namespace Battleship
{
    public class Player
    {
        private readonly CurrentPlayerService _currentPlayerService;

        public Player(int id, CurrentPlayerService currentPlayerService)
        {
            Id = id;
            _currentPlayerService = currentPlayerService;
        }

        public int Id { get; }

        public bool IsMe
        {
            get => Id == _currentPlayerService.GetPlayerId();
        }

        public Fleet Fleet { get; } = new Fleet();


        public GridSquare[][] Squares { get {
            return new []{
                new []{
                    new GridSquare {Status = SquareStatus.Unknown, Location = new Coordinate(0,0)},
                    new GridSquare {Status = SquareStatus.Hit, Ship = new Ship(ShipClass.Destroyer, Direction.South, new Coordinate(0,1)), Location = new Coordinate(0,1)},
                    new GridSquare {Status = SquareStatus.Unknown, Location = new Coordinate(0,2)},
                    new GridSquare {Status = SquareStatus.Unknown, Location = new Coordinate(0,3)},
                    new GridSquare {Status = SquareStatus.Unknown, Location = new Coordinate(0,4)},
                    new GridSquare {Status = SquareStatus.Miss, Location = new Coordinate(0,5)},
                    new GridSquare {Status = SquareStatus.Unknown, Location = new Coordinate(0,6)},
                    new GridSquare {Status = SquareStatus.Unknown, Location = new Coordinate(0,7)},
                    new GridSquare {Status = SquareStatus.Miss, Location = new Coordinate(0,8)},
                    new GridSquare {Status = SquareStatus.Unknown, Location = new Coordinate(0,9)}
                },
                new []{
                    new GridSquare {Status = SquareStatus.Unknown, Location = new Coordinate(1,0)},
                    new GridSquare {Status = SquareStatus.Unknown, Location = new Coordinate(1,1)},
                    new GridSquare {Status = SquareStatus.Unknown, Location = new Coordinate(1,2)},
                    new GridSquare {Status = SquareStatus.Unknown, Location = new Coordinate(1,3)},
                    new GridSquare {Status = SquareStatus.Unknown, Location = new Coordinate(1,4)},
                    new GridSquare {Status = SquareStatus.Unknown, Location = new Coordinate(1,5)},
                    new GridSquare {Status = SquareStatus.Unknown, Location = new Coordinate(1,6)},
                    new GridSquare {Status = SquareStatus.Unknown, Location = new Coordinate(1,7)},
                    new GridSquare {Status = SquareStatus.Unknown, Location = new Coordinate(1,8)},
                    new GridSquare {Status = SquareStatus.Unknown, Ship = new Ship(ShipClass.Battleship), Location = new Coordinate(1,9)}
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
                    new GridSquare {Status = SquareStatus.Unknown, Ship = new Ship(ShipClass.Battleship)}
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
                    new GridSquare {Status = SquareStatus.Unknown, Ship = new Ship(ShipClass.Battleship)}
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