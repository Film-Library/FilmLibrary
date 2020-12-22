namespace Movies.NH.Maps
{
    using FluentNHibernate.Mapping;
    using Movies.Domain;

    class SaleMap : ClassMap<Sale>
    {
        public SaleMap()
        {
            this.Schema("FilmLabDB");

            this.Table("Sales");

            this.Id(x => x.Id);

            this.Map(x => x.IdMovie).Column("movie_id");

            this.Map(x => x.Price).Column("price");

            this.Map(x => x.SaleDate).Column("sale_date");

            this.HasMany(x => x.Movies);
        }
    }
}