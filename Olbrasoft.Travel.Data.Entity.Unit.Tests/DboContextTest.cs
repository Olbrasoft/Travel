using NUnit.Framework;
using System.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity.Unit.Tests
{
    [TestFixture]
    internal class DboContextTest
    {
        [Test]
        public void Instance_Is_DbContext()
        {
            //Arrange
            var type = typeof(DbContext);

            //Act
            var context = DboContext();

            //Assert
            Assert.IsInstanceOf(type, context);
        }

        private static DboContext DboContext()
        {
            return new DboContext();
        }

        [Test]
        public void Instance_Is_IDbo()
        {
            //Arrange
            var type = typeof(IDbo);

            //Act
            var context = DboContext();

            //Assert
            Assert.IsInstanceOf(type, context);
        }
    }
}