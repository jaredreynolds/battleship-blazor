using Battleship.Services;
using System.Collections.Generic;
using System.Linq;

namespace Battleship
{
    public class Player
    {
        private readonly CurrentPlayerService _currentPlayerService;

        public Player(int id, CurrentPlayerService currentPlayerService, string name)
        {
            Id = id;
            Name = name;
            _currentPlayerService = currentPlayerService;
            InitSquares();
        }

        public int Id { get; }
        public string Name { get; set; }

        public bool IsMe
        {
            get => Id == _currentPlayerService.GetPlayerId();
        }

        public Fleet Fleet { get; set; } = new Fleet();

        public GridSquare[][] Squares { get; private set; }
        public IDictionary<Coordinate, GridSquare> SquaresByCoordinate { get; } = new Dictionary<Coordinate, GridSquare>();

        private void InitSquares()
        {
            Squares = Enumerable.Range(0, 10).Select(y =>
                Enumerable.Range(0, 10).Select(x =>
                {
                    var square = new GridSquare { Location = new Coordinate(x, y) };
                    SquaresByCoordinate.Add(square.Location, square);
                    return square;
                }).ToArray()).ToArray();

            var testShip = Fleet.Ships[0];
            testShip.DeployShip(new Coordinate(0, 0), Direction.East);
            Squares[0][0].Ship = testShip;
            Squares[0][1].Ship = testShip;
        }
    }
}