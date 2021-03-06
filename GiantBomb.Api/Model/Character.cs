﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace GiantBomb.Api.Model
{
    public class Character
    {
        /// <summary>
        /// Newline-delimited list of aliases
        /// </summary>
        public string Aliases { get; set; }
        public string ApiDetailUrl { get; set; }
        public string Birthday { get; set; }
        public List<Concept> Concepts { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateLastUpdated { get; set; }
        public string Deck { get; set; }
        public string Description { get; set; }
        public List<Character> Enemies { get; set; }
        public Game FirstAppearedInGame { get; set; }
        public List<Franchise> Franchises { get; set; }
        public List<Character> Friends { get; set; }
        public List<Game> Games { get; set; }
        /// <summary>
        /// Available options are: Male (1), Female (2) or Other (3)
        /// </summary>
        public int? Gender { get; set; } // TODO: Maybe create enum for Gender choice? Data is 1 (Male), 2 (Female) or 3 (Other)
        public int Id { get; set; }
        public Image Image { get; set; }
        public string LastName { get; set; }
        public List<Location> Locations { get; set; }
        public string Name { get; set; }
        public List<Object> Objects { get; set; }
        public List<Person> People { get; set; }
        public string RealName { get; set; }
        public string SiteDetailUrl { get; set; }
    }
}
