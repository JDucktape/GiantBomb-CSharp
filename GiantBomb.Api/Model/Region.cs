using System;
using System.Collections.Generic;

namespace GiantBomb.Api.Model {
    public class Region {
        public string ApiDetailUrl { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateLastUpdated { get; set; }
        public string Deck { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public Image Image { get; set; }
        public string Name { get; set; }
        public List<RatingBoard> RatingBoards { get; set; }
        public string SiteDetailUrl { get; set; }
    }
}