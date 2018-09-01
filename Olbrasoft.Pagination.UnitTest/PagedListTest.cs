using System.Collections.Generic;
using System.Linq;
using Moq;
using NUnit.Framework;
using Olbrasoft.Pagination.Linq;

namespace Olbrasoft.Pagination.UnitTest
{
    [TestFixture]
    public class PagedListTest
    {
        [Test]
        public void Is_Instance_Of_IEnumerable_Of_string()
        {
            //Arrange
            var subSet = new string[0];
            var pagedCollection = subSet.AsPagedList();

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

            var pagedStrings = subSet.AsPagedList();

            //Act
            var count = pagedStrings.Count();

            //Assert
            Assert.IsTrue(count == 10);
        }

        [Test]
        public void PageSize_Is_13()
        {
            //Arrange
            var subSet = new string[13];
            var pagedStrings = subSet.AsPagedList();

            //Act
            var pageSize = pagedStrings.PageSize;

            //Assert
            Assert.IsTrue(pageSize == 13);
        }

        [Test]
        public void PageNumber_Is_3()
        {
            //Arrange
            var subSet = new string[13];
            IPageInfo pageInfo = new PageInfo(13, 5);

            var pagedStrings = subSet.AsPagedList(new Pagination(pageInfo, subSet.Count));

            //Act
            var pageNumber = pagedStrings.PageNumber;

            //Assert
            Assert.IsTrue(pageNumber == 5);
        }

        [Test]
        public void TotalItemCount_is_150()
        {
            //Arrange
            var subSet = new string[13];
            var pageInfo = new Mock<IPageInfo>();
            var mockOfPagination = new Mock<IPagination>();
            mockOfPagination.Setup(p => p.PageInfo).Returns(pageInfo.Object);
            mockOfPagination.Setup(p => p.CountWithOutPaging()).Returns(150);

            var pagedStrings = subSet.AsPagedList(mockOfPagination.Object);

            //Act
            var totelItemCount = pagedStrings.TotalItemCount;

            //Assert
            Assert.IsTrue(totelItemCount == 150);
        }

        [Test]
        public void TotalItemCount_Is_1000()
        {
            //Arrange
            var subSet = new object[100];

            var mockOfPagination = new Mock<IPagination>();
            var pageInfo = new Mock<IPageInfo>();
            mockOfPagination.Setup(p => p.PageInfo).Returns(pageInfo.Object);
            mockOfPagination.Setup(p => p.CountWithOutPaging()).Returns(1000);
            
            //Act
            var pagedListOfAccommodation = subSet.AsPagedList(mockOfPagination.Object);

            //Assert
            Assert.IsTrue(pagedListOfAccommodation.TotalItemCount== 1000);


        }

    }
}