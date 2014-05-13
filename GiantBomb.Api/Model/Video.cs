using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GiantBomb.Api.Model
{
    public class Video
    {
        public string ApiDetailUrl { get; set; }
        public string Deck { get; set; }
        public string HdUrl { get; set; }
        public string HighUrl { get; set; }
        public int Id { get; set; }
        public Image Image { get; set; }
        public int LengthSeconds { get; set; }
        public string LowUrl { get; set; }
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
        public string SiteDetailUrl { get; set; }
        public string Url { get; set; }
        public Person User { get; set; } // TODO: Determine if this is a string or a Person
        public string YoutubeId { get; set; } // TODO: Determine if this is a string or an int
    }
}
