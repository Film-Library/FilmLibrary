namespace Movie.NH.Tests
{
    using FluentNHibernate.Testing;
    using Infrastructure.Helpers;
    using Movies.Domain;
    using Movies.NH.Maps;
    using NHibernate;
    using NUnit.Framework;

    /// <summary>
    /// Модульные тесты для класса <see cref="DirectorMap"/>.
    /// </summary>
    [TestFixture]
    public class DirectorMappingTest
    {
        private ISession session;

        [SetUp]
        public void Setup()
        {
            this.session = NHibernateTestHelper.GetSession(true, typeof(DirectorMap).Assembly);
        }

        [Test]
        public void DirectorMapping_NoNullFields_Success()
        {
            // act & assert
            new PersistenceSpecification<Director>(this.session)
                .CheckProperty(x => x.Name, "Гай Ричи")
                // TODO: Фильмы
                .VerifyTheMappings();
        }
    }
}
