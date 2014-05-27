using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GiantBomb.Api.Model;

namespace GiantBomb.Api {
    public partial class GiantBombRestClient {

        public Release GetRelease(int id, string[] limitFields = null) {
            return GetSingleResource<Release>("release", ResourceTypes.Releases, id, limitFields);
        }

        public IEnumerable<Release> GetReleasesForGame(int gameId, string[] limitFields = null)
        {
            var filter = new Dictionary<string, object>()
                             {
                                 {"game", gameId}
                             };

            return GetListResource<Release>("releases", fieldList: limitFields, filterOptions: filter);
        }

        public IEnumerable<Release> GetReleasesForGame(Game game, string[] limitFields = null)
        {
            return GetReleasesForGame(game.Id, limitFields);
        }

        public IEnumerable<Release> GetReleases(int page = 1, int pageSize = GiantBombBase.DefaultLimit, string[] limitFields = null) // TODO: Add testcase for releases
        {
            var liteGames = GetListResource<Release>("releases", page, pageSize, limitFields);

            if (liteGames == null) return null;

            return liteGames;
        }
    }
}
