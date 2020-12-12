using System;
using System.Collections.Generic;
using System.Text;
using FilmLibrary.Entities;
using FluentNHibernate.Mapping;

namespace FilmLibrary.Mapping
{
    class SaleMap : ClassMap<Sale>
    {
        public SaleMap()
        {
            this.Table("Sales");

            this.Id(x => x.ID);
            this.References(x => x.Movie_Id, "movie_id");
            this.Map(x => x.Sale_date, "sale_date");
            this.Map(x => x.Price, "price");
        }
    }
}