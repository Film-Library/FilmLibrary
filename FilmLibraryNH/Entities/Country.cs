using System.Collections.Generic;

namespace FilmLibrary.Entities
{
    /// <summary>
    /// Класс страна
    /// </summary>
    public class Country : Entity<Country>
    {
        /// <summary>
        /// Название страны
        /// </summary>
        public virtual Country Name { get; protected set; }

        /// <summary>
        /// Фильмы, произведенные в стране
        /// </summary>
        public virtual IList<Movie> Movies { get; protected set; }

        /// <summary>
        /// Актеры, родом из страны
        /// </summary>
        public virtual IList<Actor> Actors { get; protected set; }
        public Country()
        {
            Movies = new List<Movie>();
            Actors = new List<Actor>();
        }
    }
}
