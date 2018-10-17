using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Travel.Data.Entity.Model;
using Olbrasoft.Travel.Data.Entity.Model.Property;
using Olbrasoft.Travel.Data.Entity.Repository;
using Olbrasoft.Travel.Data.Entity.Repository.Property;

namespace Olbrasoft.Travel.Data.Entity.Unit.Tests.Repository.Property
{
    [TestFixture]
    internal class MappedPropertiesRepositoryTest
    {
        [Test]
        public void Instance_Is_PropertyRepository_Of_TypeOfAccommodation()
        {
            //Arrange
            var type = typeof(PropertyRepository<TypeOfAccommodation>);
            var contextMock = new Mock<Entity.PropertyDatabaseContext>();

            //Act
            var repository= new MappedPropertiesRepository<TypeOfAccommodation>(contextMock.Object);

            //Assert
            Assert.IsInstanceOf(type,repository);

        }
    }
}