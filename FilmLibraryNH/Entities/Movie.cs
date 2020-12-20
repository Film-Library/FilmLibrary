namespace FilmLibrary.Entities
{
    /// <summary>
    /// Класс фильм
    /// </summary>
    public class Movie : Entity<Movie>
    {
        /// <summary>
        /// Название фильма
        /// </summary>
        public virtual string MovieName { get; protected set; }

        /// <summary>
        /// Год выпуска фильма
        /// </summary>
        public virtual int IssueYear { get; protected set; }

        /// <summary>
        /// Жанр фильма
        /// </summary>
        public virtual Genre Genre { get; protected set; }

        /// <summary>
        /// Режиссер фильма
        /// </summary>
        public virtual Director Director { get; protected set; }

        /// <summary>
        /// Страна производства фильма
        /// </summary>
        public virtual Country Country { get; protected set; }

        /// <summary>
        /// Главный актер фильма
        /// </summary>
        public virtual Actor Actor { get; protected set; }

        /// <summary>
        /// Описание фильма
        /// </summary>
        public virtual string Description { get; protected set; }

        /// <summary>
        /// Формат фильма
        /// </summary>
        public virtual Format Format { get; protected set; }

        /// <summary>
        /// Качество фильма
        /// </summary>
        public virtual Quality Quality { get; protected set; }
    }
}
