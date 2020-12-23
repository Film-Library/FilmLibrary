namespace Movies.Services
{
    using System.Collections.Generic;
    using Movies.Domain;

    public interface IDirectorService
    {
        //bool TryGet(int id, out Director teacher);

        List<Director> GetAll();

        List<Movie> GetAllMoviesByDirectorId(int id);

        //List<Director> GetAll();

        //List<Movie> GetMoviesByDirectorId(int id);
    }
}