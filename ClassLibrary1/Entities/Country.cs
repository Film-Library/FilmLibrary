using System;
using System.Collections.Generic;
using System.Text;

namespace FilmLibrary.Entities
{
    //Класс страны
    public class Country : Entity<Country>
    {
        public int ID;
        public virtual Country Name { get; set; }
        public virtual IList<Movie> Movies { get; set; }
        public virtual IList<Actor> Actors { get; set; }
        public Country()
        {
            Movies = new List<Movie>();
            Actors = new List<Actor>();
        }
    }
}
