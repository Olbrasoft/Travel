using Moq;
using NUnit.Framework;
using Olbrasoft.Travel.Data.Entity.Model.Globalization;
using Olbrasoft.Travel.Data.Entity.Model.Property;
using Olbrasoft.Travel.Data.Entity.Repositories;
using Olbrasoft.Travel.Data.Entity.Repositories.Globalization;
using Olbrasoft.Travel.Data.Entity.Repositories.Property;
using Olbrasoft.Travel.Data.Repository;
using Olbrasoft.Travel.Data.Repository.Globalization;

namespace Olbrasoft.Travel.Data.Entity.Unit.Tests.Repository.Property
{
    [TestFixture]
    internal class LocalizedRepositoryTest
    {
        [Test]
        public void Instance_Is_OfLocalized_Of_LocalizedTypeOfAccommodation()
        {
            //Arrange
            var type = typeof(LocalizedRepository<LocalizedTypeOfAccommodation>);

            //Act
            var repository = LocalizedRepository();

            //Assert
            Assert.IsInstanceOf(type, repository);
        }

        [Test]
        public void Instance_Implement_Interface_ILocalizedRepository_Of_LocalizedTypeOfAccommodation()
        {
            //Arrange
            var type =
                typeof(IOfLocalized<LocalizedTypeOfAccommodation>);

            //Act
            var repository = LocalizedRepository();

            //Assert
            Assert.IsInstanceOf(type, repository);
        }

        private static LocalizedRepository<LocalizedTypeOfAccommodation> LocalizedRepository()
        {
            var contextMock = new Mock<GlobalizationDatabaseContext>();
            var repository = new LocalizedRepository<LocalizedTypeOfAccommodation>(contextMock.Object);
            return repository;
        }
    }
}