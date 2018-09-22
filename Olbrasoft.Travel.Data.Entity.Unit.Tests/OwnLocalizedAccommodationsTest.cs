using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Moq;
using NUnit.Framework;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Entity.Unit.Tests
{
    [TestFixture]
    internal class OwnLocalizedAccommodationsTest
    {
        [Test]
        public void Instance_Implement_Interface_IHaveLocalizedAccommodations()
        {
            //Arrange
            var travelContextMock = CreateTravelContextMock();
            
            //Act
            var own = new OwnLocalizedAccommodations(travelContextMock.Object);

            //Assert
            Assert.IsInstanceOf<IHaveLocalizedAccommodations>(own);
        }

        [Test]
        public void LocalizedAccommodations_Return_Is_Instance_Of_IQueryableOfLocalizedAccommodation()
        {
            //Arrange
            var travelContextMock = CreateTravelContextMock();


            //Act
            var localizedAccommodations = new OwnLocalizedAccommodations(travelContextMock.Object).LocalizedAccommodations;

            //Assert
            Assert.IsInstanceOf<IQueryable<LocalizedAccommodation>>(localizedAccommodations);
        }

        private Mock<ITravelContext> CreateTravelContextMock()
        {
            var travelContextMock = new Mock<ITravelContext>();
            var dbSetMock = new Mock<DbSet<LocalizedAccommodation>>();
            travelContextMock.Setup(p => p.LocalizedAccommodations).Returns(dbSetMock.Object);

            return travelContextMock;
        }

        //private static DbSet<T> GetQueryableMockDbSet<T>(List<T> sourceList) where T : class
        //{
        //    var queryable = sourceList.AsQueryable();

        //    var dbSet = new Mock<DbSet<T>>();
        //    dbSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(queryable.Provider);
        //    dbSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(queryable.Expression);
        //    dbSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
        //    dbSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(() => queryable.GetEnumerator());
        //    dbSet.Setup(d => d.Add(It.IsAny<T>())).Callback<T>(sourceList.Add);

        //    return dbSet.Object;
        //}
    }
}