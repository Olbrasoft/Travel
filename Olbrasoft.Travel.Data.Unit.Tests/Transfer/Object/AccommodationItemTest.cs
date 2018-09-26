using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Travel.Data.Transfer.Object;

namespace Olbrasoft.Travel.Data.Unit.Tests.Transfer.Object
{
    [TestFixture]
    internal class AccommodationItemTest
    {

        [Test]
        public void Instance_Is_Accommodation()
        {
            //Arrange
            var type = typeof(Accommodation);

            //Act
            var accommodationItem = new AccommodationItem();

            //Assert
            Assert.IsInstanceOf(type,accommodationItem);
        }
    }
}
