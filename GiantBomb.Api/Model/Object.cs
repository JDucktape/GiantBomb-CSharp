using System;
using System.Collections.Generic;
using System.Linq;

namespace GiantBomb.Api.Model
{
    public class Object
    {
        /// <summary>
        /// Newline-delimited list of aliases
        /// </summary>
        public string Aliases { get; set; }
        public string ApiDetailUrl { get; set; }
        public List<Character> Characters {get; set;}
        public List<Company> Companies { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateLastUpdates { get; set; }
        public string Deck { get; set; }
        public string Description { get; set; }
        public Game FirstAppearedInGame { get; set; }
        public List<Franchise> Franchises { get; set; }
        public List<Game> Games { get; set; }
        public int Id { get; set; }
        public Image Image { get; set; }
        public List<Location> Locations { get; set; }
        public string Name { get; set; }
        public List<Object> Objects { get; set; }
        public List<Person> People { get; set; }
        public string SiteDetailUrl { get; set; }
    }
}
