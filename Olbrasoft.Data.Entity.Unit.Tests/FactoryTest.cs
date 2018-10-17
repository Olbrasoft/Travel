using NUnit.Framework;

namespace Olbrasoft.Data.Entity.Unit.Tests
{
    [TestFixture]
    internal class FactoryTest
    {
        [Test]
        public void Instance_Implement_Interface_IFactory()
        {
            //Arrange
            var type = typeof(IFactory);

            //Act
            var factory = new Factory();

            //Assert
            Assert.IsInstanceOf(type, factory);
        }
    }
}