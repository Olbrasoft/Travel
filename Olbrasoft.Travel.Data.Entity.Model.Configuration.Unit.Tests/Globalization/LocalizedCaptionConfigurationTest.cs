using NUnit.Framework;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Globalization;
using Olbrasoft.Travel.Data.Entity.Model.Globalization;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests.Globalization
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