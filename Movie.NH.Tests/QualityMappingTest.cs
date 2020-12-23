namespace Movie.NH.Tests
{
    using FluentNHibernate.Testing;
    using Infrastructure.Helpers;
    using Movies.Domain;
    using Movies.NH.Maps;
    using NHibernate;
    using NUnit.Framework;

    /// <summary>
    /// Модульный тест для класса <see cref="QualityMap"/>.
    /// </summary>
    [TestFixture]
    public class QualityMappingTest
    {
        private ISession session;

        [SetUp]
        public void Setup()
        {
            this.session = NHibernateTestHelper.GetSession(true, typeof(QualityMap).Assembly);
        }

        [Test]
        public void ActorMapping_NoNullFields_Success()
        {
            // act & assert
            new PersistenceSpecification<Quality>(this.session)
                .CheckProperty(x => x.Title, "1080")
                // TODO: Фильмы
                .VerifyTheMappings();
        }
    }
}
