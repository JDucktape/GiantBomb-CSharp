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
        public Promo GetPromo(int id, string[] limitFields = null)
        {
            return GetSingleResource<Promo>("promo", ResourceTypes.Promos, id, limitFields);
        }

        public IEnumerable<Promo> GetPromos(int page = 1, int pageSize = GiantBombBase.DefaultLimit, string[] limitFields = null)
        {
            var liteGames = GetListResource<Promo>("promos", page, pageSize, limitFields);

            if (liteGames == null) return null;

            return liteGames;
        }
    }
}
