using System;
using System.Collections.Generic;
using System.Text;

namespace FilmLibrary.Entities
{
    //Класс жанры
    public class Genre : Entity<Genre>
    {
        public  int ID;
        public virtual  Genre Name {get; set; }

        public virtual IList<Movie> Movies { get; set; }
        public Genre()
        {
            Movies = new List<Movie>();
        }


    }

}
