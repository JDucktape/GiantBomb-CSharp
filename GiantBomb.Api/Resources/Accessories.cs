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
        public Accessory GetAccessory(int id, string[] limitFields = null)
        {
            return GetSingleResource<Accessory>("accessory", ResourceTypes.Accessories, id, limitFields);
        }

        public IEnumerable<Accessory> GetAccessories(int page = 1, int pageSize = GiantBombBase.DefaultLimit, string[] limitFields = null)
        {
            var liteGames = GetListResource<Accessory>("accessories", page, pageSize, limitFields);

            if (liteGames == null) return null;

            return liteGames;
        }
    }
}
