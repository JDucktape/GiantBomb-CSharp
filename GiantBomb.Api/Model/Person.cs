using System;
using System.Collections.Generic;

namespace GiantBomb.Api.Model {
    public class Person {

        /// <summary>
        /// Newline-delimited list of aliases
        /// </summary>
        public string Aliases { get; set; }
        public string ApiDetailUrl { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Character> Characters { get; set; }
        public List<Concept> Concepts { get; set; }
        public string Country { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateLastUpdated { get; set; }
        public DateTime? DeathDate { get; set; }
        public string Deck { get; set; }
        public string Description { get; set; }
        public Game FirstCreditedGame { get; set; }
        public List<Franchise> Franchises { get; set; }
        public List<Game> Games { get; set; }
        public string Gender { get; set; } // TODO: Maybe create enum for Gender choice?
        public string Hometown { get; set; }
        public int Id { get; set; }
        public Image Image { get; set; }
        public List<Location> Locations { get; set; }
        public string Name { get; set; }
        public List<Object> Objects { get; set; }
        public List<Person> People { get; set; }
        public string SiteDetailUrl { get; set; }
    }
}