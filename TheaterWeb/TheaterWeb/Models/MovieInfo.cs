﻿using System;
using System.Collections.Generic;

namespace TheaterWeb.Models
{
    public class MovieInfo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? Time { get; set; }
        public string Genre { get; set; }
        public string Desc { get; set; }
    }
}
