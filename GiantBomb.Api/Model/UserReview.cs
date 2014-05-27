using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GiantBomb.Api.Model
{
    public class UserReview // TODO: No Id in Review class (GB apparently forgot to add it, as it has an ID in ApiDetailUrl). Seems to be linked to Game and/or Release instead.
    {
        public string ApiDetailUrl { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateLastUpdated { get; set; }
        public string Deck { get; set; }
        public string Description { get; set; }
        public Game Game { get; set; }
        public string Reviewer { get; set; } 
        public int Score { get; set; }
        public string SiteDetailUrl { get; set; }
    }
}
