namespace Movies.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Infrastructure.Extensions;
    using Movies.Domain;
    using Movies.NH.Repositories;

    public class DirectorService : IDirectorService
    {
        private readonly IDirectorRepository directorRepository;

        //private readonly IMovieRepository movieRepository;

        public DirectorService(IDirectorRepository directorRepository)
        {
            this.directorRepository = directorRepository ?? throw new ArgumentNullException(nameof(directorRepository));
        }


        public List<Director> GetAll()
        {
            return this.directorRepository.GetAll().ToList();
        }

        public List<Movie> GetAllMoviesByDirectorId(int id)
        {
            return this.directorRepository.GetAll().FirstOrDefault(x => x.Id == id)?.Movie.ToList();
        }
    }
}
