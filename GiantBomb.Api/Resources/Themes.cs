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
        public Theme GetTheme(int id, string[] limitFields = null)
        {
            return GetSingleResource<Theme>("theme", ResourceTypes.Themes, id, limitFields);
        }

        public IEnumerable<Theme> GetThemes(int page = 1, int pageSize = GiantBombBase.DefaultLimit, string[] limitFields = null)
        {
            var liteGames = GetListResource<Theme>("themes", page, pageSize, limitFields);

            if (liteGames == null) return null;

            return liteGames;
        }
    }
}
