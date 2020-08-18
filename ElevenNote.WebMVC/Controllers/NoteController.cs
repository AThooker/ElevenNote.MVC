using ElevenNote.Data;
using ElevenNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElevenNote.WebMVC.Controllers
{
    [Authorize]
    public class NoteController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        // GET: Note
        public ActionResult Index()
        {
            var model = new NoteListItem[0];
            return View();
        }

        //GET : Create
        public ActionResult Create()
        {
            return View();
        }

        //POST : Create 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NoteCreate model)
        {
            if (ModelState.IsValid)
            {
                //_db.Notes.Add(model);
                //_db.SaveChanges();
                //return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}