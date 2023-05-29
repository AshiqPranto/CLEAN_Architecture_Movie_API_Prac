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
        private readonly MovieDbContext _movieDbContext;

        //private readonly IMovieRepository _movieRepository;

        //public MovieRepository(IMovieRepository movieRepository)
        //{
        //    _movieRepository = movieRepository;
        //}
        //public static List<Movie> movies = new List<Movie>()
        //{
        //    new Movie{Id = 1, Name ="Redemption", Cost = 1},
        //    new Movie{Id = 2,Name="Titanic",Cost = 2}
        //};
        public MovieRepository(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }

        public Movie CreateMovie(Movie movie)
        {
            _movieDbContext.Movies.Add(movie);
            _movieDbContext.SaveChanges();

            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            return _movieDbContext.Movies.ToList();
        }
    }
}
