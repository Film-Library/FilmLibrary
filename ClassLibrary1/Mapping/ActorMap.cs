using System;
using System.Collections.Generic;
using System.Text;
using FilmLibrary.Entities;
using FluentNHibernate.Mapping;

namespace FilmLibrary.Mapping
{
    class ActorMap : ClassMap<Actor>
    {

        public ActorMap()
        {
            this.Table("Actors");


            this.Id(x => x.ID);
            this.Map(x => x.Name, "actor");
            this.References(x => x.Country_Id);
            this.HasMany(x => x.Movies);
        }
    }
}