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
        public Company GetCompany(int id, string[] limitFields = null)
        {
            return GetSingleResource<Company>("company", ResourceTypes.Companies, id, limitFields);
        }

        public IEnumerable<Company> GetCompanies(int page = 1, int pageSize = GiantBombBase.DefaultLimit, string[] limitFields = null)
        {
            var liteGames = GetListResource<Company>("companies", page, pageSize, limitFields);

            if (liteGames == null) return null;

            return liteGames;
        }
    }
}
