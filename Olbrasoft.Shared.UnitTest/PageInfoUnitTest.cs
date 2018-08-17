using NUnit.Framework;

namespace Olbrasoft.Shared.UnitTest
{
    [TestFixture()]
    public class PageInfoUnitTest
    {
        public PageInfo PageInfo { get; set; }

        [SetUp]
        public void Setup()
        {
            PageInfo = new PageInfo();
        }

        [Test]
        public void CreateInstanceOfTypePageUnitTestMethod()
        {
            //Arrange
            var pageInfo = PageInfo;

            //Act
            var typePagination = typeof(PageInfo);

            //Assert
            Assert.IsInstanceOf(typePagination, pageInfo);

        }

        [Test]
        public void PageSizeTypeUnitTestMethod()
        {
            //Arrange 
            var pageInfo = new PageInfo();

            //Act
            var pageSize = pageInfo.Size;

            //Assert
            Assert.IsInstanceOf<int>(pageSize);
        }


        [Test]
        public void PageNumberUnitTest()
        {
            //Arrange
            var pageInfo = new PageInfo();

            //Act
            var pageNumber = pageInfo.Number;

            //Assert
            Assert.IsInstanceOf<int>(pageNumber);
        }

        [Test]
        public void PageSizeDefaultValueUnitTestMethod()
        {
            //Arrange
            var pageInfo = PageInfo;

            //Act
            var pageSize = pageInfo.Size;

            //Assert 
            Assert.IsTrue(pageSize > 0);

        }

        [Test]
        public void PageNumberDefaultValueUnitTestMethod()
        {
            //Arrange 
            var pageInfo = PageInfo;

            //Act
            var pageNumber = pageInfo.Number;

            //Assert
            Assert.IsTrue(pageNumber == 1);
        }

    }
}
