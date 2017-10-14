using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TakeNote.Models
{
    public class NoteInitializer : DropCreateDatabaseIfModelChanges<NoteContext>
    {
        protected override void Seed(NoteContext context)
        {
            List<Note> notes = new List<Note>()
            {
                new Note(){ Explanation="Call James",Isdo=false,UploadDate=DateTime.Now.AddDays(0) },
                new Note(){ Explanation="Go to the shop",Isdo=true,UploadDate=DateTime.Now.AddDays(-3) }
            };

            foreach (var note in notes)
            {
                context.Notes.Add(note);
            }

            context.SaveChanges();
            base.Seed(context);
        }
    }
}