namespace Movies.NH.Maps
{
    using FluentNHibernate.Mapping;
    using Movies.Domain;

    /// <summary>
    /// Класс, описывающий правила отображения сущности <see cref="Actor"/> на таблицу БД.
    /// </summary>
    public class ActorMap : ClassMap<Actor>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ActorMap"/>.
        /// </summary>
        public ActorMap()
        {
            this.Schema("FilmLibrary");
            this.Table("Actors");

            this.Id(x => x.Id);

            this.Map(x => x.Name, "actor");

            this.References(x => x.Countrie, "country_id")
                .ForeignKey("FK_Actors_Countries");

            this.HasMany(x => x.Movies);
        }
    }
}
