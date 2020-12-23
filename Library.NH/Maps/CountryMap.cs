namespace Movies.NH.Maps
{
    using FluentNHibernate.Mapping;
    using Movies.Domain;

    public class CountryMap : ClassMap<Countrie>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CountryMap"/>.
        /// </summary>
        public CountryMap()
        {
            this.Table("Countries");

            this.Id(x => x.Id);

            this.Map(x => x.Name, "country");

            this.HasMany(x => x.Movies);

            this.HasMany(x => x.Actors);
        }
    }
}
