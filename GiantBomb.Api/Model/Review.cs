using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GiantBomb.Api.Model
{
    public class Review
    {
        public string ApiDetailUrl { get; set; }
        public string Deck { get; set; }
        public string Description { get; set; }
        public string DlcName { get; set; }
        public Game Game { get; set; }
        public List<Platform> Platforms { get; set; }
        public DateTime PublishDate { get; set; }
        public Release Release { get; set; }
        public Person Reviewer { get; set; } // TODO: Determine if this is a string or a Person
        public int Score { get; set; }
        public string SiteDetailUrl { get; set; }
    }
}
