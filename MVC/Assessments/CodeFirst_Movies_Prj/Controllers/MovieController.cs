using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirst_Movies_Prj.Models;
using CodeFirst_Movies_Prj.Repositorys;

namespace CodeFirst_Movies_Prj.Controllers
{
    public class MovieController : Controller
    {
        IMovieRepository _mv = null;
        public MovieController()
        {
            _mv = new MovieRepository();
        }
        // GET: Movie
        public ActionResult Index()
        {
            var mvd = _mv.GetAll();
            return View(mvd);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie m)
        {
            if (ModelState.IsValid)
            {
                _mv.Create(m);
                return RedirectToAction("Index");
            }
            return View(m);
        }
        public ActionResult Edit(int id)
        {
            var movie = _mv.GetById(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(Movie m)
        {
            if (ModelState.IsValid)
            {
                _mv.Edit(m);
                return RedirectToAction("Index");
            }
            else
            {
                return View(m);
            }
        }

         public ActionResult Delete(int id)
        {
            var movie = _mv.GetById(id);

            if (movie == null)
            {
                return HttpNotFound();  
            }
            return View(movie);  
        }

         [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
             var movie = _mv.GetById(id);

            if (movie != null)
            {
                _mv.Delete(movie);  
            }
            return RedirectToAction("Index");  
        }

        public ActionResult Details(int id)
        {
            var moviedetails = _mv.GetById(id);
            return View(moviedetails);
        }

        // Display movies by year
        public ActionResult MoviesByYear(int? year)
        {
            if (!year.HasValue)
            {
                return RedirectToAction("Index");
            }

            ViewBag.Year = year.Value;
            var movies = _mv.GetAllMoviesByYear(year.Value);
            return View(movies);
        }


        // Display movies names by DirectorName
        public ActionResult MoviesByDirectorName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return RedirectToAction("Index");  
            }

            ViewBag.DirectorName = name;
            var movies = _mv.GetAllMoviesByDirectorName(name);
            return View(movies);
        }

    }
}