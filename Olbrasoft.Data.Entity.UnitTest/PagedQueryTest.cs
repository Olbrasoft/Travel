using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using Olbrasoft.Shared.Collections.Generic;
using Olbrasoft.Shared.Pagination;

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

        private static PageInfo PageInfo => new PageInfo(42, 8);


        class SomePagedQuery : PagedQuery<object>
        {
            public SomePagedQuery(IQueryable<object> queryable, IPageInfo pageInfo) : base(queryable, pageInfo)
            {
            }

            public new int Take => base.Take;
            public new int Skip => base.Skip;

            public new IQueryable<object> Queryable => base.Queryable;

            
            public override PagedCollection<object> Execute()
            {
                throw new NotImplementedException();
            }
        }



    }
}
