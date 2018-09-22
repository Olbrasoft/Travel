using Moq;
using NUnit.Framework;
using Olbrasoft.Collections.Generic;
using Olbrasoft.Data;
using Olbrasoft.Travel.Data.Entity.Query.Handlers;
using Olbrasoft.Travel.Data.Query;
using Olbrasoft.Travel.Data.Transfer.Object;
using System.Linq;
using Olbrasoft.Data.Query;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Entity.Unit.Tests.Query.Handlers
{
    [TestFixture]
    internal class PagedAccommodationsItemsTest
    {
        [Test]
        public void Instance_Implement_Interface_IHandler()
        {
            //Arrange
            var localizedAccommodationsQueryableMock = new Mock<IQueryable<LocalizedAccommodation>>();

            var localizedAccommodationsMock = new Mock<IHaveLocalizedAccommodations>();
            localizedAccommodationsMock.Setup(p => p.LocalizedAccommodations).Returns(localizedAccommodationsQueryableMock.Object);

            //Act
            var handler = new PagedAccommodationItems(localizedAccommodationsMock.Object);

            //Assert
            Assert.IsInstanceOf<IHandler<GetPagedAccommodationItems, IPagedList<AccommodationItem>>>(handler);
        }
    }
}