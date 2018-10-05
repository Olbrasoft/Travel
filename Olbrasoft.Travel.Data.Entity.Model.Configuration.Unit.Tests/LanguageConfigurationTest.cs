using NUnit.Framework;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests
{
    internal class LanguageConfigurationTest
    {
        [NUnit.Framework.Test]
        public void Instance_Is_CreatorConfiguration_Of_Language()
        {
            //Arrange
            var type = typeof(CreatorConfiguration<Language>);

            //Act
            var configuration = new LanguageConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}