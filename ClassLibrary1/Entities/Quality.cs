using System;
using System.Collections.Generic;
using System.Text;

namespace FilmLibrary.Entities
{
    //Класс качество
    public class Quality : Entity<Quality>
    {
        public int ID;

        public virtual Quality Name { get; set; }
        public virtual IList<Movie> Movies { get; set; }
        public Quality()
        {
            Movies = new List<Movie>();
        }
    }
}
