using System;
using System.Collections.Generic;
using System.Linq;

namespace GiantBomb.Api.Model
{
    public class Chat
    {
        public string ApiDetailUrl { get; set; }
        public string ChannelName { get; set; }
        public string Deck { get; set; }
        public Image Image { get; set; }
        public string Password { get; set; }
        public string SiteDetailUrl { get; set; }
        public string Title { get; set; }
    }
}
