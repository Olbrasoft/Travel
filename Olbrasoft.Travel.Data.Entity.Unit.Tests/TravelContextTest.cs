using NUnit.Framework;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Entity.Unit.Tests
{
    [TestFixture]
    internal class TravelContextTest
    {
        [Test]
        public void MyTestMethod()
        {
            //Arrange
            var type = typeof(ITravelContext);

            //Act
            var context = new TravelContext();
            
            //Assert
            Assert.IsInstanceOf(type, context);
        }
    }
 }
