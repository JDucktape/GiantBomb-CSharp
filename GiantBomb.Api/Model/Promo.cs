using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GiantBomb.Api.Model
{
    public class Promo
    {
        public string ApiDetailUrl { get; set; }
        public DateTime DateAdded { get; set; }
        public string Deck { get; set; }
        public int Id { get; set; }
        public Image Image { get; set; }
        public string Link { get; set; } // TODO: Check data to see if it is URI instead?
        public string Name { get; set; }
        public ResourceTypes ResourceType { get; set; }
        public Person User { get; set; } // TODO: Check data to see if this is a Person or a string
    }
}
