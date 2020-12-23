namespace TestORMLibrary
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using NHibernate;

    using Movies.Domain;
    using Movies.NH.Repositories;
    using Movies.Services;

    class App
    {
       private readonly IDirectorService directorService;

        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
        /// <param name="directorService"> </param>
        public App(IDirectorService directorService)
        {
            this.directorService = directorService ?? throw new ArgumentNullException(nameof(directorService));
        }

        /// <summary>
        /// Метод запуска приложения.
        /// </summary>
        /// <returns> Успешно завершённая задача. </returns>
        public async Task Run()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var directorId = 1;

            var movies = this.directorService.GetAllMoviesByDirectorId(directorId);
            foreach (var item in movies)
            {
                Console.WriteLine(item);
            }

           

            await Task.CompletedTask;
        }
    }
}
