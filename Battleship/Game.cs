using System;
using System.Linq;
using Microsoft.AspNetCore.Blazor.Services;
using Microsoft.AspNetCore.WebUtilities;

namespace Battleship
{
    public class Game
    {
        private readonly IUriHelper _uriHelper;
        private readonly Player[] _players = new[]{
            new Player(0),
            new Player(1)
        };

        public Game(IUriHelper uriHelper)
        {
            _uriHelper = uriHelper;
        }

        public Players Players
        {
            get
            {
                var me = GetPlayerId();
                return new Players(_players[me], _players[me == 0 ? 1 : 0]);
            }
        }

        public int Turn { get; set; }

        private int GetPlayerId()
        {
            var uri = new Uri(_uriHelper.GetAbsoluteUri());
            return QueryHelpers.ParseQuery(uri.Query).TryGetValue("id", out var id) ? int.Parse(id.First()) : 0;
        }
    }
}
