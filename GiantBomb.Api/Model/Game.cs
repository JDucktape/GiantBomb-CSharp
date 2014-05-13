using System;
using System.Collections.Generic;
using System.Linq;

namespace GiantBomb.Api.Model {
    public class Game {
        /// <summary>
        /// Newline-delimited list of aliases
        /// </summary>
        public string Aliases { get; set; }
        public string ApiDetailUrl { get; set; }
        public List<Character> Characters { get; set; }
        public List<Concept> Concepts { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateLastUpdated { get; set; }
        public string Deck { get; set; }
        public string Description { get; set; }
        public List<Person> Developers { get; set; }
        public int? ExpectedReleaseDay { get; set; }
        public int? ExpectedReleaseMonth { get; set; }
        public int? ExpectedReleaseQuarter { get; set; }
        public int? ExpectedReleaseYear { get; set; }
        public List<Character> FirstAppearanceCharacters { get; set; }
        public List<Concept> FirstAppearanceConcepts { get; set; }
        public List<Location> FirstAppearanceLocations { get; set; }
        public List<Object> FirstAppearanceObjects { get; set; }
        public List<Person> FirstAppearancePeople { get; set; }
        public List<Franchise> Franchises { get; set; }
        public List<Genre> Genres { get; set; }
        public int Id { get; set; }
        public Image Image { get; set; }
        public List<Image> Images { get; set; }
        public List<Character> KilledCharacters { get; set; }
        public List<Location> Locations { get; set; }
        public string Name { get; set; }
        public int NumberOfUserReviews { get; set; }
        public List<Object> Objects { get; set; }
        public string OriginalGameRating { get; set; }
        public DateTime? OriginalReleaseDate { get; set; }
        public List<Person> People { get; set; }
        public List<Platform> Platforms { get; set; }
        public List<Company> Publishers { get; set; }
        public List<Release> Releases { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Game> SimilarGames { get; set; }
        public string SiteDetailUrl { get; set; }
        public List<Theme> Themes { get; set; }
        public List<Video> Videos { get; set; }
    }
}
