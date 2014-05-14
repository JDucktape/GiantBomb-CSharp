using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GiantBomb.Api.Model {
    public class Platform {

        public string Abbreviation { get; set; }
        public string ApiDetailUrl { get; set; }
        public Company Company { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateLastUpdated { get; set; }
        public string Deck { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public Image Image { get; set; }
        public int InstallBase { get; set; }
        public string Name { get; set; }
        public bool? OnlineSupport { get; set; } 
        public double OriginalPrice { get; set; } 
        public DateTime? ReleaseDate { get; set; }
        public string SiteDetailUrl { get; set; }
    }
}
