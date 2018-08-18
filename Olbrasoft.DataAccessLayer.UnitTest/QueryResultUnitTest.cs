using System;
using System.Linq;
using NUnit.Framework;

namespace Olbrasoft.DataAccessLayer.UnitTest
{
    [TestFixture]
    public class QueryResultUnitTest
    {
        [Test]
        public void CreateInstanceOfTypeQueryResultTest()
        {
            //Arrange
            var someItems = new SomeItem[0];
            IQueryResult<SomeItem> queryResult = new QueryResult<SomeItem>(someItems, 0);

            //Act
            var type = typeof(QueryResult<SomeItem>);

            //Assert
            Assert.IsInstanceOf(type, queryResult);
        }
        
        [Test]
        public void ItemsTest()
        {
            //Arrange
            const int count = 10;
            var someItems = new SomeItem[count];

            IQueryResult<SomeItem> queryResult = new QueryResult<SomeItem>(someItems, 100);

            //Act
            var items = queryResult.Items;

            //Assert
            Assert.IsTrue(items.Count() == count);
            Assert.IsTrue(queryResult.TotalNumberOfItemsWithoutPaging == 100);
        }

        [Test]
        public void ArgumentOutOfRangeExceptionTotalNumberOfItemsWithoutPagingTest()
        {
            //Arrange
            const int count = 10;
            var someItems = new SomeItem[count];

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                // ReSharper disable once UnusedVariable
                var queryResult = new QueryResult<SomeItem>(someItems, 1);
               
            });
        }

    }
}