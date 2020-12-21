namespace Movies.NH.Maps
{
    using FluentNHibernate.Mapping;
    using Movies.Domain;

    public class ActorMap : ClassMap<Actor>
    {
        public ActorMap()
        {
            this.Table("FilmLabDB.Actors");

            this.Id(x => x.Id);

            this.Map(x => x.Name).Column("actor");

            this.References(x => x.Countrie).Column("country_id");

            this.HasMany(x => x.Movies);
        }
    }
}
