﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GiantBomb.Api.Model
{
    public class GameRating
    {
        public string ApiDetailUrl { get; set; }
        public int Id { get; set; }
        public Image Image { get; set; }
        public string Name { get; set; }
        public RatingBoard RatingBoard { get; set; }
    }
}
