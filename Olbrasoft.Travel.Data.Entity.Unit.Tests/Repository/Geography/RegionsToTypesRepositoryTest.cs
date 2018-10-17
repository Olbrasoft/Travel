using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Travel.Data.Entity.Model.Geography;
using Olbrasoft.Travel.Data.Entity.Repositories.Geography;

namespace Olbrasoft.Travel.Data.Entity.Unit.Tests.Repository.Geography
{
    [TestFixture]
    internal class RegionsToTypesRepositoryTest
    {
        [Test]
        public void Instance_Is_ManyToManyRepository_Of_RegionToType()
        {
            //Arrange
            var type = typeof(ManyToManyRepository<RegionToType>);
            var contextMock = new Mock<Entity.GeographyDatabaseContext>(); 


            //Act
            var repository = new RegionsToTypesRepository(contextMock.Object);

            //Assert
            Assert.IsInstanceOf(type,repository);

        }


    }
}