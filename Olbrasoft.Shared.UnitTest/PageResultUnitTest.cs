﻿using System;
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
    public class PageResultUnitTest
    {
        [Test]
        public void CreateInstanceOfIPageResultTest()
        {
            //Arrange
            var items = new SomeItem[0];
            var paging = new Paging(1, 1);

            //Act
            var pageResult = new PageResult<SomeItem>(items, paging);

            //Assert
            Assert.IsInstanceOf<IPageResult<SomeItem>>(pageResult);
        }

        [Test]
        public void ItemsIsInstanceOfIEnumerableOfSomeItemTest()
        {
            //Arrange
            var someItems = new SomeItem[0];
            var paging = new Paging(1, 1);


            var pageResult = new PageResult<SomeItem>(someItems, paging);

            //Act
            var items = pageResult.Items;

            //Assert
            Assert.IsInstanceOf<IEnumerable<SomeItem>>(items);

        }

        [Test]
        public void PagingIsInstanceOfIPaging()
        {
            //Arrange
            var pageResult = new PageResult<SomeItem>(new SomeItem[0],new Paging(3,2) );

            //Act
            var paging = pageResult.Paging;

            //Assert
            Assert.IsInstanceOf<IPaging>(paging);

        }

      

    }

    public class SomeItem
    {
    }
}
