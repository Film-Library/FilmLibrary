using System;
using System.Collections.Generic;
using System.Text;

namespace FilmLibrary.Entities
{
    public class Sale : Entity<Sale>
    {
        public int ID;
        public virtual Movie Movie_Id { get; set; }
        public virtual DateTime Sale_date { get; set; }
        public virtual int Price { get; set; }

    }
}
