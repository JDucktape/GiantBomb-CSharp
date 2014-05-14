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
        public Location GetLocation(int id, string[] limitFields = null)
        {
            return GetSingleResource<Location>("location", ResourceTypes.Locations, id, limitFields);
        }

        public IEnumerable<Location> GetLocations(int page = 1, int pageSize = GiantBombBase.DefaultLimit, string[] limitFields = null)
        {
            var liteGames = GetListResource<Location>("locations", page, pageSize, limitFields);

            if (liteGames == null) return null;

            return liteGames;
        }
    }
}
