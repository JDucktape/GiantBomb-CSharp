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
        public Character GetCharacter(int id, string[] limitFields = null)
        {
            return GetSingleResource<Character>("character", ResourceTypes.Characters, id, limitFields);
        }

        public IEnumerable<Character> GetCharacters(int page = 1, int pageSize = GiantBombBase.DefaultLimit, string[] limitFields = null)
        {
            var liteGames = GetListResource<Character>("characters", page, pageSize, limitFields);

            if (liteGames == null) return null;

            return liteGames;
        }
    }
}
