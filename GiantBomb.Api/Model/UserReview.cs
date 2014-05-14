using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GiantBomb.Api.Model
{
    public class UserReview
    {
        public string ApiDetailUrl { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateLastUpdated { get; set; }
        public string Deck { get; set; }
        public string Description { get; set; }
        public Game Game { get; set; }
        public Person Reviewer { get; set; } 
        public int Score { get; set; }
        public string SiteDetailUrl { get; set; }
    }
}
