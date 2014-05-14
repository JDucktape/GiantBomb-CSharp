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
        public string Locationaddress { get; set; } 
        public string LocationCity { get; set; } 
        public string LocationCountry { get; set; } 
        public string LocationState { get; set; }
        public List<Location> Locations { get; set; }
        public string Name { get; set; }
        public List<Object> Objects { get; set; }
        public List<Person> People { get; set; }
        public string Phone { get; set; }
        public List<Game> PublishedGames { get; set; }
        public List<Release> PublisherReleases { get; set; }
        public string SiteDetailUrl { get; set; }
        public string Website { get; set; }
    }
}
