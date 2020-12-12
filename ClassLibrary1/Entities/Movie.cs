using System;
using System.Collections.Generic;
using System.Text;

namespace FilmLibrary.Entities
{
    public class Movie : Entity<Movie>
    {
        public int ID;
        public virtual string Movie_name { get; set; }
        public virtual int Issue_year { get; set; }
        public virtual Genre Genre_Id { get; set; }
        public virtual Director Director_Id { get; set; }
        public virtual Country Country_Id { get; set; }
        public virtual Actor Actor_Id { get; set; }
        public virtual string Description { get; set; }
        public virtual Format Format_Id { get; set; }
        public virtual Quality Quality_Id { get; set; }
    }
}
