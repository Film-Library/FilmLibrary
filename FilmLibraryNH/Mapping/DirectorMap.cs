using FilmLibrary.Entities;
using FluentNHibernate.Mapping;

namespace FilmLibrary.Mapping
{
    class DirectorMap : ClassMap<Director>
    {
        public DirectorMap()
        {
            this.Table("Directors");

            this.Id(x => x.Id);
            this.Map(x => x.Name);
            this.HasMany(x => x.Movies);
        }
    }
}