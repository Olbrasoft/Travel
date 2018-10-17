using NUnit.Framework;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Property;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests.Property
{
    [TestFixture]
    internal class ChainConfigurationTest
    {
        [Test]
        public void Instance_Is_CreatorConfiguration_Of_Chain()
        {
            //Arrange
            var type = typeof(PropertyConfiguration<Chain>);

            //Act
            var configuration = new ChainConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}