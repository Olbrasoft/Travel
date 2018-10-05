using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests
{
    [TestFixture]
    internal class CaptionConfigurationTest
    {
        [Test]
        public void Instance_Is_CreatorConfiguration_Of_Caption()
        {
            //Arrange
            var type = typeof(CreatorConfiguration<Caption>);

            //Act
            var configuration = new CaptionConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}