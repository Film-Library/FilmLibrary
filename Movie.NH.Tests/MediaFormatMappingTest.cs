namespace Movie.NH.Tests
{
    using FluentNHibernate.Testing;
    using Infrastructure.Helpers;
    using Movies.Domain;
    using Movies.NH.Maps;
    using NHibernate;
    using NUnit.Framework;

    /// <summary>
    /// Модульные тесты для класса <see cref="MediaFormatMap"/>.
    /// </summary>
    [TestFixture]
    public class MediaFormatMappingTest
    {
        private ISession session;

        [SetUp]
        public void Setup()
        {
            this.session = NHibernateTestHelper.GetSession(true, typeof(MediaFormatMap).Assembly);
        }

        [Test]
        public void MediaFormatMapping_NoNullFields_Success()
        {
            // act & assert
            new PersistenceSpecification<MediaFormat>(this.session)
                .CheckProperty(x => x.Name, "DVD")
                // TODO: Фильмы
                .VerifyTheMappings();
        }
    }
}
