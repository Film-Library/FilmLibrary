using System;
using System.Collections.Generic;
using System.Text;
using FilmLibrary.Entities;
using FluentNHibernate.Mapping;

namespace FilmLibrary.Mapping
{
    class QualityMap : ClassMap<Quality>
    {
        public QualityMap()
        {
            this.Table("Qualities");
            this.Id(x => x.ID);
            this.Map(x => x.Name, "quality");
            this.HasMany(x => x.Movies);
        }
    }
}