using System;
using System.Collections.Generic;

namespace GiantBomb.Api.Model {
    public class Company 
    {
        public string Abbreviation { get; set; }
        /// <summary>
        /// Newline-delimited list of aliases
        /// </summary>
        public string Aliases { get; set; }
        public string ApiDetailUrl { get; set; }
        public List<Character> Characters { get; set; }
        public List<Concept> Concepts { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateFounded { get; set; }
        public DateTime DateLastUpdated { get; set; }
        public string Deck { get; set; }
        public string Description { get; set; }
        public List<Game> DevelopedGames { get; set; }
        public List<Release> DeveloperReleases { get; set; }
        public List<Release> DistributorReleases { get; set; }
        public int Id { get; set; }
        public Image Image { get; set; }
        public string Locationaddress { get; set; } // TODO: Field is listed twice on API field list. Verify data on GiantBomb to see if this is just a cut-n-paste error.
        public string LocationCity { get; set; } // TODO: Field is listed twice on API field list. Verify data on GiantBomb to see if this is just a cut-n-paste error.
        public string LocationCountry { get; set; } // TODO: Field is listed twice on API field list. Verify data on GiantBomb to see if this is just a cut-n-paste error.
        public string LocationState { get; set; }
        public List<Location> Locations { get; set; }
        public string Name { get; set; }
        public List<Object> Objects { get; set; }
        public List<Person> People { get; set; }
        public string Phone { get; set; } // TODO: Verify data on GiantBomb to see if this is string or int
        public List<Game> PublishedGames { get; set; }
        public List<Release> PublisherReleases { get; set; }
        public string SiteDetailUrl { get; set; }
        public string Website { get; set; }
    }
}
