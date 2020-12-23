namespace Movie.NH.Tests
{
    using FluentNHibernate.Testing;
    using Infrastructure.Helpers;
    using Movies.Domain;
    using Movies.NH.Maps;
    using NHibernate;
    using NUnit.Framework;
    using System.Collections.Generic;

    /// <summary>
    /// Модульные тесты для класса <see cref="ActorMap"/>.
    /// </summary>
    [TestFixture]
    public class ActorMappingTest
    {
        private ISession session;

        [SetUp]
        public void Setup()
        {
            this.session = NHibernateTestHelper.GetSession(true, typeof(ActorMap).Assembly);
        }

        [Test]
        public void ActorMapping_NoNullFields_Success()
        {
            // arrange
            var country = new Countrie("Гваделупа");

            var movies = new List<Movie>
            {
                new Movie("Фильм №1"),
                new Movie("Фильм №2"),
            };

            // act & assert
            new PersistenceSpecification<Actor>(this.session)
                .CheckProperty(x => x.Name, "Александр Петров")
                .CheckReference(x => x.Countrie, country, c => c.Id)
                .CheckList(x=> x.Movies, movies, movie => movie.Id)
                .VerifyTheMappings();
        }
    }
}
