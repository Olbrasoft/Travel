using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Olbrasoft.Data.Entity;
using Olbrasoft.Design.Pattern.Behavior;
using Olbrasoft.Pagination.Collections.Generic;
using Olbrasoft.Shared;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Entity.Queries.UnitTest
{
    [TestClass]
    public class LocalizedAccommodationsPagedQueryTest
    {
        [TestMethod]
        public void Is_Instance_Of_IPagedQuery()
        {
            //Arrange
            var type = typeof(IQuery< ILocalizedPagedQueryArgument, IPagedList<object>>);
            var mockQueryableOfAccommodation = new Mock<IQueryable<LocalizedAccommodation>>();
          

            //Act
            var query = new LocalizedAccommodationsPagedQuery(mockQueryableOfAccommodation.Object);

            //Assert
            Assert.IsInstanceOfType( query,type);
        }
    }
}