using NUnit.Framework;
using Olbrasoft.Shared.Pagination;

namespace Olbrasoft.Shared.UnitTest
{
    [TestFixture]
    class PaginationTest
    {
        
        [Test]
        public void Is_Instance_BasePagination()
        {
            //Arrange
            var type = typeof(BasePagination);
            
           
            //Act
            var pagination = new Pagination.Pagination(PageInfo, GetThen );

            //Assert
            Assert.IsInstanceOf(type, pagination);

        }

        [Test]
        public void CountWithOutPaging_Is_Twenty()
        {
            //Arrange
            var pagination = new Pagination.Pagination(PageInfo, GetTwenty);

            //Act
            var count = pagination.CountWithOutPaging();

            //Assert
            Assert.IsTrue(count == 20);
        }

        private int GetTwenty()
        {
            return 20;
        }


        public int GetThen()
        {
            return 10;

        }

        public IPageInfo PageInfo { get; set; }
    }
}