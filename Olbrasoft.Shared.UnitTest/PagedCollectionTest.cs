using NUnit.Framework;
using Olbrasoft.Shared.Collections.Generic;
using Olbrasoft.Shared.Pagination;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace Olbrasoft.Shared.UnitTest
{
    [TestFixture]
    public class PagedCollectionTest
    {
        [Test]
        public void Is_Instance_Of_IEnumerable_Of_string()
        {
            //Arrange
            var subSet = new string[0];
            IPagedList<string> pagedCollection = new PagedCollection<string>(subSet, new PageInfo(), 10);

            //Act
            var r = pagedCollection;

            //Assert
            Assert.IsInstanceOf<IEnumerable<string>>(r);
        }

        [Test]
        public void Count_Is_10()
        {
            //Arrange
            var subSet = new string[10];
            IPagedList<string> pagedCollection = new PagedCollection<string>(subSet, new PageInfo(), 10);

            //Act
            var count = pagedCollection.Count();

            //Assert
            Assert.IsTrue(count == 10);
        }

        [Test]
        public void PageSize_Is_13()
        {
            //Arrange
            var subSet = new string[13];
            var pageInfo = new PageInfo(13);
            IPagedList<string> pagedCollection = new PagedCollection<string>(subSet, pageInfo, 50);

            //Act
            var pageSize = pagedCollection.PageSize;

            //Assert
            Assert.IsTrue(pageSize == 13);
        }

        [Test]
        public void PageNumber_Is_3()
        {
            //Arrange
            var subSet = new string[13];
            var pageInfo = new PageInfo(13, 5);
            IPagedList<string> pagedCollection = new PagedCollection<string>(subSet, pageInfo, 50);

            //Act
            var pageNumber = pagedCollection.PageNumber;

            //Assert
            Assert.IsTrue(pageNumber == 5);
        }

        [Test]
        public void TotalItemCount_is_150()
        {
            //Arrange
            var subSet = new string[13];
            var pageInfo = new PageInfo(13, 5);
            IPagedList<string> pagedCollection = new PagedCollection<string>(subSet, pageInfo, 150);

            //Act
            var totelItemCount = pagedCollection.TotalItemCount;

            //Assert
            Assert.IsTrue(totelItemCount == 150);
        }
    }
}