using System.Collections.Generic;

namespace FilmLibrary.Entities
{
    /// <summary>
    /// класс актёр
    /// </summary>
    public class Actor : Entity<Actor>
    {
        /// <summary>
        /// Имя актера
        /// </summary>
        public virtual Actor Name { get; protected set; }

        /// <summary>
        /// Фильмы, в которых актер снимался
        /// </summary>
        public virtual IList<Movie> Movies { get; protected set; }
        public Actor()
        {
            Movies = new List<Movie>();
        }

        /// <summary>
        /// Страна происхождения актера
        /// </summary>
        public virtual Country Country { get; protected set; }
    }
}
