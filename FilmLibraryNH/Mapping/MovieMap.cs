using FilmLibrary.Entities;
using FluentNHibernate.Mapping;

namespace FilmLibrary.Mapping
{
    class MovieMap : ClassMap<Movie>
    {
        public MovieMap()
        {
            this.Table("Movies");

            this.Id(x => x.Id);
            this.Map(x => x.MovieName);
            this.Map(x => x.IssueYear);
            this.References(x => x.Genre);
            this.References(x => x.Director);
            this.References(x => x.Country);
            this.References(x => x.Actor);
            this.Map(x => x.Description);
            this.References(x => x.Format);
            this.References(x => x.Quality);
        }
    }
}