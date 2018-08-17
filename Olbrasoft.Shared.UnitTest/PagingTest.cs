using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Shared.Pagination;

namespace Olbrasoft.Shared.UnitTest
{
    [TestFixture()]
    public class PagingTest
    {
        [Test]
        public void IsInstanceOfIPaging()
        {
            //Arrange
            var numberOfSelectedPage = 5;
            var numberOfPages = 10;

            //Act
            var paging = new Paging(numberOfPages, numberOfSelectedPage);

            //Assert
            Assert.IsInstanceOf<IPaging>(paging);

        }


        [Test]
        public void PagingNumberOfSelectedPage0ThrowArgumentOutOfRangeException()
        {
            //Arrange
            var numberOfSelectedPage = 0;
            var numberOfPages = 10;


            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                // ReSharper disable once UnusedVariable
                var paging = new Paging(numberOfPages, numberOfSelectedPage);
            });
        }


        [Test]
        public void PagingNumberOfPages0ThrowArgumentOutOfRangeException()
        {
            //Arrange
            var numberOfSelectedPage = 2;
            var numberOfPages = 0;

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                // ReSharper disable once UnusedVariable
                var paging = new Paging(numberOfPages, numberOfSelectedPage);
            });

        }

        [Test]
        public void PagingNumberOfSelectedPageArgumentOutOfRangeException()
        {
            //Arrange
            var numberOfSelectedPage = 5;
            var numberOfPages = 3;

            //Assert
            Assert.Throws<ArgumentException>(() =>
            {
                // ReSharper disable once UnusedVariable
                var paging = new Paging(numberOfPages, numberOfSelectedPage);
            });

        }

        [Test]
        public void NumberOfPagesIs10()
        {
            //Arrange
            var paging = new Paging(10, 5);
            var numberOfPages = 0;

            //Act
            numberOfPages = paging.NumberOfPages;

            //Assert
            Assert.IsTrue(numberOfPages == 10);
        }

        [Test]
        public void NumberOfSelectedPageIs3()
        {
            //Arrange
            var paging = new Paging(7, 3);
            var numberOfSelectedPage = 1;

            //Act
            numberOfSelectedPage = paging.NumberOfSelectedPage;

            //Assert
            Assert.IsTrue(numberOfSelectedPage==3);
        }

    }
}
