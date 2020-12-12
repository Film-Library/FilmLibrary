using System;
using System.Collections.Generic;
using System.Text;
using FilmLibrary.Entities;
using FluentNHibernate.Mapping;

namespace FilmLibrary.Mapping
{
    public class GenreMap : ClassMap<Genre>
    {
        public GenreMap()
        {
            this.Table("Genres");

            this.Id(x => x.ID);
            this.Map(x => x.Name, "genre");
            this.HasMany(x => x.Movies);
        }

    }
}
