using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Olbrasoft.Travel.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity.UnitTest
{
    [TestFixture]
    public class CreationInfoTest
    {
        [Test]
        public void IsInstanceOfICreationInfo()
        {
            
            var type = typeof(ICreationInfo);

            var result = new CreationInfo();

            Assert.IsInstanceOf(type, result);
        }

        [Test]
        public void IdIs10()
        {
            //Arrange
            var c = new CreationInfo(){Id=10};

            //Act
            var r = c.Id;

            //Assert
            Assert.IsTrue(r == 10);
        }


    }
}
