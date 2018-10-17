using Moq;
using NUnit.Framework;
using Olbrasoft.Travel.Data.Entity.Model.Property;
using Olbrasoft.Travel.Data.Entity.Repositories.Property;

namespace Olbrasoft.Travel.Data.Entity.Unit.Tests.Repository.Property
{
    [TestFixture]
    internal class PhotosOfAccommodationsRepositoryTest
    {
        [Test]
        public void Instance_Is_PropertyRepository_Of_PhotoOfAccommodation()
        {
            //Arrange
            var type = typeof(PropertyRepository<PhotoOfAccommodation>);
            var contextMock = new Mock<PropertyDatabaseContext>();

            //Act
            var repository = new PhotosOfAccommodationsRepository(contextMock.Object);

            //Assert
            Assert.IsInstanceOf(type, repository);
        }
    }
}