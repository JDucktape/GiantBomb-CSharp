﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GiantBomb.Api.Model {
    public class Release {
        public string ApiDetailUrl { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateLastUpdated { get; set; }
        public string Deck { get; set; }
        public string Description { get; set; }
        public List<Company> Developers { get; set; }
        public int? ExpectedReleaseDay { get; set; }
        public int? ExpectedReleaseMonth { get; set; }
        public int? ExpectedReleaseQuarter { get; set; }
        public int? ExpectedReleaseYear { get; set; }
        public Game Game { get; set; }
        public GameRating GameRating { get; set; }
        public int Id { get; set; }
        public Image Image { get; set; }
        public List<Image> Images { get; set; }
        public string Name { get; set; }
        public Platform Platform { get; set; }
        public string ProductCodeType { get; set; }
        public string ProductCodeValue { get; set; }
        public List<Company> Publishers { get; set; }
        public Region Region { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string SiteDetailUrl { get; set;  }
    }
}
