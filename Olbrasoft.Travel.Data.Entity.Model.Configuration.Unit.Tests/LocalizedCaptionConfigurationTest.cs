using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests
{
    [TestFixture]
    internal class LocalizedCaptionConfigurationTest
    {
        [Test]
        public void Instance_Is_LocalizedConfiguration_Of_LocalizedCaption()
        {
            //Arrange
            var type = typeof(LocalizedConfiguration<LocalizedCaption>);

            //Act
            var configuration = new LocalizedCaptionConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}