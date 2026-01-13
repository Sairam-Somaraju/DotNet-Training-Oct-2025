using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CodeFirst_Movies_Prj.Models;

namespace CodeFirst_Movies_Prj.Repositorys
{
    public class MovieRepository: IMovieRepository
    {
        MovieContext db;
        public MovieRepository()
        {
            db = new MovieContext();
        }
        public IEnumerable<Movie> GetAllMoviesByYear(int year)
        {
            return db.movie.Where(m => m.DateofRelease.Year == year).ToList();
        }

        public IEnumerable<Movie> GetAllMoviesByDirectorName(string name)
        {
            return db.movie.Where(m=>m.DirectorName == name).ToList();
        }

        public void Edit(Movie movie)
        {
            db.Entry(movie).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(Movie movie)
        {
            if (movie != null)
            {
                db.movie.Remove(movie);
                db.SaveChanges();
            }
        }
        public void Create(Movie movie)
        {

            db.movie.Add(movie);
            db.SaveChanges();
        }
        public IEnumerable<Movie> GetAll()
        {
            return db.movie.ToList();
        }
        public Movie GetById(int id)
        {
            return db.movie.Find(id);
        }
    }
}