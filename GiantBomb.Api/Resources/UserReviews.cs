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
        public UserReview GetUserReview(int id, string[] limitFields = null)
        {
            return GetSingleResource<UserReview>("user_review", ResourceTypes.UserReviews, id, limitFields);
        }

        public IEnumerable<UserReview> GetUserReviews(int page = 1, int pageSize = GiantBombBase.DefaultLimit, string[] limitFields = null)
        {
            var liteGames = GetListResource<UserReview>("user_reviews", page, pageSize, limitFields);

            if (liteGames == null) return null;

            return liteGames;
        }
    }
}
