using Moq;
using NUnit.Framework;

namespace Olbrasoft.Data.Unit.Tests
{
    [TestFixture]
    public class QueryManagerTest
    {
        [Test]
        public void QueryManager_Is_Instance_Of_IQueryManager()
        {
            //Arrange
            var type = typeof(IQueryManager);

            //Act
            var queryManager = GetQueryManager();

            //Assert
            Assert.IsInstanceOf(type, queryManager);
        }

        [Test]
        public void Build_does_not_return_null()
        {
            //Arrange
            var queryManager = GetQueryManager();

            //Act
            var query = queryManager.Build<ISomeQueryWithSorting>();

            //Assert
            Assert.IsNotNull(query);
        }

        private static QueryManager GetQueryManager()
        {
            var queryBuilderMock = new Mock<IQueryBuilder>();
            queryBuilderMock.Setup(p => p.Build<ISomeQueryWithSorting>()).Returns(new SomQuery());

            var queryProcessorMock = new Mock<IQueryProcessor>();

            return new QueryManager(queryBuilderMock.Object, queryProcessorMock.Object);
        }
    }
}