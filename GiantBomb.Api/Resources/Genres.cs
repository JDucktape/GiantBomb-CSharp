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
        public Genre GetGenre(int id, string[] limitFields = null)
        {
            return GetSingleResource<Genre>("genre", ResourceTypes.Genres, id, limitFields);
        }

        public IEnumerable<Genre> GetGenres(int page = 1, int pageSize = GiantBombBase.DefaultLimit, string[] limitFields = null)
        {
            var liteGames = GetListResource<Genre>("genres", page, pageSize, limitFields);

            if (liteGames == null) return null;

            return liteGames;
        }
    }
}
