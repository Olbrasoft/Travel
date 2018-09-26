using System;
using NUnit.Framework;
using Olbrasoft.Data.Geography;

namespace Olbrasoft.Data.Unit.Tests.Geography
{
    [TestFixture]
    class PointTest
    {
        [Test]
        public void Instance_Implement_Interface_IPoint()
        {
            //Arrange
            var type = typeof(Point);

            //Act
            var point = new Point();

            //Assert
            Assert.IsInstanceOf(type,point);
        }


        

      
            
    }
}
