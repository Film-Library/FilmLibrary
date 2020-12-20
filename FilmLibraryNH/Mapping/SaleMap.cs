using FilmLibrary.Entities;
using FluentNHibernate.Mapping;

namespace FilmLibrary.Mapping
{
    class SaleMap : ClassMap<Sale>
    {
        public SaleMap()
        {
            this.Table("Sales");

            this.Id(x => x.Id);
            this.References(x => x.Movie);
            this.Map(x => x.SaleDate);
            this.Map(x => x.Price);
        }
    }
}