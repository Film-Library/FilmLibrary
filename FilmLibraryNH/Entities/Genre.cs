using System.Collections.Generic;

namespace FilmLibrary.Entities
{
    /// <summary>
    /// Класс жанр
    /// </summary>
    public class Genre : Entity<Genre>
    {
        /// <summary>
        /// Название жанра
        /// </summary>
        public virtual  Genre Name {get; protected set; }

        /// <summary>
        /// Фильмы, соответсвующие жанру
        /// </summary>
        public virtual IList<Movie> Movies { get; protected set; }
        public Genre()
        {
            Movies = new List<Movie>();
        }


    }

}
