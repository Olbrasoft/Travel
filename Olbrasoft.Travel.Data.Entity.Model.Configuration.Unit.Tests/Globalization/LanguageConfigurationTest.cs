using System.Data.Entity.ModelConfiguration;
using NUnit.Framework;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Globalization;
using Olbrasoft.Travel.Data.Entity.Model.Globalization;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests.Globalization
{
    internal class LanguageConfigurationTest
    {
        [Test]
        public void Instance_Is_CreatorConfiguration_Of_Language()
        {
            //Arrange
            var type = typeof(EntityTypeConfiguration<Language>);

            //Act
            var configuration = new LanguageConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}