using System;
using System.Linq;
using Battleship.Services;
using Microsoft.AspNetCore.Blazor.Services;
using Microsoft.AspNetCore.WebUtilities;

namespace Battleship
{
    public class Game
    {
        private readonly CurrentPlayerService _currentPlayerService;
        private readonly Player[] _players;

        public Game(CurrentPlayerService currentPlayerService)
        {
            _currentPlayerService = currentPlayerService;
            _players = new[] {
                new Player(0, currentPlayerService),
                new Player(1, currentPlayerService)
            };
        }

        public Players Players
        {
            get
            {
                var me = _currentPlayerService.GetPlayerId();
                return new Players(_players[me], _players[me == 0 ? 1 : 0]);
            }
        }

        public GameState State { get; set; }

        public int Turn { get; set; }
    }
}
