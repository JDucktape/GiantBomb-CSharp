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
        public Franchise GetFranchise(int id, string[] limitFields = null)
        {
            return GetSingleResource<Franchise>("franchise", ResourceTypes.Franchises, id, limitFields);
        }

        public IEnumerable<Franchise> GetFranchises(int page = 1, int pageSize = GiantBombBase.DefaultLimit, string[] limitFields = null)
        {
            var liteGames = GetListResource<Franchise>("franchises", page, pageSize, limitFields);

            if (liteGames == null) return null;

            return liteGames;
        }
    }
}
