namespace Movie.NH.Tests
{
    using Movies.Domain;
    using Infrastructure.Helpers;
    using NHibernate;
    using NUnit.Framework;
    using FluentNHibernate.Testing;
    using Movies.NH.Maps;

    /// <summary>
    /// Модульные тесты для класса <see cref="MovieMap"/>.
    /// </summary>
    [TestFixture]
    public class MovieMappingTest
    {
        private ISession session;

        [SetUp]
        public void Setup()
        {
            this.session = NHibernateTestHelper.GetSession(true, typeof(MovieMap).Assembly);
        }

        [Test]
        public void ActorMapping_NoNullFields_Success()
        {
            // arrange
            var country = new Countrie("Эфиопия");
            var actor = new Actor("Александр Петров");
            var director = new Director("Квентин Тарантино");
            var genre = new Genre("Боевик");
            var quality = new Quality("4k");
            var mediaFormat = new MediaFormat("DVD");

            // act & assert
            // TODO: Нужно что-то делать с CustomEqualityComparer
            new PersistenceSpecification<Movie>(this.session/*, new CustomEqualityComparer()*/)
                .CheckProperty(x => x.Name, "Фильм")
                .CheckProperty(x => x.Year, 2020)
                .CheckProperty(x=>x.Description, "Описание фильма")
                .CheckReference(x => x.Actor, actor, a => a.Id)
                .CheckReference(x => x.Countrie, country, c => c.Id)
                .CheckReference(x => x.Director, director, d => d.Id)
                .CheckReference(x => x.Genre, genre, g => g.Id)
                .CheckReference(x => x.Quality, quality, q => q.Id)
                .CheckReference(x => x.MediaFormat, mediaFormat, f => f.Id)
                .VerifyTheMappings();
        }
    }
}
