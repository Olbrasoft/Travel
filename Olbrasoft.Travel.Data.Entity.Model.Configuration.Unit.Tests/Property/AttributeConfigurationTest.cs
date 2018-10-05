using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests.Property
{
    [TestFixture]
    internal class AttributeConfigurationTest
    {
        [Test]
        public void Instance_Is_CreatorConfiguration_Of_Attribute()
        {
            //Arrange
            var type = typeof(Configuration.Property.CreatorConfiguration<Model.Property.Attribute>);

            //Act
            var configuration = new AttributeConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}