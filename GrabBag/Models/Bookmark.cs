﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrabBag.Models
{
    public class Bookmark
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }
    }
}