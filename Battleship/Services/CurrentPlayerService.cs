using System;
using System.Linq;
using Microsoft.AspNetCore.Blazor.Services;
using Microsoft.AspNetCore.WebUtilities;

namespace Battleship.Services
{
    public class CurrentPlayerService
    {
        private readonly IUriHelper _uriHelper;

        public CurrentPlayerService(IUriHelper uriHelper) => _uriHelper = uriHelper;

        public int GetPlayerId()
        {
            var uri = new Uri(_uriHelper.GetAbsoluteUri());
            return QueryHelpers.ParseQuery(uri.Query).TryGetValue("id", out var id) ? int.Parse(id.First()) : 0;
        }
    }
}
