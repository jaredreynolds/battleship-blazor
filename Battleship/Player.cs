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
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Hit, Ship = new Ship(ShipClass.Destroyer)},
                    new GridSquare {Status = SquareStatus.Unknown, Ship = new Ship(ShipClass.Destroyer)},
                    new GridSquare {Status = SquareStatus.Unknown, Ship = new Ship(ShipClass.Destroyer)},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Miss},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Unknown},
                    new GridSquare {Status = SquareStatus.Miss},
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