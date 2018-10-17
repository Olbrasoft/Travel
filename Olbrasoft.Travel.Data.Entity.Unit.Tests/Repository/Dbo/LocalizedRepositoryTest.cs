using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Travel.Data.Entity.Model;
using Olbrasoft.Travel.Data.Entity.Repository.Globalization;
using Olbrasoft.Travel.Data.Repository;
using Olbrasoft.Travel.Data.Repository.Geography;
using Olbrasoft.Travel.Data.Repository.Globalization;
using Olbrasoft.Travel.Data.Repository.Property;

namespace Olbrasoft.Travel.Data.Entity.Unit.Tests.Repository.Dbo
{
    [TestFixture]
    internal class LocalizedRepositoryTest
    {
        [Test]
        public void Instance_Is_OfLocalized()
        {
            //Arrange
            var type = typeof(LocalizedRepository<Localized>);

            //Act
            var repository = LocalizedRepository();

            //Assert
            Assert.IsInstanceOf(type, repository);
        }

       
        [Test]
        public void Instance_Implement_Interface_ILocalizedRepository()
        {
            //Arrange
            var type = typeof(IOfLocalized<Localized>);

            //Act
            var repository = LocalizedRepository();

            //Assert
            Assert.IsInstanceOf(type,repository);
        }

        private static LocalizedRepository<Localized> LocalizedRepository()
        {
            var contextMock = new Mock<GlobalizationDatabaseContext>();

            var repository = new LocalizedRepository<Localized>(contextMock.Object);
            return repository;
        }
    }
}