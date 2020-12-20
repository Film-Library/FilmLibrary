using System.Collections.Generic;

namespace FilmLibrary.Entities
{
    /// <summary>
    /// Класс формат
    /// </summary>
    public class Format : Entity<Format>
    {
        /// <summary>
        /// Название формата
        /// </summary>
        public virtual Format Name { get; protected set; }

        /// <summary>
        /// Фильмы, соответсвующие формату
        /// </summary>
        public virtual IList<Movie> Movies { get; protected set; }
        public Format()
        {
            Movies = new List<Movie>();
        }
    }
}
