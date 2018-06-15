using System;
using System.Linq;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Blazor.Services;

namespace Battleship
{
    public class Game
    {
        // 2 players
        // each player has their board
        // will need a player class
        // there are 2 boards in play - the ui will differ depending on who is viewing it
        // need to be able to disable clicking on board not in play

        // private static Game _game;
        // private Game() {}
        // public static Game Instance{ get{
        //     return _game ?? (_game = new Game());
        // }}
        private IUriHelper _uriHelper;
        public Game(IUriHelper uriHelper){
            _uriHelper = uriHelper;
        }

        public Player[] players = new []{
            new Player(0),
            new Player(1)
        };

        public Players Players{ get{
            var me = GetPlayerId();
            
            return new Players(players[me], players[me == 0 ? 1 : 0]);
        }}

        public int Turn{ get; set; }

        private int GetPlayerId() {
            var uri = new Uri(_uriHelper.GetAbsoluteUri());
            return Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery(uri.Query).TryGetValue("id", out var id) ? int.Parse(id.First()) : 0;
        }
    }
}