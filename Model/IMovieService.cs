using System.Collections.Generic;

namespace FilterTutorial.Model
{
    public interface IMovieService
    {
        IReadOnlyCollection<Movie> GetAll();
        Movie GetById(int id);
        Movie Update(Movie movie);
        Movie Add(Movie movie);
    }
}