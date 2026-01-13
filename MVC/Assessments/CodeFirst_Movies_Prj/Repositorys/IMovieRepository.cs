using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst_Movies_Prj.Models;
namespace CodeFirst_Movies_Prj.Repositorys
{
    internal interface IMovieRepository
    {
        IEnumerable<Movie> GetAllMoviesByYear(int year);
        IEnumerable<Movie> GetAllMoviesByDirectorName(string name);
        IEnumerable<Movie> GetAll();
        Movie GetById(int id);
        void Create(Movie movie);
        void Edit(Movie movie);
        void Delete(Movie movie);
    }
}
