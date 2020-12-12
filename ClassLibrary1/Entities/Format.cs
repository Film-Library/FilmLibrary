using System;
using System.Collections.Generic;
using System.Text;

namespace FilmLibrary.Entities
{
    //Класс форматы
    public class Format : Entity<Format>
    {
        public int ID;
        public virtual Format Name { get; set; }

        public virtual IList<Movie> Movies { get; set; }
        public Format()
        {
            Movies = new List<Movie>();
        }
    }
}
