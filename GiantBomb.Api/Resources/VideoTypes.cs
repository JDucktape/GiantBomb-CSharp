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
        public VideoType GetVideoType(int id, string[] limitFields = null)
        {
            return GetSingleResource<VideoType>("video_type", ResourceTypes.VideoTypes, id, limitFields);
        }

        public IEnumerable<VideoType> GetVideoTypes(int page = 1, int pageSize = GiantBombBase.DefaultLimit, string[] limitFields = null)
        {
            var liteGames = GetListResource<VideoType>("video_types", page, pageSize, limitFields);

            if (liteGames == null) return null;

            return liteGames;
        }
    }
}
