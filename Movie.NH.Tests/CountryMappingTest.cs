namespace Movie.NH.Tests
{
    using FluentNHibernate.Testing;
    using Infrastructure.Helpers;
    using Movies.Domain;
    using Movies.NH.Maps;
    using NHibernate;
    using NUnit.Framework;

    /// <summary>
    /// Модульные тесты для класса <see cref="CountryMap"/>
    /// </summary>
    [TestFixture]
    public class CountryMappingTest
    {
        private ISession session;

        [SetUp]
        public void Setup()
        {
            this.session = NHibernateTestHelper.GetSession(true, typeof(CountryMap).Assembly);
        }

        [Test]
        public void CountryMapping_NoNullFields_Success()
        {
            // act & assert
            new PersistenceSpecification<Countrie>(this.session)
                .CheckProperty(x => x.Name, "Страна ОЗ")
                // TODO: Фильмы и актеры
                .VerifyTheMappings();
        }
    }
}
