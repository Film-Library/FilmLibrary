using FilmLibrary.Entities;
using FluentNHibernate.Mapping;

namespace FilmLibrary.Mapping
{
    class CountryMap : ClassMap<Country>
    {
        public CountryMap()
        {
            this.Table("Countries");
            this.Id(x => x.Id);
            this.Map(x => x.Name);
            this.HasMany(x => x.Actors);
            this.HasMany(x => x.Movies);
        }
    }
}