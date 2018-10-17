using Moq;
using NUnit.Framework;
using Olbrasoft.Travel.Data.Entity.Repository;
using Olbrasoft.Travel.Data.Entity.Repository.Geography;

namespace Olbrasoft.Travel.Data.Entity.Unit.Tests.Repository.Geography
{
    [TestFixture]
    internal class AdditionalRegionsInfoRepositoryTest
    {
        [Test]
        public void Instance_Is_GeographyRepository_Of_CreatorInfo()
        {
            //Arrange
            var type = typeof(GeographyRepository<Data.Entity.Model.Geography.Country>);
            var context = new Mock<GeographyDatabaseContext>();

            //Act
            var repository = new AdditionalRegionsInfoRepository<Model.Geography.Country>(context.Object);

            //Assert
            Assert.IsInstanceOf(type, repository);
        }
    }
}