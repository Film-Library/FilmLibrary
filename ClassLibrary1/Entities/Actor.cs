using System;
using System.Collections.Generic;
using System.Text;

namespace FilmLibrary.Entities
{
    //Класс актеры
    public class Actor : Entity<Actor>
    {
        public int ID;
        public virtual Actor Name { get; set; }

        public virtual IList<Movie> Movies { get; set; }
        public Actor()
        {
            Movies = new List<Movie>();
        }
        public virtual Country Country_Id { get; set; }
    }
}
