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
        public Model.Object GetObject(int id, string[] limitFields = null)
        {
            return GetSingleResource<Model.Object>("object", ResourceTypes.Objects, id, limitFields);
        }

        public IEnumerable<Model.Object> GetObjects(int page = 1, int pageSize = GiantBombBase.DefaultLimit, string[] limitFields = null)
        {
            var liteGames = GetListResource<Model.Object>("objects", page, pageSize, limitFields);

            if (liteGames == null) return null;

            return liteGames;
        }
    }
}
