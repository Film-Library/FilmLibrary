namespace Movie.NH.Tests
{
    using Movies.Domain;
    using Infrastructure.Helpers;
    using NHibernate;
    using NUnit.Framework;
    using FluentNHibernate.Testing;
    using Movies.NH.Maps;

    /// <summary>
    /// Модульные тесты для класса <see cref="GenreMap"/>.
    /// </summary>
    [TestFixture]
    public class GenreMappingTest
    {
        private ISession session;

        [SetUp]
        public void Setup()
        {
            this.session = NHibernateTestHelper.GetSession(true, typeof(GenreMap).Assembly);
        }

        [Test]
        public void GenreMapping_NoNullFields_Success()
        {
            // act & arrange
            new PersistenceSpecification<Genre>(this.session)
                .CheckProperty(x => x.Title, "Ужасы")
                // TODO: Фильмы
                .VerifyTheMappings();
        }
    }
}
