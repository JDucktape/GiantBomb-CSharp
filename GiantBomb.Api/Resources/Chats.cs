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
        public Chat GetChat(int id, string[] limitFields = null) // TODO: No Id in Chat class. Use ChannelName or Title instead? No chat data in DB to compare to. Maybe just drop it?
        {
            return GetSingleResource<Chat>("chat", ResourceTypes.Chats, id, limitFields);
        }

        public IEnumerable<Chat> GetChats(int page = 1, int pageSize = GiantBombBase.DefaultLimit, string[] limitFields = null) 
        {
            var liteGames = GetListResource<Chat>("chats", page, pageSize, limitFields);

            if (liteGames == null) return null;

            return liteGames;
        }
    }
}
