using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        // GET: ComicBooks
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Hello Description</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "John", Role = "Support" },
                    new Artist() { Name = "Bob", Role = "Doodler" },
                    new Artist() { Name = "Ross", Role = "Painter" }
                }
            };
            return View(comicBook);
        }
    }
}