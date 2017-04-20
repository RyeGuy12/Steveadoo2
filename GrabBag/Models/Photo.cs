using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrabBag.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public byte[] File { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public DateTime? Date { get; set; }
        public bool IsActive { get; set; }
    }
}