using System;
using System.Collections.Generic;
using System.Text;
using FilmLibrary.Entities;
using FluentNHibernate.Mapping;

namespace FilmLibrary.Mapping
{
    class CountryMap : ClassMap<Country>
    {
        public CountryMap()
        {
            this.Table("Countries");
            this.Id(x => x.ID);
            this.Map(x => x.Name, "country");
            this.HasMany(x => x.Actors);
            this.HasMany(x => x.Movies);
        }
    }
}