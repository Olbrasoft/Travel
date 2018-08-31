using Moq;
using NUnit.Framework;
using Olbrasoft.Shared.Collections.Generic;
using Olbrasoft.Shared.Linq;
using Olbrasoft.Shared.Pagination;

namespace Olbrasoft.Shared.UnitTest
{
    [TestFixture]
    internal class EnumerableTest
    {
        [Test]
        public void Array_Of_Objects_AsPadedEnumerable_Return_Instance_Of_IPagedEnumerable_Of_object()
        {
            //Arrange
            var type = typeof(IPagedEnumerable<object>);
            var objects = new object[0];

            //Act
            var pagedEnumerable = objects.AsPagedEnumerable();

            //Assert
            Assert.IsInstanceOf(type, pagedEnumerable);
        }

        [Test]
        public void Pagination_CountWithOutPaging_Is_Twenty_One()
        {
            //Arrange
            var objects = new object[10];
            var pagination = new Mock<IPagination>();
            pagination.Setup(p => p.CountWithOutPaging()).Returns(21);
            var pagedEnumerable = objects.AsPagedEnumerable(pagination.Object);

            //Act
            var countWithOutPaging = pagedEnumerable.Pagination.CountWithOutPaging();

            //Assert
            Assert.IsTrue(countWithOutPaging == 21);
        }
    }
}