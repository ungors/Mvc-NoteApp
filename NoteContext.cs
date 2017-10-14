using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TakeNote.Models
{
    public class NoteContext:DbContext
    {
        public NoteContext():base("noteDb")
        {
            Database.SetInitializer(new NoteInitializer());
        }
        public DbSet<Note> Notes { get; set; }
    }
}