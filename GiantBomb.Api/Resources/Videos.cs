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
        public Video GetVideo(int id, string[] limitFields = null)
        {
            return GetSingleResource<Video>("video", ResourceTypes.Videos, id, limitFields);
        }

        public IEnumerable<Video> GetVideos(int page = 1, int pageSize = GiantBombBase.DefaultLimit, string[] limitFields = null)
        {
            var liteGames = GetListResource<Video>("videos", page, pageSize, limitFields);

            if (liteGames == null) return null;

            return liteGames;
        }
    }
}
