using FilmLibrary.Entities;
using FluentNHibernate.Mapping;

namespace FilmLibrary.Mapping
{
    class FormatMap : ClassMap<Format>
    {
        public FormatMap()
        {
            this.Table("Media_formats");

            this.Id(x => x.Id);
            this.Map(x => x.Name);
            this.HasMany(x => x.Movies);
        }
    }
}