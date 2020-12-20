using System.Collections.Generic;

namespace FilmLibrary.Entities
{
    /// <summary>
    /// Класс качество
    /// </summary>
    public class Quality : Entity<Quality>
    {
        /// <summary>
        /// Название типа качества
        /// </summary>
        public virtual Quality Name { get; protected set; }

        /// <summary>
        /// Фильмы ,соответствующие качеству
        /// </summary>
        public virtual IList<Movie> Movies { get; protected set; }
        public Quality()
        {
            Movies = new List<Movie>();
        }
    }
}
