using FilmLibrary.Entities;
using FluentNHibernate.Mapping;

namespace FilmLibrary.Mapping
{
    class ActorMap : ClassMap<Actor>
    {

        public ActorMap()
        {
            this.Table("Actors");


            this.Id(x => x.Id);
            this.Map(x => x.Name);
            this.References(x => x.Country);
            this.HasMany(x => x.Movies);
        }
    }
}