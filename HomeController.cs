using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TakeNote.Models;

namespace TakeNote.Controllers
{
    public class HomeController : Controller
    {
        private NoteContext context = new NoteContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(context.Notes.ToList().OrderByDescending(i => i.UploadDate));
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Note note)
        {
            note.Isdo = false;
            note.UploadDate = DateTime.Now;
            context.Notes.Add(note);
            context.SaveChanges();
            return View("Index",context.Notes.ToList());
        }
    }
}