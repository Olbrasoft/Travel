using Moq;
using NUnit.Framework;
using System.Linq;
using Olbrasoft.Pagination;
using Olbrasoft.Pagination.Collections.Generic;

namespace Olbrasoft.Data.Entity.UnitTest
{
    [TestFixture]
    public class PagedQueryTest
    {
        [Test]
        public void Is_Instance_Of_IPagedQuery()
        {
            //Arrange
            var type = typeof(IPagedQuery);
            var queryable = new object[0].AsQueryable();
            var pageInfo = new PageInfo();

            //Act
            var pagedQuery = new Mock<PagedQuery<object>>(queryable, pageInfo).Object;

            //Assert
            Assert.IsInstanceOf(type, pagedQuery);
        }

        [Test]
        public void Take_Return_42()
        {
            //Arrange
            var queryable = new object[0].AsQueryable();
            var pagedQuery = new SomePagedQuery(queryable, PageInfo);

            //Act
            var take = pagedQuery.Take;

            //Assert
            Assert.IsTrue(take == 42);
        }

        [Test]
        public void Skip_Return_294()
        {
            //Arrange
            var queryable = new object[0].AsQueryable();
            var pagedQuery = new SomePagedQuery(queryable, PageInfo);

            //Act
            var skip = pagedQuery.Skip;

            //Assert
            Assert.IsTrue(skip == 294);
        }

        [Test]
        public void Queryable_Count_Return_10()
        {
            //Arrange
            var queryable = new object[10].AsQueryable();
            var pagedQuery = new SomePagedQuery(queryable, PageInfo);

            //Act
            var count = pagedQuery.Queryable.Count();

            //Assert
            Assert.IsTrue(count == 10);
        }

        [Test]
        public void Execute_has_been_set_to_pageinfo()
        {
            //Arrange
            var queryable = new object[10].AsQueryable();
            var pagedQuery = new SomePagedQuery(queryable);

            //Act
            pagedQuery.Execute(PageInfo);

            //Assert
            Assert.IsTrue(pagedQuery.PageInfo.NumberOfSelectedPage == PageInfo.NumberOfSelectedPage &&
                          pagedQuery.PageInfo.PageSize == PageInfo.PageSize);
        }

        [Test]
        public void TotalItemCount_return_100()
        {
            //Arrange
            var queryable = new object[100].AsQueryable();
            var pagedQuery = new SomePagedQuery(queryable);

            //Act
            var totalItemCount = pagedQuery.TotalItemCount;

            //Assert
            Assert.IsTrue(totalItemCount == 100);
        }

        private static PageInfo PageInfo => new PageInfo(42, 8);

        private class SomePagedQuery : PagedQuery<object>
        {
            public new int Take => base.Take;
            public new int Skip => base.Skip;

            public new int TotalItemCount => base.TotalItemCount;

            public new IPageInfo PageInfo => base.PageInfo;

            public new IQueryable<object> Queryable => base.Queryable;

            public SomePagedQuery(IQueryable<object> queryable, IPageInfo pageInfo) : base(queryable, pageInfo)
            {
            }

            public SomePagedQuery(IQueryable<object> queryable) : base(queryable)
            {
            }

            public override IPagedList<object> Execute()
            {
                return null;
            }
        }
    }
}