using System;
using System.Collections.Generic;
using System.Text;
using FilmLibrary.Entities;
using FluentNHibernate.Mapping;

namespace FilmLibrary.Mapping
{
    class FormatMap : ClassMap<Format>
    {
        public FormatMap()
        {
            this.Table("Media_formats");

            this.Id(x => x.ID);
            this.Map(x => x.Name, "genre");
            this.HasMany(x => x.Movies);
        }
    }
}