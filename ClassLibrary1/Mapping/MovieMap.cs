using System;
using System.Collections.Generic;
using System.Text;
using FilmLibrary.Entities;
using FluentNHibernate.Mapping;

namespace FilmLibrary.Mapping
{
    class MovieMap : ClassMap<Movie>
    {
        public MovieMap()
        {
            this.Table("Movies");

            this.Id(x => x.ID);
            this.Map(x => x.Movie_name, "movie_name");
            this.Map(x => x.Issue_year, "issue_year");
            this.References(x => x.Genre_Id, "genre_id");
            this.References(x => x.Director_Id, "director_id");
            this.References(x => x.Country_Id, "country_id");
            this.References(x => x.Actor_Id, "actor_id");
            this.Map(x => x.Description, "description");
            this.References(x => x.Format_Id, "format_id");
            this.References(x => x.Quality_Id, "quality_id");


        }
    }
}