using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GiantBomb.Api.Model;
using RestSharp;

namespace GiantBomb.Api
{
    public partial class GiantBombRestClient
    {
        public GameRating GetGameRating(int id, string[] limitFields = null)
        {
            return GetSingleResource<GameRating>("game_rating", ResourceTypes.GameRatings, id, limitFields);
        }

        public IEnumerable<GameRating> GetGameRatings(int page = 1, int pageSize = GiantBombBase.DefaultLimit, string[] limitFields = null)
        {
            var liteGames = GetListResource<GameRating>("game_ratings", page, pageSize, limitFields);

            if (liteGames == null) return null;

            return liteGames;
        }
    }
}
