﻿using Moq;
using NUnit.Framework;
using Olbrasoft.Data.Query;
using Olbrasoft.Pagination;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Entity.Query.Handler;
using Olbrasoft.Travel.Data.Query;
using Olbrasoft.Travel.Data.Transfer.Object;
using System.Linq;

namespace Olbrasoft.Travel.Data.Entity.Unit.Tests.Query.Handler
{
    [TestFixture]
    internal class PagedAccommodationsItemsTest
    {
        [Test]
        public void Instance_Implement_Interface_IHandler()
        {
            //Arrange
            var localizedAccommodationsQueryableMock = new Mock<IQueryable<LocalizedAccommodation>>();

            var localizedAccommodationsMock = new Mock<IHaveQueryable<LocalizedAccommodation>>();
            localizedAccommodationsMock.Setup(p => p.Queryable).Returns(localizedAccommodationsQueryableMock.Object);

            //Act
            var handler = new PagedAccommodationItems(localizedAccommodationsMock.Object);

            //Assert
            Assert.IsInstanceOf<IHandle<GetPagedAccommodationItems, IResultWithTotalCount<AccommodationItem>>>(handler);
        }
    }
}