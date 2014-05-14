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
        public Concept GetConcept(int id, string[] limitFields = null)
        {
            return GetSingleResource<Concept>("concept", ResourceTypes.Concepts, id, limitFields);
        }

        public IEnumerable<Concept> GetConcepts(int page = 1, int pageSize = GiantBombBase.DefaultLimit, string[] limitFields = null)
        {
            var liteGames = GetListResource<Concept>("concepts", page, pageSize, limitFields);

            if (liteGames == null) return null;

            return liteGames;
        }
    }
}
