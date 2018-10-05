using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Property;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests.Property
{
    [TestFixture]
    internal class LocalizedAttributeConfigurationTest
    {
        [Test]
        public void Instance_Is_LocalizedConfiguration_Of_LocalizedAttribute()
        {
            //Arrange
            var type = typeof(Configuration.Property.LocalizedConfiguration<LocalizedAttribute>);

            //Act
            var configuration = new LocalizedAttributeConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}