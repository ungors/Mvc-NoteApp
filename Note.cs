using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TakeNote.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Explanation { get; set; }
        public bool Isdo { get; set; }
        public DateTime UploadDate { get; set; }
    }
}