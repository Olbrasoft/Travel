using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Property;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests.Property
{
    [TestFixture]
    internal class DescriptionConfigurationTest
    {
        [Test]
        public void Instance_Is_PropertyConfiguration_Of_Description()
        {
            //Arrange
            var type = typeof(PropertyConfiguration<Description>);

            //Act
            var configuration = new DescriptionConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}