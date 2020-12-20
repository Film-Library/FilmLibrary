using System;

namespace FilmLibrary.Entities
{
    /// <summary>
    /// Класс продаж
    /// </summary>
    public class Sale : Entity<Sale>
    {
        /// <summary>
        /// Название проданного фильма
        /// </summary>
        public virtual Movie Movie { get; protected set; }

        /// <summary>
        /// Дата продажи фильма
        /// </summary>
        public virtual DateTime SaleDate { get; protected set; }

        /// <summary>
        /// Цена фильма
        /// </summary>
        public virtual int Price { get; protected set; }

    }
}
