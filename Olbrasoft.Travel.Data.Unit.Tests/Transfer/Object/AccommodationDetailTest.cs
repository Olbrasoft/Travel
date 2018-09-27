using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Olbrasoft.Travel.Data.Transfer.Object;

namespace Olbrasoft.Travel.Data.Unit.Tests.Transfer.Object
{
    [TestFixture]
    internal class AccommodationDetailTest
    {
        [Test]
        public void Instance_Is_Accommodation()
        {
            //Arrange
            var type = typeof(Accommodation);

            //Act
            var accommodationDetail = new AccommodationDetail()
            {

            };
            
            //Assert
            Assert.IsInstanceOf(type, accommodationDetail);
        }
    }

}



