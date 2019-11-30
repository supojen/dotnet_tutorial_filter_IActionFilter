using System.Collections.Generic;

namespace FilterTutorial.Model
{
    public class InMemoryMovieService : IMovieService
    {
        List<Movie> _movies = new List<Movie>();
        public InMemoryMovieService()
        {
            _movies.Add(
                new Movie {
                    Id = 1,
                    Name = "Jack in the box.",
                    Genre = "Horror",
                    Director = "Jack"
                }
            );

            _movies.Add(
                new Movie {
                    Id = 2,
                    Name = "Po's road to boxer.",
                    Genre = "Comedy",
                    Director = "Po Jen SU"
            });
        }
        public Movie Add(Movie movie)
        {
            _movies.Add(movie);
            return movie;
        }

        public IReadOnlyCollection<Movie> GetAll()
        {
            return _movies.AsReadOnly();
        }

        public Movie GetById(int id)
        {
            return _movies.Find(m => m.Id == id);
        }

        public Movie Update(Movie movie)
        {
            var entity = _movies.Find(m => m.Id == movie.Id);
            entity.Name = movie.Name;
            entity.Genre = movie.Genre;
            entity.Director = movie.Director;
            
            return entity;
        }
    }
}