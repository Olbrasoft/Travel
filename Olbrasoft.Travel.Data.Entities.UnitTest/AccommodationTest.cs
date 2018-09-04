using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Olbrasoft.Travel.Data.Entities.UnitTest
{
    [TestFixture]
    class AccommodationTest
    {
        [Test]
        public void Is_instance_of_IAccommodation()
        {
            //Arrange
            var type = typeof(IAccommodation);

            //Act
            var accommodation = new Accommodation();

            //Assert
           
        }

       

    }
}
