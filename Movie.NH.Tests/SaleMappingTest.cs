namespace Movie.NH.Tests
{
    using FluentNHibernate.Testing;
    using Infrastructure.Helpers;
    using Movies.Domain;
    using Movies.NH.Maps;
    using NHibernate;
    using NUnit.Framework;
    using System;

    /// <summary>
    /// Модульный тест для класса <see cref="SaleMap"/>.
    /// </summary>
    [TestFixture]
    public class SaleMappingTest
    {
        private ISession session;

        [SetUp]
        public void Setup()
        {
            this.session = NHibernateTestHelper.GetSession(true, typeof(SaleMap).Assembly);
        }

        [Test]
        public void ActorMapping_NoNullFields_Success()
        {
            // arrange
            var saleDate = new DateTime(2019, 12, 31);

            // act & assert
            new PersistenceSpecification<Sale>(this.session)
                .CheckProperty(x => x.IdMovie, 1)
                .CheckProperty(x => x.Price, 900)
                .CheckProperty(x => x.SaleDate, saleDate)
                // TODO: Фильмы
                .VerifyTheMappings();
        }
    }
}
