﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GiantBomb.Api.Model;
using RestSharp;

namespace GiantBomb.Api {
    public partial class GiantBombRestClient {
        public IEnumerable<Game> SearchForGames(string query, int page = 1, int pageSize = GiantBombBase.DefaultLimit, string[] limitFields = null) {
            var result = InternalSearchForGames(query, page, pageSize, limitFields);

            if (result.StatusCode == GiantBombBase.StatusOk)
                return result.Results;

            return null;
        }

        internal GiantBombResults<Game> InternalSearchForGames(string query, int page = 1, int pageSize = GiantBombBase.DefaultLimit, string[] limitFields = null) {
            var request = GetListResource("search", page, pageSize, limitFields);

            request.AddParameter("query", query);
            request.AddParameter("resources", "game");

            return Execute<GiantBombResults<Game>>(request);
        }

        public IEnumerable<Game> SearchForAllGames(string query, string[] limitFields = null) {
            var results = new List<Game>();
            var result = InternalSearchForGames(query, limitFields: limitFields);

            if (result == null || result.StatusCode != GiantBombBase.StatusOk)
                return null;

            results.AddRange(result.Results);

            if (result.NumberOfTotalResults > result.Limit) {
                double remaining = Math.Ceiling(Convert.ToDouble(result.NumberOfTotalResults) / Convert.ToDouble(result.Limit));

                // Start on page 2
                for (var i = 2; i <= remaining; i++) {
                    result = InternalSearchForGames(query, i, result.Limit, limitFields);

                    if (result.StatusCode != GiantBombBase.StatusOk)
                        break;

                    results.AddRange(result.Results);
                }
            }

            return results;
        }
    }
}
