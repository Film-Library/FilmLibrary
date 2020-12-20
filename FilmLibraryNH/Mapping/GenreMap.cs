using FilmLibrary.Entities;
using FluentNHibernate.Mapping;

namespace FilmLibrary.Mapping
{
    public class GenreMap : ClassMap<Genre>
    {
        public GenreMap()
        {
            this.Table("Genres");

            this.Id(x => x.Id);
            this.Map(x => x.Name);
            this.HasMany(x => x.Movies);
        }

    }
}
