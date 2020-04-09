using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyApp.Models;

namespace VidlyApp.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            var movies = movie();
            return View(movies);
        }

        private List<Movies> movie()
        {
            return new List<Movies>
            {
                new Movies() {Id = 1, Name = "good movie"},
                new Movies() {Id = 2, Name = "bad movie"}
            };
        }
    }
}