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
        public Person GetPerson(int id, string[] limitFields = null)
        {
            return GetSingleResource<Person>("person", ResourceTypes.People, id, limitFields);
        }

        public IEnumerable<Person> GetPeople(int page = 1, int pageSize = GiantBombBase.DefaultLimit, string[] limitFields = null)
        {
            var liteGames = GetListResource<Person>("people", page, pageSize, limitFields);

            if (liteGames == null) return null;

            return liteGames;
        }
    }
}
