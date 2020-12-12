using System;
using System.Collections.Generic;
using System.Text;
using FilmLibrary.Entities;
using FluentNHibernate.Mapping;

namespace FilmLibrary.Mapping
{
    class DirectorMap : ClassMap<Director>
    {
        public DirectorMap()
        {
            this.Table("Directors");
            this.Id(x => x.ID);
            this.Map(x => x.Name, "director");
            this.HasMany(x => x.Movies);
        }
    }
}