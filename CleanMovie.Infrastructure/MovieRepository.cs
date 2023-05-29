using CleanMovie.Application;
using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        //private readonly IMovieRepository _movieRepository;

        //public MovieRepository(IMovieRepository movieRepository)
        //{
        //    _movieRepository = movieRepository;
        //}
        public static List<Movie> movies = new List<Movie>()
        {
            new Movie{Id = 1, Name ="Redemption", Cost = 1},
            new Movie{Id = 2,Name="Titanic",Cost = 2}
        };
        public List<Movie> GetAllMovies()
        {
            return movies;
        }
    }
}
