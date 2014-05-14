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
        public RatingBoard GetRatingBoard(int id, string[] limitFields = null)
        {
            return GetSingleResource<RatingBoard>("rating_board", ResourceTypes.RatingBoards, id, limitFields);
        }

        public IEnumerable<RatingBoard> GetRatingBoards(int page = 1, int pageSize = GiantBombBase.DefaultLimit, string[] limitFields = null)
        {
            var liteGames = GetListResource<RatingBoard>("rating_boards", page, pageSize, limitFields);

            if (liteGames == null) return null;

            return liteGames;
        }
    }
}
