using FilmLibrary.Entities;
using FluentNHibernate.Mapping;

namespace FilmLibrary.Mapping
{
    class QualityMap : ClassMap<Quality>
    {
        public QualityMap()
        {
            this.Table("Qualities");
            this.Id(x => x.Id);
            this.Map(x => x.Name);
            this.HasMany(x => x.Movies);
        }
    }
}