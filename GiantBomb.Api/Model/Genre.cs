using System;

namespace GiantBomb.Api.Model
{
    public class Genre
    {
        public string ApiDetailUrl { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateLastUpdated { get; set; }
        public string Deck { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public Image Image { get; set; }
        public string Name { get; set; }
        public string SiteDetailUrl { get; set; }
    }
}