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
        public Review GetReview(int id, string[] limitFields = null)
        {
            return GetSingleResource<Review>("review", ResourceTypes.Reviews, id, limitFields);
        }

        public IEnumerable<Review> GetReviews(int page = 1, int pageSize = GiantBombBase.DefaultLimit, string[] limitFields = null)
        {
            var liteGames = GetListResource<Review>("reviews", page, pageSize, limitFields);

            if (liteGames == null) return null;

            return liteGames;
        }
    }
}
