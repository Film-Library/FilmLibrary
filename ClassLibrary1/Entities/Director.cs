using System;
using System.Collections.Generic;
using System.Text;

namespace FilmLibrary.Entities
{
    //Класс режиссеры
    public class Director : Entity<Director>
    {
        public int ID;
        public virtual Director Name { get; set; }

        public virtual IList<Movie> Movies { get; set; }
        public Director()
        {
            Movies = new List<Movie>();
        }
    }
}
