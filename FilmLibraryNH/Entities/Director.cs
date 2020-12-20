using System.Collections.Generic;

namespace FilmLibrary.Entities
{
    /// <summary>
    /// Имя режиссер
    /// </summary>
    public class Director : Entity<Director>
    {
        /// <summary>
        /// Имя режиссера
        /// </summary>
        public virtual Director Name { get; protected set; }

        /// <summary>
        /// Фильмы, которые снял режиссер
        /// </summary>
        public virtual IList<Movie> Movies { get; protected set; }
        public Director()
        {
            Movies = new List<Movie>();
        }
    }
}
